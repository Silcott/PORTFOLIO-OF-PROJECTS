//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D11;
using System.Drawing;

namespace Monopoly.View.UI
{
    public class Sprite
    {
        //Rectangle is where the image will be placed and how big it will be and the Texture2D is the image loaded separtaly
        public Sprite(Rectangle rectangle, Texture2D image)
        {
            this.Rectangle = rectangle;
            this.Image = image;
        }

        public Rectangle Rectangle;
        public Texture2D Image { get; set; }
    }
}
