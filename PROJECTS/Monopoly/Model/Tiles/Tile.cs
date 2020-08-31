using Monopoly.Model.Interfaces;
using Monopoly.Model.Players;

namespace Monopoly.Model.Tiles
{
    //Abstract class that inherits from the ITile class
    public abstract class Tile : ITile  
    {
        //index number and name of the tile
        public Tile(int index, string name)
        {
            this.Index = index;
            this.Name = name;
        }

        public int Index { get; private set; }
        public string Name { get; private set; }

        //Implement the interface
        public abstract string ActOnPlayer(Player player);


    }
}
