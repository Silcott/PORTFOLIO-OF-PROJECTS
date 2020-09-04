using Microsoft.Xna.Framework.Input;
using Monopoly.Model;
using Monopoly.View.UI;

namespace Monopoly.Controller.States
{
    //Inherits from State
    public class PlayerTurnState : State
    {
        public PlayerTurnState(State nextState)
            : base(nextState) { }

        public override void Execute()
        {
            Button rollButton = EntryPoint.Game.Renderer.RollButton;
            EntryPoint.Game.Renderer.NotificationText = "Player" +
                (Board.CurrentPlayerIndex + 1) +
                "'s turn! \nPlease roll!";
            bool mouseOverRoll = rollButton.Sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverRoll)
            {
                rollButton.ChangeToHoverImage();
            }
            else
            {
                rollButton.ChangeToInactiveImage();
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverRoll)
            {
                rollButton.ChangeToClickedImage();
                EntryPoint.Game.Renderer.ShouldPlayerMove = true;
                StateMachine.ChangeState();
            }
        }
    }
}
