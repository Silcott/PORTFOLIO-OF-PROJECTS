using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;

namespace HuntTheWumpus
{
    public class CavernDirections
    {
        public int CavernNumberToTheRight { get; set; }
        public int CavernNumberToTheLeft { get; set; }
        public int CavernNumberStraightAhead { get; set; }
    }
}
