using Monopoly.View.UI;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Numerics;

namespace Monopoly.View.Renderers
{
    //Inherits from the AbstractRenderer
    public class MonoGameRenderer : AbstractRenderer
    {
        private ContentManager Content = EntryPoint.game.Content;
        private SpriteBatch SpriteBatch;

        public Button BuyButton;
        public Button RollButton;
        public Button EndTurnButton;

        public Dice FirstDice;
        public Dice SecondDice;

        //Player pawns
        public List<PlayerUI> PlayerUI;
        public PlayerUI FirstPlayer;
        public PlayerUI SecondPlayer;
        private int velocity;
        //know where the player goes after every roll
        private Rectangle TileDestination;
        public bool ShouldPlayerMove;

        //Background
        private Background background;
        //Tile Notifications in an array
        public TileOwnerNotification[] TileNotifications;
        //Tile Colliders in an array
        public Rectangle[] TileColliders;

        //Font
        private SpriteFont font;

        public string NotificationText;
        public string PlayerOneMoney;
        public string PlayerTwoMoney;

        //Instantate the Renderer
        public MonoGameRenderer()
        {
            this.background = UIInitializer.CreateBackground(Content);
            this.BuyButton = UIInitializer.CreateBuyButton(Content);
            this.RollButton = UIInitializer.CreateRollButton(Content);
            this.EndTurnButton = UIInitializer.CreateEndTurnButton(Content);
            this.FirstDice = UIInitializer.CreateDice(Content, 1);
            this.SecondDice = UIInitializer.CreateDice(Content, 2);
            this.FirstPlayer = UIInitializer.CreatePlayer(Content, 1);
            this.SecondPlayer = UIInitializer.CreatePlayer(Content, 2);

            this.PlayerUI = new List<PlayerUI>();
            this.PlayerUI.Add(FirstPlayer);
            this.PlayerUI.Add(SecondPlayer);

            this.TileNotifications = UIInitializer.CreateTileOwnerNotificaitons(Content);
            this.TileColliders = UIInitializer.CreateTileColliders();
            this.velocity = 400;
            this.ShouldPlayerMove = false;

            //Display at the beginning
            this.NotificationText = "James Silcott Game\nMonopoly";
            this.PlayerOneMoney = "1500$";
            this.PlayerTwoMoney = "1500$";
            //Load the font
            this.font = Content.Load<SpriteFont>("Font");
        }

        public override void DrawBoard()
        {
            this.SpriteBatch = EntryPointNotFoundException.game.SpriteBatch;
            //Draw background
            background.Draw(SpriteBatch);
            //Draw Buttons
            BuyButton.Draw(SpriteBatch);
            RollButton.Draw(SpriteBatch);
            EndTurnButton.Draw(SpriteBatch);
            //Draw Dice
            FirstDice.Draw(SpriteBatch);
            SecondDice.Draw(SpriteBatch);
            //Draw Players
            foreach (var player in PlayerUI)
            {
                player.Draw(SpriteBatch);
            }

            foreach (var notification in TileNotifications)
            {
                notification.Draw(SpriteBatch);
            }

            SpriteBatch.DrawString(font, NotificationText, new Vector2(105, 105), Color.Black);
            SpriteBatch.DrawString(font, PlayerOneMoney, new Vector2(105, 525), Color.Blue);
            SpriteBatch.DrawString(font, PlayerTwoMoney, new Vector2(105, 560), Color.Red);
        }

         
        public override void MovePlayer(int playerIndex, int currentPosition, int newPosition)
        {
            PlayerUI currentPlayer = PlayerUI[playerIndex];
            TileDestination = TileColliders[newPosition];
            //Player moves until they reach this tile
            if (TileDestination.Contains(currentPlayer.Sprite.Rectangle))
            {
                //The player lands on the tile they rolled to
                this.ShouldPlayerMove = false;
            }
            else
            {
                //If the player is in the bottom row of the board move left
                if (currentPlayer.Sprite.Rectangle.Y>606 && currentPlayer.Sprite.Rectangle.X>30)
                {
                    currentPlayer.Sprite.Rectangle.X -= (int)(velocity * EntryPoint.game.Elapsed); 
                }
                //If the player is in the left row of the board move up
                else if (currentPlayer.Sprite.Rectangle.X <= 50 && currentPlayer.Sprite.Rectangle.Y > 30)
                {
                    currentPlayer.Sprite.Rectangle.Y -= (int)(velocity * EntryPoint.game.Elapsed);

                }
                //If the player is in the top row of the board move right
                else if (currentPlayer.Sprite.Rectangle.Y <= 50 && currentPlayer.Sprite.Rectangle.X < 650)
                {
                    currentPlayer.Sprite.Rectangle.X += (int)(velocity * EntryPoint.game.Elapsed);

                }
                //If the player is in the right row of the board move down
                else if (currentPlayer.Sprite.Rectangle.Y >= 620 && currentPlayer.Sprite.Rectangle.Y < 680)
                {
                    currentPlayer.Sprite.Rectangle.Y += (int)(velocity * EntryPoint.game.Elapsed);

                }
            }
        }

        public override void ShowTileOwner(int playerIndex, int currentPlayerPosition)
        {
            for (int i = 0; i < this.TileNotifications.Count(); i++)
            {
                if (this.TileNotifications[i].BoardIndex == currentPlayerPosition)
                {
                    this.TileNotifications[i].SetOwner(Content, playerIndex + 1);
                    break;
                }
            }
        }
    }
}
