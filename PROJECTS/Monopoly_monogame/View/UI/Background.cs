using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Monopoly.View.UI
{
    public class Background
    {
        private Sprite sprite;

        public Background(Sprite sprite)
        {
            this.sprite = sprite;
        }

        //Specifc for the monoGame Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.sprite.Image, this.sprite.Rectangle, Color.White);//White so there is no tint
        }
    }
}
