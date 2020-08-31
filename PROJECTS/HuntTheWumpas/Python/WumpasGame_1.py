"""Hunt the Wumpus - a simple game in Python

My first Python program.
"""
import sys
import random

class Game:
    "Hunt the Wumpus Game Class"

    # The cave map
    CAVES = {
        "A":["B","E","F"],
        "B":["A","C","H"],
        "C":["B","D","J"],
        "D":["C","E","L"],
        "E":["A","D","N"],
        "F":["A","G","O"],
        "G":["F","H","T"],
        "H":["B","G","I"],
        "I":["H","J","S"],
        "J":["C","I","K"],
        "K":["J","L","R"],
        "L":["D","K","M"],
        "M":["L","N","Q"],
        "N":["E","M","O"],
        "O":["F","N","P"],
        "P":["O","Q","T"],
        "Q":["M","P","R"],
        "R":["K","Q","S"],
        "S":["I","R","T"],
        "T":["G","P","S"]
        }
    output = sys.stdout.write;


    # start for the player
    player = "A"

    # the standard environment (will be randomised)
    wumpus = "T"
    NUM_PITS = 2
    NUM_BATS = 2
    pits = ["I","O"]  # should be wiped by random positions
    bats = ["G","M"]  # should also be wiped by random positions
    shots = 5    

    def __init__(self):
        pass
    
    def run(self):        
        "Runs the game of Hunt the Wumpus"
        self.printWelcome()
        self.output("Do you need instructions (y/N)? ")
        if self.readInput() == "Y":
            self.printInstructions()
        loop = True
        while (loop):
            self.setEnvironment()
            self.mainLoop()
            self.output("Do you want to play another game (Y/n)? ")
            if self.readInput() == "N":
                loop = False
        self.output("Fare thee well, mighty hunter!\n")
            

    def mainLoop(self):
        "The main loop that runs the hunt"
        isGameActive = True
                # loop until we win, lose or quit
        while (isGameActive):
            self.output("\n")
            self.describeChamber()
            self.output("Do you want to (M)ove or (S)hoot? ")
            action = self.readInput()    # get the input letter
            if action == "M":    # MOVE
                self.output("Which chamber to move to (")
                    # print the options of neighbours
                neighbours = self.CAVES[self.player]
                for chamber in neighbours[:-1]:
                    self.output("%s, " % chamber)
                self.output("%s)? " % neighbours[-1])
                chamber = self.readInput()
                if chamber in neighbours:
                    self.player = chamber
                    self.output("Tread carefully...\n")
                else:
                    self.output("That's not a valid move...\n")
            elif action == "S":    # SHOOT
                self.output("Which chamber to shoot into (")
                    # print the options of neighbours
                neighbours = self.CAVES[self.player]
                for chamber in neighbours[:-1]:
                    self.output("%s, " % chamber)
                self.output("%s)? " % neighbours[-1])
                chamber = self.readInput()
                if chamber in neighbours:
                    self.output("You fire your trusty blunderbuss! BLAM!!\n")
                    self.shots = self.shots - 1
                        # was it a hit?
                    if chamber == self.wumpus:
                        self.output("THUWMP!! The wumpus has been slain!\nWell done, mighty hunter!\n")
                        isGameActive = False
                    else:
                        if self.shots > 0:
                            self.output("The echo of the shot cannons through the caverns\n")
                             # should move the wumpus now
                            self.output("You hear the wumpus flumphing about. It might have moved...\n")
                            wumpus_choices = list(self.CAVES[self.wumpus])
                            wumpus_choices.append(self.wumpus)
                            self.wumpus = random.choice(wumpus_choices)
                            if self.shots > 1:
                                self.output("You've got %d shots left\n" % self.shots)
                            else:
                                self.output("Last shot. Make it count!\n")
                        else:
                            self.output("AARGHH! You've caused a cave in!!\nRocks fall, everybody dies!!\n")
                            isGameActive = False    
                else:
                    self.output("You can't shoot there, silly...\n")
            elif action == "Q":    # QUIT
                self.output("Do you want to end this game? (y/N) ")
                if self.readInput == "Y":
                    isGameActive = False
            # check to see if this room is safe
            moveLoop = isGameActive
            while moveLoop:
                moveLoop = False
                if self.player == self.wumpus:
                    self.output("AARGHH!! You've bumped into the wumpus!\n")
                    self.output("It seems the hunter is now the hunted... or rather, lunch.\n")
                    isGameActive = False
                elif self.player in self.pits:
                    self.output("AARGHH!! You've fallen into a bottomless pit!\n")
                    self.output("When you fall into a bottomless pit, you die of starvation...\n")
                    isGameActive = False
                elif self.player in self.bats:
                    self.output("OH NO!! You've run into some giant bats!\n")
                    self.player = random.choice(self.CAVES.keys())
                    self.output("They've carried you to Chamber %s. Hope it's not too dangerous...\n" % self.player)
                    moveLoop = True
                    
            
    def describeChamber(self):
        "Describes the players chamber"
        neighbours = self.CAVES[self.player]
        self.output("You are currently in Chamber %s.\n" % self.player)
        self.output("Passages lead to Chambers ")
        for cavern in neighbours[:-1]:
            self.output("%s, " % cavern)
        self.output("and %s.\n" % neighbours[-1])
            # need to check for breezes, stenches and bat chatter
        chatter = False
        breeze = False
        stench = False
        if self.wumpus in neighbours:
            stench = True
        for cavern in self.pits:
            if cavern in neighbours:
                breeze = True
        for cavern in self.bats:
            if cavern in neighbours:
                chatter = True
        if stench:
            self.output("You smell a wumpus!\n")
        if chatter:
            self.output("You hear the chatter of bats.\n")
        if breeze:
            self.output("You feel a nearby breeze.\n")
            
    
    def printWelcome(self):
        "Prints the welcome message to the screen"
        self.output(" HUNT THE WUMPUS ".center(50, "-"))
        self.output("\n")

    def printInstructions(self):
        "Prints out the instructions for Hunt the Wumpus"
        self.output("""There's a wumpus loose in the underground caverns!
As the great wumpus hunter, it is your job to hunt it down with your trusty blunderbuss!

On your turn, you can move or shoot into one of three caverns.
You have five shots with which to hunt the wumpus.
You can sense when a wumpus is nearby by its tell-tale stench.
Look out for pits; you'll feel a breeze when nearby.
Also watch for the bats; they delight in randomly dropping hunters into caverns.

Good luck, mighty hunter!
""");
                
    def readInput(self):
        "Reads in a line of imput, and returns the first character (all that's needed for the game)"
        i = sys.stdin.readline()
        return i[0].upper()

    def setEnvironment(self):
        """Sets the environment: the player to pos. A, and randomise everything else
                Random position of the wumpus
                Random bats (for the number of the caves)
                Random pits (for the number of pits)
        """
        cave_list = self.CAVES.keys()
        self.player = "A"
            # remove the player position from the list
        cave_list.remove("A")
        self.wumpus = random.choice(cave_list)
        num_random_pos = self.NUM_PITS + self.NUM_BATS
        random_list = random.sample(cave_list, num_random_pos)    # need to make sure nothing is in the same pos to begin with
        self.pits = random_list[:self.NUM_PITS]
        self.bats = random_list[-self.NUM_BATS:]
        self.shots = 5
    
    
if __name__ == "__main__":
    wumpusGame = Game();
    wumpusGame.run()   # run the main game function
