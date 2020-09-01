using Monopoly.Model;
using OpenTK.Input;

namespace Monopoly.Controller.States
{
    public class EndTurnState : State
    {
        public EndTurnState(State endState)
            : base(endState) { }

        

        public override void Execute()
        {
            ActivateEndTurn();
        }
        private void ActivateEndTurn()
        {
            View.UI.Button endTurnButton = EntryPoint.Game.Renderer.EndTurnButton;

            bool mouseOverEndTurn = endTurnButton.Sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverEndTurn)
            {
                endTurnButton.ChangeToHoverImage();
            }
            else
            {
                endTurnButton.ChangeToInactiveImage();
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverEndTurn)
            {
                Board.CurrentPlayerIndex = (Board.CurrentPlayerIndex + 1) % Board.players.Count;
                endTurnButton.ChangeToClickedImage();
                StateMachine.ChangeState();
            }
        }

    }
}
