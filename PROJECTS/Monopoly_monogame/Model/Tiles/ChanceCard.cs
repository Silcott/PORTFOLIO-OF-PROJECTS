using Monopoly.Model.Interfaces;
using Monopoly.Model.Players;

namespace Monopoly.Model.Tiles
{
    public class ChanceCard : Tile, ITile
    {
        public ChanceCard(int index, string name)
            :base(index, name)
        {

        }

        public override string ActOnPlayer(Player player)
        {
            return ChanceCardGenerator.GenerateRandomCard(player);
        }



    }
}
