﻿using SharpDX.Direct3D11;
using System.Drawing;

namespace Monopoly.View.UI
{
    public class Dice
    {
        public Sprite Sprite { get; set; }
        //List of textures
        public Texture2D[] valueSprites = new Texture2D[6];

        public Dice(Sprite sprite, Texture2D[] valueSprites)
        {
            this.Sprite = sprite;
            this.valueSprites = valueSprites;
        }

        public void ChangeDiceImage(int diceValue)
        {
            this.Sprite.Image = this.valueSprites[diceValue - 1];
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Sprite.Image, this.Sprite.Rectangle, Color.White);
        }
    }
}