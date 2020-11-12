using System;
using System.Collections.Generic;
using System.Linq;
using Monopoly.Model.Interfaces;
using Monopoly.Model.Players;


namespace Monopoly.Model.Tiles
{
    public static class ChanceCardGenerator
    {
        private static readonly Random rng = new Random();
        private const int GO_POSITION = 0;
        private const int MAYFAIR_POSTION = 39;
        private const int BANK_MONEY_BOUNS = 100;
        private const int PRETTY_BOUNS = 50;

        //List of Functions that will be executed depending on which chance card you get
        private static List<Func<Player, string>> listOfChanceCards = new List<Func<Player, string>>
        {
            //Fuction lists
            BankIsGivingYouMoney,
            YouArePrettyGivingBonus,
            GiveAmountToOtherPlayers

        };

        private static string BankIsGivingYouMoney(Player player)
        {
            player.IncrementMoney(BANK_MONEY_BOUNS);
            return "The Bank is giving you $100. \nKeep it safe!";
        }
        private static string YouArePrettyGivingBonus(Player player)
        {
            player.IncrementMoney(PRETTY_BOUNS);
            return "You have won a \nfashion contest. Receive $50.";
        }
        private static string GiveAmountToOtherPlayers(Player player)
        {
            Board.players[Board.CurrentPlayerIndex].DecrementMoney(30);
            Board.players[(Board.CurrentPlayerIndex +1) % 2].IncrementMoney(30);
            return "The other player is smarter. \nGive him/her $30.";
        }

        public static string GenerateRandomCard(Player player)
        {
            listOfChanceCards = listOfChanceCards
                //Shuffle the collection
                .OrderBy(x => rng.Next())
                .ToList();

            Func<Player, string> randomChanceCard = listOfChanceCards[rng.Next(0, 3)];

            //Call a random method by invoking it
            return randomChanceCard.Invoke(player);
        }



    }
}
