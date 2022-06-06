namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Knight knight = new Knight("player1", 1);
            System.Console.WriteLine(knight);
        }
    }
}