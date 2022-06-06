namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Bear bear = new Bear("Teddy");
            System.Console.WriteLine(bear.Name);
        }
    }
}