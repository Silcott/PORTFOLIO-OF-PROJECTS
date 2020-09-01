using Monopoly.Model;
using System;

namespace Monopoly.Controller.States
{
    //Inherits from State
    public class PlayerRollState : State
    {
        private Random rng;
        public PlayerRollState(State nextState)
            : base(nextState) 
        {
            this.rng = new Random();
        }

        public override void Execute()
        {
            int currentPlayerPosition = Board.players[Board.CurrentPlayerIndex].CurrentPosition;
            //Create random dice number for rolls
            int firstDiceNumber = rng.Next(1, 7);
            int secondDiceNumber = rng.Next(1, 7);
            int totalPositionToMove = firstDiceNumber + secondDiceNumber;

            //Keep reference of where the player was moved to move from that new point in the next trun
            PlayerMoveState.PlayerOldPosition = currentPlayerPosition;
            //Change image of first dice
            EntryPoint.Game.Renderer.FirstDice.ChangeDiceImage(firstDiceNumber);
            //Change image of second dice
            EntryPoint.Game.Renderer.SecondDice.ChangeDiceImage(secondDiceNumber);
            //Change the text
            EntryPoint.Game.Renderer.NotificationText = "Player " + (Board.CurrentPlayerIndex + 1) + " rolled " + totalPositionToMove;
            //Change the position of the current player
            Board.players[Board.CurrentPlayerIndex].SetPosition(currentPlayerPosition + totalPositionToMove);

            StateMachine.ChangeState();
        }

    }
}
