using Monopoly.Model.Interfaces;
using Monopoly.Model.Players;

namespace Monopoly.Model.Tiles
{
    public class Tax : Tile, ITile
    {
        //For the tax tile (position number 4 = 200)
        public int TaxAmount { get; private set; }
        public Tax(int index, string name, int taxAmount)
            //Call the base contructor
            :base(index, name)
        {
            this.TaxAmount = taxAmount;
        }
        //Everytime the player lands on this it will subtract the money
        //This si in a string to be visble to the player
        public override string ActOnPlayer(Player player)
        {
            player.DecrementMoney(this.TaxAmount);
            return this.Name + ": " + this.TaxAmount;
        }
    }
}
