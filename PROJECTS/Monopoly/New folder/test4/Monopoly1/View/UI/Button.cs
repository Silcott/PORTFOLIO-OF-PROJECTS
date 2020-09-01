using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Monopoly.View.UI
{
    public class Button
    {
        //The differnmt images when the button and mouse is used
        public Button(Sprite sprite, Texture2D hoverImage, Texture2D clickedImage, Texture2D inactiveImage)
        {
            this.Sprite = sprite;
            this.hoverImage = hoverImage;
            this.clickedImage = clickedImage;
            this.inactiveImage = inactiveImage;
        }

        public Sprite Sprite { get; set; }
        public Texture2D hoverImage { get; set; }
        public Texture2D clickedImage { get; set; }
        public Texture2D inactiveImage { get; set; }

        public void ChangeToHoverImage()
        {
            this.Sprite.Image = this.hoverImage;
        }

        public void ChangeToClickedImage()
        {
            this.Sprite.Image = this.clickedImage;

        }
        public void ChangeToInactiveImage()
        {
            this.Sprite.Image = this.inactiveImage;

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(this.Sprite.Image, this.Sprite.Rectangle, Color.White);
        }
    }
}
