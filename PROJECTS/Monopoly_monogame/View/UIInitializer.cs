using Monopoly.View.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Monopoly.View
{
    public static class UIInitializer
    {
        public static Button CreateBuyButton(ContentManager content)
        {
            Texture2D buyActive = content.Load<Texture2D>("Buy");
            Texture2D buyClicked = content.Load<Texture2D>("BuyClicked");
            Texture2D buyHover = content.Load<Texture2D>("Hoverbuy");
            //Rectangle size = int x, int y, int width, int height
            Rectangle buyRectangle = new Rectangle(450, 450, 80, 80);

            return buyButton;
        }

        //public static Button CreateBuyButton(ContentManager content)
        //{
        //    Texture2D rollActive = content.Load<Texture2D>("Active");
        //    Texture2D rollClicked = content.Load<Texture2D>("Clicked");
        //    Texture2D rollHover = content.Load<Texture2D>("Hover");

        //    Sprite buyButtonSprite = new Sprite(buyRectangle, buyActive);
        //    Button buyButton = new Button(buyButtonSprite, buyHover, buyClicked, buyActive);

        //    return buyButton;
        //}

        public static Button CreateRollButton(ContentManager content)
        {
            Texture2D rollActive = content.Load<Texture2D>("Active");
            Texture2D rollClicked = content.Load<Texture2D>("Clicked");
            Texture2D rollHover = content.Load<Texture2D>("Hover");
            Rectangle rollRectangle = new Rectangle(300, 450, 120, 120);

            Sprite rollButtonSprite = new Sprite(rollRectangle, rollActive);
            Button rollButton = new Button(rollButtonSprite, rollHover, rollClicked, rollActive);

            return rollButton;
        }

        public static Button CreateEndTurnButton(ContentManager content) 
            {
                Texture2D endTurnActive = content.Load<Texture2D>("EndTurn");
                Texture2D endTurnClicked = content.Load<Texture2D>("EndTurnClicked");
                Texture2D endTurnHover = content.Load<Texture2D>("EndTurnHover");
                Rectangle endTurnRectangle = new Rectangle(450, 515, 80, 80);

                Sprite rollButtonSprite = new Sprite(endTurnRectangle, endTurnActive);
                Button rollButton = new Button(rollButtonSprite, endTurnHover, endTurnClicked, endTurnActive);

                return rollButton;
            } 

        public static Dice CreateDice(ContentManager content, int index)
        {
            Texture2D[] diceImages = new Texture2D[6];
            for (int i = 0; i < 6; i++)
            {
                diceImages[i] = content.Load<Texture2D>((i + 1).ToString());
            }
            Rectangle diceRectangle = new Rectangle(298 + index * 32, 560, 30, 30);
            Sprite diceSprite = new Sprite(diceRectangle, diceImages[0]);
            Dice dice = new Dice(diceSprite, diceImages);
            return dice;
        }

        public static Background CreateBackground(ContentManager content)
        {
            Texture2D backgroundImage = content.Load<Texture2D>("FinalBaord");
            Rectangle backgroundRectangle = new Rectangle(0, 0, 700, 700);
            Sprite backgroundSprite = new Sprite(backgroundRectangle, backgroundImage);

            Background background = new Background(backgroundSprite);
        }

        public static PlayerUI CreatePlayer(ContentManger content, int index)
        {
            Texture2D playerImage = content.Load<Texture2D>("pawn" + index.ToString());
            Rectangle playerRectangle = new Rectangle(620, 600 + index * 30, 28, 28);
            Sprite playerSprite = new Sprite(playerRectangle, playerImage);
            PlayerUI playerUI = new PlayerUI(playerSprite, index);
            return playerUI;
        }

        public static TileOwnerNotification[] CreateTileOwnerNotificaitons(ContentManager content)
        {
            int xIncrement = 57;
            TileOwnerNotification[] tileOwnerNotifications = new TileOwnerNotification[28];
            tileOwnerNotifications[0] = new TileOwnerNotification(1, new Sprite(new Rectangle(607 - xIncrement, 607, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[1] = new TileOwnerNotification(3, new Sprite(new Rectangle(607 - 3 * xIncrement, 607, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[2] = new TileOwnerNotification(5, new Sprite(new Rectangle(607 - 5 * xIncrement, 607, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[3] = new TileOwnerNotification(6, new Sprite(new Rectangle(607 - 6 * xIncrement, 607, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[4] = new TileOwnerNotification(8, new Sprite(new Rectangle(607 - 8 * xIncrement, 607, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[5] = new TileOwnerNotification(9, new Sprite(new Rectangle(607 - 9 * xIncrement, 607, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[6] = new TileOwnerNotification(11, new Sprite(new Rectangle(0, 607 - xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[7] = new TileOwnerNotification(12, new Sprite(new Rectangle(0, 607 - 2 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[8] = new TileOwnerNotification(13, new Sprite(new Rectangle(0, 607 - 3 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[9] = new TileOwnerNotification(14, new Sprite(new Rectangle(0, 607 - 4 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[10] = new TileOwnerNotification(15, new Sprite(new Rectangle(0, 607 - 5 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[11] = new TileOwnerNotification(16, new Sprite(new Rectangle(0, 607 - 6 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[12] = new TileOwnerNotification(18, new Sprite(new Rectangle(0, 607 - 8 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[13] = new TileOwnerNotification(19, new Sprite(new Rectangle(0, 607 - 9 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[14] = new TileOwnerNotification(21, new Sprite(new Rectangle(93, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[15] = new TileOwnerNotification(23, new Sprite(new Rectangle(93 + 2 * xIncrement, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[16] = new TileOwnerNotification(24, new Sprite(new Rectangle(93 + 3 * xIncrement, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[17] = new TileOwnerNotification(1, new Sprite(new Rectangle(93 + 4 * xIncrement, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[18] = new TileOwnerNotification(1, new Sprite(new Rectangle(93 + 5 * xIncrement, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[19] = new TileOwnerNotification(1, new Sprite(new Rectangle(93 + 6 * xIncrement, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[20] = new TileOwnerNotification(1, new Sprite(new Rectangle(93 + 7 * xIncrement, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[21] = new TileOwnerNotification(1, new Sprite(new Rectangle(93 + 8 * xIncrement, 0, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[22] = new TileOwnerNotification(1, new Sprite(new Rectangle(607, 93, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[23] = new TileOwnerNotification(1, new Sprite(new Rectangle(607, 93 + xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[24] = new TileOwnerNotification(1, new Sprite(new Rectangle(607, 93 + 3 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[25] = new TileOwnerNotification(1, new Sprite(new Rectangle(607, 93 + 4 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[26] = new TileOwnerNotification(1, new Sprite(new Rectangle(607, 93 + 6 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            tileOwnerNotifications[27] = new TileOwnerNotification(1, new Sprite(new Rectangle(607, 93 + 8 * xIncrement, 15, 15), content.Load<Texture2D>("Owner1")));
            return tileOwnerNotifications;

        }

        //Tells when the player starts moving where to stop
        public static Rectangle[] CreateTileColliders()
        {
            Rectangle[] tileColliders = new Rectangle[40];
            int xIncrement = 57;
            int WINDOW_WIDTH = 700;
            int WINDOW_HEIGHT = 700;

            tileColliders[0] = new Rectangle(607, 607, WINDOW_WIDTH - 607, WINDOW_HEIGHT - 607);
            tileColliders[1] = new Rectangle(607 - xIncrement, 607, WINDOW_WIDTH - 607, WINDOW_HEIGHT - 607);
            tileColliders[2] = new Rectangle(607 - 2 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[3] = new Rectangle(607 - 3 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[4] = new Rectangle(607 - 4 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[5] = new Rectangle(607 - 5 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[6] = new Rectangle(607 - 6 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[7] = new Rectangle(607 - 7 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[8] = new Rectangle(607 - 8 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[9] = new Rectangle(607 - 9 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[10] = new Rectangle(0, 607, 93, WINDOW_HEIGHT - 607);
            tileColliders[11] = new Rectangle(0, 607 - xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[12] = new Rectangle(0, 607 - 2 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[13] = new Rectangle(0, 607 - 3 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[14] = new Rectangle(0, 607 - 4 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[15] = new Rectangle(0, 607 - 5 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[16] = new Rectangle(0, 607 - 6 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[17] = new Rectangle(0, 607 - 7 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[18] = new Rectangle(0, 607 - 8 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[19] = new Rectangle(0, 607 - 9 * xIncrement, 93, WINDOW_HEIGHT - 607);
            tileColliders[20] = new Rectangle(0, 0, 93, 93);
            tileColliders[21] = new Rectangle(93, 0, xIncrement, 93);
            tileColliders[22] = new Rectangle(93 + xIncrement, 0, xIncrement, 93);
            tileColliders[23] = new Rectangle(93 + 2 * xIncrement, 0, xIncrement, 93);
            tileColliders[24] = new Rectangle(93 + 3 * xIncrement, 0, xIncrement, 93);
            tileColliders[25] = new Rectangle(93 + 4 * xIncrement, 0, xIncrement, 93);
            tileColliders[26] = new Rectangle(93 + 5 * xIncrement, 0, xIncrement, 93);
            tileColliders[27] = new Rectangle(93 + 6 * xIncrement, 0, xIncrement, 93);
            tileColliders[28] = new Rectangle(93 + 7 * xIncrement, 0, xIncrement, 93);
            tileColliders[29] = new Rectangle(93 + 8 * xIncrement, 0, xIncrement, 93);
            tileColliders[30] = new Rectangle(607, 0, WINDOW_WIDTH - 607, 93);
            tileColliders[31] = new Rectangle(607, 93, 93, xIncrement);
            tileColliders[32] = new Rectangle(607, 93 + xIncrement, 93, xIncrement);
            tileColliders[33] = new Rectangle(607, 93 + 2 * xIncrement, 93, xIncrement);
            tileColliders[34] = new Rectangle(607, 93 + 3 * xIncrement, 93, xIncrement);
            tileColliders[35] = new Rectangle(607, 93 + 4 * xIncrement, 93, xIncrement);
            tileColliders[36] = new Rectangle(607, 93 + 5 * xIncrement, 93, xIncrement);
            tileColliders[37] = new Rectangle(607, 93 + 6 * xIncrement, 93, xIncrement);
            tileColliders[38] = new Rectangle(607, 93 + 7 * xIncrement, 93, xIncrement);
            tileColliders[39] = new Rectangle(607, 93 + 8 * xIncrement, 93, xIncrement);

            return tileColliders;
        }
    }
}
