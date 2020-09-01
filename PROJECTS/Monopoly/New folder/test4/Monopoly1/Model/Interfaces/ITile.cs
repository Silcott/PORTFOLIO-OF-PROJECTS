namespace Monopoly.Model.Interfaces
{
    using Players;
    public interface ITile
    {
        int Index { get; }
        string Name { get; }
        //used for different type of cards, such as streets, chance cards, jail, go to jail...etc
        //takes the player and can change the position, the money, give buy options
        string ActOnPlayer(Player player);


    }
}
