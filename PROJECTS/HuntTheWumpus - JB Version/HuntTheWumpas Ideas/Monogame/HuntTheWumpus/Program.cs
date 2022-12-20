using HuntTheWumpas;
using System;

namespace HuntTheWumpus
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new HuntWumpus())
                game.Run();
        }
    }
}
