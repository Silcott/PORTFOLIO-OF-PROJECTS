using Caliburn.Micro;
using Monopoly.Model;
using Monopoly.Model.Tiles;
using Monopoly.View.UI;
using OpenTK.Input;

namespace Monopoly.Controller.States
{
    public class PlayerLandedState : State
    {

        public PlayerLandedState(State nextState)
            :base(nextState) { }

        public override void Execute()
        {
            int playerIndex = Board.CurrentPlayerIndex;
            int playerCurrentPosition = Board.players[playerIndex].CurrentPosition;
            Tile currentTile = Board.allTiles[playerCurrentPosition];

            EntryPoint.Game.Renderer.NotificationText = "Player " + (playerIndex + 1) + "landed on \n" + currentTile.Name;
            //Gives money and who takes the turn and sends it by notification text
            EntryPoint.Game.Renderer.NotificationText += currentTile.ActOnPlayer(Board.players[playerIndex]);
            EntryPoint.Game.Renderer.PlayerOneMoney = Board.players[0].Money + "$";
            EntryPoint.Game.Renderer.PlayerTwoMoney = Board.players[1].Money + "$";

            ActivateEndTurn();

            if (currentTile is Street)
            {
                var currentTileAsStreet = currentTile as Street;
                //if no owner by the current tile, then activat the buy button
                if (currentTileAsStreet.Owner == null)
                {
                    ActivateBuyButton(playerCurrentPosition);
                }
                //Else change the state
                else
                {
                    StateMachine.ChangeState();
                }
            }
            else if (currentTile is ChanceCard)
            {
                StateMachine.ChangeState();
            }
            else if (currentTile is ChanceCard || currentTile is Tax)
            {
                StateMachine.ChangeState();
            }
            else if (currentTile is SpecialTile)
            {
                var currentTileAsSpecial = currentTile as SpecialTile;

                if (currentTileAsSpecial.Index == 30)
                {
                    EntryPoint.Game.Renderer.MovePlayer(Board.CurrentPlayerIndex, 30, 10);
                }
            }

        }
        private void ActivateEndTurn()
        {
            Button endTurnButton = EntryPoint.Game.Renderer.EndTurnButton;
            EntryPoint.Game.Renderer.NotificationText = "Are you sure you want to end your turn?"; 
            
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
                endTurnButton.ChangeToClickedImage();
                StateMachine.ChangeState();
            }
        }
        private void ActivateBuyButton(int playerCurrentPosition)
        {
            Button buyButton = EntryPoint.Game.Renderer.BuyButton;
            int currentPlayer = Board.CurrentPlayerIndex;
            bool mouseOverBuy = buyButton.Sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverBuy)
            {
                buyButton.ChangeToHoverImage();
            }
            else
            {
                buyButton.ChangeToInactiveImage();
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverBuy)
            {
                buyButton.ChangeToClickedImage();
                EntryPoint.Game.Renderer.NotificationText = "Property bought";
                Board.AddStreetToPlayer(currentPlayer, playerCurrentPosition);
                EntryPoint.Game.Renderer.ShowTileOwner(currentPlayer, playerCurrentPosition);
                EntryPoint.Game.Renderer.PlayerOneMoney = Board.players[0].Money + "$";
                EntryPoint.Game.Renderer.PlayerTwoMoney = Board.players[1].Money + "$";

                StateMachine.ChangeState();
            }
        }
    }
}
