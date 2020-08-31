using Monopoly.Model.Interfaces;
using Monopoly.Model.Players;

namespace Monopoly.Model.Tiles
{
    public class SpecialTile : Tile, ITile
    {
        public SpecialTile(int index, string name)
            :base(index, name)
        {

        }

        public override string ActOnPlayer(Player player)
        {
            if (this.Index == 0)
            {
                player.IncrementMoney(200);
                return "You landed on GO. \nCollect $200!";
            }
            else if (this.Index == 10)
            {
                return "You are visiting your \ndear friend in Jail.";
            }
            else if (this.Index == 20)
            {
                return "You landed on Free Parking. \nNothing happens.";
            }
            else
            {
                return "You are in Jail! You will skip the next three turns.";
            }
        }


    }
}
