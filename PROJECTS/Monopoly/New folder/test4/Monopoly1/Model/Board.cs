using System;
using System.Collections.Generic;
using Monopoly.Model.Players;
using Monopoly.Model.Tiles;
using Monopoly.Model.Enums;
using System.ComponentModel;

namespace Monopoly.Model
{
    public static class Board
    {
        //Player List
        public static List<Player> players;
        //Tile List
        public static List<Tile> allTiles;
        //Who's turn is it?
        public static int CurrentPlayerIndex;

        public static void InitializeBoard()
        {
            CurrentPlayerIndex = 0;
            players = new List<Player>()
            {
                new Player(1),
                new Player(2)
            };
            //All tiles on board
            allTiles = new List<Tile>()
            {
                new SpecialTile(0, "GO!"),
                new Street(1, "Old Kent Road", NeighbourHoodTypes.Brown,60,2),//price, rent
                new ChanceCard(2, "Community Chest"),
                new Street(3, "Whitechapel Road", NeighbourHoodTypes.Brown,60,4),
                new Tax(4, "Income Tax", 200),
                new Street(5, "Kings Cross Station", NeighbourHoodTypes.Station,200,25),
                new Street(6, "The Angel Islington", NeighbourHoodTypes.Blue,100,6),
                new ChanceCard(7, "Chance Card"),
                new Street(8, "Euston Road", NeighbourHoodTypes.Blue,100,6),
                new Street(9, "Pentonville Road", NeighbourHoodTypes.Blue,120,8),
                new SpecialTile(10, "Jail"),
                new Street(11, "Pall Mall", NeighbourHoodTypes.HotPink,140,10),
                new Street(12, "Electric Company", NeighbourHoodTypes.Utility,150,20),
                new Street(13, "Whitehall", NeighbourHoodTypes.HotPink,140,10),
                new Street(14, "Northumberland Avenue", NeighbourHoodTypes.HotPink,160,12),
                new Street(15, "Marylebone Station", NeighbourHoodTypes.Station,200,25),
                new Street(16, "Bow Street", NeighbourHoodTypes.Orange,180,14),
                new ChanceCard(17, "Community Chest"),
                new Street(18, "Marlborough Street", NeighbourHoodTypes.Orange,180,14),
                new Street(19, "Vine Street", NeighbourHoodTypes.Orange,200,16),
                new SpecialTile(20, "Free Parking"),
                new Street(21, "Strand", NeighbourHoodTypes.Red,220,18),
                new ChanceCard(22, "Chance Card"),
                new Street(23, "Fleet Street", NeighbourHoodTypes.Red,220,18),
                new Street(24, "Trafalgar Square", NeighbourHoodTypes.Red,240,20),
                new Street(25, "Fenchurch Station", NeighbourHoodTypes.Station,200,25),
                new Street(26, "Leicester Square", NeighbourHoodTypes.Yellow,260,24),
                new Street(27, "Coventry Street", NeighbourHoodTypes.Yellow,260,24),
                new Street(28, "Water Works", NeighbourHoodTypes.Utility,150,20),
                new Street(29, "Picadilly", NeighbourHoodTypes.Yellow,280,26),
                new SpecialTile(30, "Go To Jail"),
                new Street(31, "Regent Street", NeighbourHoodTypes.Green,300,28),
                new Street(32, "Oxford Street", NeighbourHoodTypes.Green,300,28),
                new ChanceCard(33, "Community Chest"),
                new Street(34, "Bond Street", NeighbourHoodTypes.Green,320,30),
                new Street(35, "Liverpool Station", NeighbourHoodTypes.Station,200,25),
                new ChanceCard(36, "Chance Card"),
                new Street(37, "Park Lane", NeighbourHoodTypes.Purple,350,35),
                new Tax(38, "Super Tax",150),
                new Street(39, "Mayfair",NeighbourHoodTypes.Purple,400,50)
                };
        }
        public static void AddStreetToPlayer(int streetIndex, int playerIndex)
        {
            //Current street casted becasue its in  a list Tile
            Street currentStreet = (Street)allTiles[streetIndex];
            currentStreet.Owner = players[playerIndex];

            players[playerIndex].Streets.Add(currentStreet);
            players[playerIndex].DecrementMoney(currentStreet.Price);
        }

    }
}
