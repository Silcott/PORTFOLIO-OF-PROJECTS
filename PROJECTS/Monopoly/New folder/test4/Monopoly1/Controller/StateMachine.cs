using Monopoly.Controller.States;
using System.Collections.Generic;

namespace Monopoly.Controller
{
    public static class StateMachine
    {
        public static State CurrentState;
        //Dictionary with State string names as keys and the State Mehtods as values
        public static Dictionary<string, State> States = new Dictionary<string, State>();
        private static EndTurnState endTurnState;
        private static PlayerLandedState playerLandedState;
        private static PlayerMoveState playerMoveState;
        private static PlayerRollState playerRollState;
        private static PlayerTurnState playerTurnState;
        private static InitialState initialState;


        //private static EndTurnState endTurnState;
        //private static PlayerLandedState playerLandedState;
        //private static PlayerMoveState playerMoveState;
        //private static PlayerRollState playerRollState;

        public static void Initialize()
        {
            endTurnState = new EndTurnState(playerTurnState);
            playerLandedState = new PlayerLandedState(endTurnState);
            //Move player
            playerMoveState = new PlayerMoveState(playerLandedState);
            //Create the roll
            playerRollState = new PlayerRollState(playerMoveState);
            //Create the player turnState with initialState
            playerTurnState = new PlayerTurnState(playerRollState);
            //Since it doesn't have anything create another
            initialState = new InitialState(playerTurnState);
            endTurnState.NextState = playerTurnState;

            States.Add("InitialState", initialState);
            States.Add("PlayerTurnState", playerTurnState);
            States.Add("PlayerRollState", playerRollState);
            States.Add("PlayerMoveState", playerMoveState);
            States.Add("PlayerLandedState", playerLandedState);
            States.Add("EndTurnState", endTurnState);

            //endTurnState = new EndTurnState(playerTurnState);
            //playerLandedState = new PlayerLandedState(endTurnState);
            //playerMoveState = new PlayerMoveState(playerLandedState);
            //playerRollState = new PlayerRollState(playerMoveState);
            //playerTurnState = new PlayerTurnState(playerRollState);
        }
    
        //Change the states
        public static void ChangeState()
        {
            CurrentState = CurrentState.NextState;
        }
    
    
    }
}
