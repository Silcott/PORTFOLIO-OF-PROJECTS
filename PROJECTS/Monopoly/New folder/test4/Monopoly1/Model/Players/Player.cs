using Monopoly.Model.Interfaces;
using Monopoly.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monopoly.Model.Players
{

    public class Player : IPlayer
    {
        //Initial Player Constant
        public const int INITIAL_PLAYER_MONEY = 1500;
        //Used to make calculation when change the player
        public const int TOTAL_NUMBER_OF_TILES = 40;

            public Player(int index)
        {
            this.Index = index;
        }

        //Set position and give it a new position
        public void SetPosition(int newPosition)
        {
            int modifiedPosition = newPosition;

            //If the player moves around the board to tile numbered 0 or moves less due to a chance card then the 
            //value would be less than 0 so add "40" (number of tiles)  
            if (modifiedPosition < 0)
            {
                modifiedPosition += TOTAL_NUMBER_OF_TILES;
            }

            //If you move around the board it will change the number when you cross over the max and return the value to start "0" (minus 40)
            if (modifiedPosition >= TOTAL_NUMBER_OF_TILES)
            {
                //when we go around "GO" give 200
                modifiedPosition = modifiedPosition - TOTAL_NUMBER_OF_TILES;
                this.IncrementMoney(200);
            }

            this.CurrentPosition = modifiedPosition;
        }
        //Add money method
        public void IncrementMoney(int amount)
        {
            this.Money += amount;
        }
        //Subtract money method
        public void DecrementMoney (int amount)
        {
            this.Money -= amount;
        }

        public List<Street> Streets { get; private set; } = new List<Street>();

        public int CurrentPosition { get; private set; } = 0;
        public int Index { get; private set; }

        public bool IsInJail { get; private set; } = false;

        public int Money { get; private set; } = INITIAL_PLAYER_MONEY;
    }
}
