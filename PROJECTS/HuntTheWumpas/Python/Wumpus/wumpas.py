from enum import Enum
import json
import random
from typing import Iterable, NamedTuple, Dict, Sequence, Tuple


from .gridworld import Agent, WorldObject, GridWorld, Coordinate, coord, GridWorldException, UserPlayer


class WumpusWorldObject(WorldObject):

    def _setWorld(self, world: 'WumpusWorld'):
        self._world = world

    @property
    def world(self) -> 'WumpusWorld':
        return self._world


class Wumpus(WumpusWorldObject):
    def charSymbol(self):
        return 'W'


class Pit(WumpusWorldObject):
    def charSymbol(self):
        return 'P'


class Gold(WumpusWorldObject):
    def charSymbol(self):
        return 'G'


class Exit(WumpusWorldObject):
    def charSymbol(self):
        return ' '


class Hunter(Agent):

    class Actions(Agent.Actions):
        MOVE = 0
        RIGHT = 1
        LEFT = 2
        SHOOT = 3
        GRAB = 4
        CLIMB = 5

    class Orientation(Enum):
        N = (0, 1)
        S = (0, -1)
        E = (1, 0)
        W = (-1, 0)

    class Percept(NamedTuple):
        stench: bool
        breeze: bool
        bump: bool
        scream: bool
        glitter: bool

        def __str__(self):
            result = []
            if self.stench:
                result.append('Stench')
            if self.breeze:
                result.append('Breeze')
            if self.bump:
                result.append('Bump')
            if self.scream:
                result.append('Scream')
            if self.glitter:
                result.append('Glitter')
            return ', '.join(result) if len(result) else 'none'

    ROT_RIGHT = {
        Orientation.N: Orientation.E,
        Orientation.E: Orientation.S,
        Orientation.S: Orientation.W,
        Orientation.W: Orientation.N
    }
    ROT_LEFT = {v: k for k, v in ROT_RIGHT.items()}

    def __init__(self, orientation: 'Hunter.Orientation' = None):
        super().__init__()
        self._orientation: self.Orientation = orientation if orientation is not None else self.Orientation.N
        self._reward: int = 0
        self._alive: bool = True
        self._scream: bool = False
        self._arrow: bool = True
        self._done: bool = False
        self._bump: bool = False
        self._has_gold: int = 0

    @property
    def world(self) -> 'WumpusWorld':
        return self._world

    def success(self) -> bool:
        """Return true once the goal of the agent has been achieved."""
        return self._done

    def percept(self):
        return self.Percept(
            stench=self.stench,
            breeze=self.breeze,
            bump=self.bump,
            scream=self.scream,
            glitter=self.glitter
        )

    def _delta(self, direction: 'Hunter.Orientation') -> Coordinate:
        return Coordinate(
            x=self.location.x + direction.value[0],
            y=self.location.y + direction.value[1])

    def _rotate(self, direction: str) -> 'Hunter.Orientation':
        new_dir = (self.ROT_RIGHT if direction[0].lower() == 'r' else self.ROT_LEFT)[self.orientation]
        return new_dir

    def _aligned(self, pos: Coordinate) -> bool:
        if self.orientation == self.Orientation.N:
            return self.location.x == pos.x and self.location.y < pos.y
        elif self.orientation == self.Orientation.S:
            return self.location.x == pos.x and self.location.y > pos.y
        elif self.orientation == self.Orientation.W:
            return self.location.x > pos.x and self.location.y == pos.y
        else:
            return self.location.x < pos.x and self.location.y == pos.y

    @property
    def orientation(self):
        return self._orientation

    @property
    def reward(self) -> int:
        """The current accumulated reward"""
        return self._reward

    @property
    def isAlive(self):
        """Return true is the hunter is still alive."""
        return self._alive

    @property
    def scream(self) -> bool:
        return self._scream

    @property
    def arrow(self) -> bool:
        return self._arrow

    @property
    def stench(self):
        return any(
            self.world.isWumpus(self._delta(d)) for d in self.Orientation
        )

    @property
    def breeze(self):
        return any(
            self.world.isPit(self._delta(d)) for d in self.Orientation
        )

    @property
    def glitter(self):
        return self.world.isGold(self.location) is not None

    @property
    def bump(self):
        return self._bump

    def charSymbol(self):
        return '@'

    def do(self, action: 'Hunter.Actions') -> int:
        """Execute an action and return the reward of the action."""

        if not self.isAlive or self._done:
            raise ValueError('Cannot do anything while dead or task is completed')

        reward = 0
        self._scream = False
        self._bump = False

        if action == self.Actions.MOVE:
            reward -= 1
            new_pos = self._delta(self.orientation)
            try:
                self.world.moveObject(self, new_pos)
            except GridWorldException:
                self._bump = True
            if self.world.isWumpus(self.location) or self.world.isPit(self.location):
                self._alive = False
                reward -= 1000
        elif action == self.Actions.RIGHT:
            reward -= 1
            self._orientation = self._rotate('r')
        elif action == self.Actions.LEFT:
            reward -= 1
            self._orientation = self._rotate('l')
        elif action == self.Actions.SHOOT:
            if self.arrow:
                self._arrow = False
                reward -= 10
                for wumpus in [w for w in self.world.objects if isinstance(w, Wumpus)]:
                    if self._aligned(wumpus.location):
                        self._scream = True
                        self.world.removeObject(wumpus)
            else:
                reward -= 1
        elif action == self.Actions.GRAB:
            reward -= 1
            gold = self.world.isGold(self.location)
            if gold:
                self._has_gold += 1
                self.world.removeObject(gold)
        elif action == self.Actions.CLIMB:
            reward -= 1
            if self.world.isExit(self.location):
                self._done = True
                reward += 1000 * self._has_gold
        else:
            raise ValueError('Unrecognised action {}'.format(action))

        self._reward += reward
        return reward


class WumpusWorld(GridWorld):

    @classmethod
    def classic(cls, size: int = 4, seed=None, pitProb: float = .2):
        """Create a classic wumpus world problem of the given size. The agent is placed in (0,0) facing north and there's exactly one wumpus and a gold ingot. The seed is used to initialise the random number generation and pits are placed with pitProb probability."""

        world = cls(coord(size, size), [])

        agentPos = coord(0, 0)

        world.addObject(Hunter(orientation=Hunter.Orientation.N), agentPos)
        world.addObject(Exit(), agentPos)

        world.random_populate(pitProb=pitProb, seed=seed, wumpus=1, gold=1)

        return world

    @classmethod
    def from_JSON(cls, json_obj: Dict):
        """Create a wumpus world from a JSON object"""

        def getCoord(lst: Sequence[int]) -> Coordinate:
            return coord(lst[0], lst[1])

        def coordLst(key: str) -> Iterable[Coordinate]:
            data = json_obj.get(key, [])
            if len(data) < 1:
                return []
            elif isinstance(data[0], Sequence):
                # list of coordinates
                return [getCoord(c) for c in data]
            else:
                return [getCoord(data)]

        size = coordLst('size')[0]
        blocks = coordLst('blocks')
        hunters = json_obj.get('hunters', [])
        pits = coordLst('pits')
        wumpuses = coordLst('wumpuses')
        exits = coordLst('exits')
        golds = coordLst('golds')

        world = cls(size, blocks)

        for hunter in (hunters if (len(hunters) == 0) or isinstance(hunters[0], Sequence) else [hunters]):
            pos = getCoord(hunter)
            try:
                orientation = Hunter.Orientation[str(hunter[2]).upper()]
            except Exception:
                orientation = Hunter.Orientation.N
            world.addObject(Hunter(orientation=orientation), pos)

        for pos in (exits or [coord(0, 0)]):
            world.addObject(Exit(), pos)

        for pos in wumpuses:
            world.addObject(Wumpus(), pos)

        for pos in pits:
            world.addObject(Pit(), pos)

        for pos in golds:
            world.addObject(Gold(), pos)

        return world

    def random_populate(self, pitProb: float = .2, seed=None, wumpus: int = 1, gold: int = 1):
        """Randomly popolate a wumpus world with pits, gold, and wumpus. Pits and wumpus are not placed in the same place where the agent is."""

        def randomPlace(skipPos) -> Coordinate:
            pos = None
            while pos is None or self.isBlock(pos) or pos in skipPos:
                pos = coord(random.randint(0, self.size.x - 1), random.randint(0, self.size.y - 1))
            return pos

        agentPos = tuple(o.location for o in self.objects if isinstance(o, Hunter))
        random.seed(seed)

        # place the wumpus
        for i in range(wumpus):
            self.addObject(Wumpus(), randomPlace(agentPos))

        # place the gold
        for i in range(gold):
            self.addObject(Gold(), randomPlace(agentPos))

        # place the pits
        for row in range(self.size.y):
            for col in range(self.size.x):
                pos = coord(col, row)
                # place a pit with probability pitProb
                # but not in the same place as the agent
                if (random.random() < pitProb) and (pos not in agentPos) and (not self.isBlock(pos)):
                    self.addObject(Pit(), pos)

    def _objAt(self, cls, pos: Coordinate) -> Iterable[WumpusWorldObject]:
        """Return an iterable over the objects at the coordinate filtered by the given class cls (accepts the same class specification as the isinstance function)."""
        return [o for o in self.objects_at(pos) if isinstance(o, cls)]

    def isWumpus(self, pos: Coordinate) -> Wumpus:
        """Return a wumpus if it's at the coordinate or None."""
        return next(iter(self._objAt(Wumpus, pos)), None)

    def isHunter(self, pos: Coordinate) -> Hunter:
        """Return a hunter if it's at the coordinate or None."""
        return next(iter(self._objAt(Hunter, pos)), None)

    def isPit(self, pos: Coordinate) -> Pit:
        """Return a pit if it's at the coordinate or None."""
        return next(iter(self._objAt(Pit, pos)), None)

    def isGold(self, pos: Coordinate) -> Gold:
        """Return a gold if it's at the coordinate or None."""
        return next(iter(self._objAt(Gold, pos)), None)

    def isExit(self, pos: Coordinate) -> Exit:
        """Return a exit if it's at the coordinate or None."""
        return next(iter(self._objAt(Exit, pos)), None)

    def to_JSON(self) -> Dict:
        """Return a JSON serialisable object with the description of the world."""

        def coord_tuple(c: Coordinate) -> Tuple[int]:
            return (c.x, c.y)

        def add_to_json(obj: Dict, key: str, lst: Sequence):
            if len(lst) > 0:
                obj[key] = lst

        size = coord_tuple(self.size)
        blocks = [coord_tuple(c) for c in self.blocks]
        hunters = []
        pits = []
        wumpuses = []
        exits = []
        golds = []
        for obj in self.objects:
            if isinstance(obj, Hunter):
                hunters.append(coord_tuple(obj.location) + (obj.orientation.name,))
            elif isinstance(obj, Pit):
                pits.append(coord_tuple(obj.location))
            elif isinstance(obj, Wumpus):
                wumpuses.append(coord_tuple(obj.location))
            elif isinstance(obj, Exit):
                exits.append(coord_tuple(obj.location))
            elif isinstance(obj, Gold):
                golds.append(coord_tuple(obj.location))

        json_obj = {'size': size}

        add_to_json(json_obj, 'blocks', blocks)
        add_to_json(json_obj, 'hunters', hunters)
        add_to_json(json_obj, 'pits', pits)
        add_to_json(json_obj, 'wumpuses', wumpuses)
        add_to_json(json_obj, 'exits', exits)
        add_to_json(json_obj, 'golds', golds)

        return json_obj

    def __str__(self):

        def objChar(obj: WumpusWorldObject) -> str:
            return obj.charSymbol() if obj is not None else ' '

        BLOCK_W = 3
        L_BORDER = R_BORDER = '│'
        DIRECTION = {
            Hunter.Orientation.N: '^',
            Hunter.Orientation.S: 'V',
            Hunter.Orientation.W: '<',
            Hunter.Orientation.E: '>'
        }

        def top_line() -> str:
            return '┌' + '┬'.join('─' * BLOCK_W for i in range(self.size.x)) + '┐'

        def bottom_line() -> str:
            return '└' + '┴'.join('─' * BLOCK_W for i in range(self.size.x)) + '┘'

        def mid_line():
            return '├' + '┼'.join('─' * BLOCK_W for i in range(self.size.x)) + '┤'

        lines = [top_line()]
        for row in range(self.size.y - 1, -1, -1):
            cell = [L_BORDER, L_BORDER]

            for col in range(self.size.x):
                pos = coord(col, row)
                if self.isBlock(pos):
                    cell[0] += '█' * BLOCK_W
                    cell[1] += '█' * BLOCK_W
                else:
                    cell[0] += objChar(self.isWumpus(pos))
                    cell[0] += objChar(self.isGold(pos))
                    cell[0] += objChar(self.isPit(pos))

                    hunter = self.isHunter(pos)
                    if hunter is not None:
                        cell[1] += ' ' + objChar(hunter)
                        cell[1] += DIRECTION[hunter.orientation]
                    else:
                        cell[1] += ' ' * BLOCK_W

                cell[0] += R_BORDER
                cell[1] += R_BORDER

            lines.extend(cell)
            if row > 0:
                lines.append(mid_line())

        lines.append(bottom_line())
        return '\n'.join(lines)


if __name__ == "__main__":
    WORLD_MAP = '\n'.join([
        '....#',
        '.....',
        '.....',
        '.....',
        '.....',
    ])
    # world = WumpusWorld.randomWorld(size=7, blockProb=0.1, world_desc=WORLD_MAP)
    world = WumpusWorld.classic(size=7)
    hunter = next(iter(o for o in world.objects if isinstance(o, Hunter)), None)
    world.run_episode(hunter, UserPlayer.player())

    print(json.dumps(world.to_JSON()))
    JSON_STRING = '{"size": [7, 7], "hunters": [[0, 0, "E"]], "pits": [[4, 0], [3, 1], [2, 2], [6, 2], [4, 4], [3, 5], [4, 6], [5, 6]], "wumpuses": [[1, 2]], "exits": [[0, 0]], "golds": [[6, 3]]}'
    world = WumpusWorld.from_JSON(json.loads(JSON_STRING))
    print(world)
    print(json.dumps(world.to_JSON()))

