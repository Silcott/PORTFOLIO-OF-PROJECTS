using Monopoly.View.Renderers;

namespace Monopoly.Controller.States
{
    public abstract class State
    {
        //Constructor
        public State(State nextState)
        {
            this.NextState = nextState;
        }

        public State NextState { get; set; }

        //Used for every State to have a different execution
        public abstract void Execute();
        //Draw Method for drawing buttons and backgrounds
        public void Draw(MonoGameRenderer renderer)
        {
            renderer.DrawBoard();
        }



    }
}
