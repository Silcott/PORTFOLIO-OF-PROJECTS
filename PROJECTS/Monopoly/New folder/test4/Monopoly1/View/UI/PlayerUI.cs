namespace Monopoly.View.UI
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    public class PlayerUI
    {
        public int Index { get; private set; }
        //Depending on the player image load a differnet image
        public Sprite Sprite { get; set; }
    
        //Constructor
        public PlayerUI(Sprite sprite, int index)
        {
            this.Sprite = sprite;
            this.Index = index;
        }
    
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Sprite.Image, this.Sprite.Rectangle, Color.White);
        }
    
    
    
    
    }
}
