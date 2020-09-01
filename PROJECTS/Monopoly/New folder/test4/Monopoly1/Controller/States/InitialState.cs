using Monopoly.Model;

namespace Monopoly.Controller.States
{
    //Inherits from State
    public class InitialState : State
    {
        public InitialState(State nextState)
            : base(nextState) { }

        //Use IntializeBoard method
        public override void Execute()
        {
            Board.InitializeBoard();
        }
    }



}
