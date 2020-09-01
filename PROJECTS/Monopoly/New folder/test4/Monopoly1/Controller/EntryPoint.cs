namespace Monopoly.Controller
{
    public static class EntryPoint
    {
        public static MonopolyGame Game;
        static void Main()
        {
            using (Game = new MonopolyGame())
                Game.Run();
        }

    }
}
