using Monopoly.Model;
using System.Drawing;

namespace Monopoly.Controller.States
{
    public class PlayerMoveState : State
    {

        public static int PlayerOldPosition { get; set; }

        public PlayerMoveState(State nextState)
            : base(nextState) { }

        public override void Execute()
        {
            EntryPoint.Game.Renderer.MovePlayer(Board.CurrentPlayerIndex, 
                PlayerOldPosition,                
                Board.players[Board.CurrentPlayerIndex].CurrentPosition);

            //If we collid with a tile then we went to our desitnation
            //If ShouldPlayer equal false
            if (!EntryPoint.Game.Renderer.ShouldPlayerMove)
            {
                StateMachine.ChangeState();
            }
        }
    }
}
