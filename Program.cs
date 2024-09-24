namespace TestDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int sum = 0;
            Console.WriteLine("Välkommen till spelet 21");

            Console.WriteLine("Vill du slå tärningen eller stanna?");
            
            string answer = Console.ReadLine();

            while(answer != "stanna")
            {
                int dice = rand.Next(1, 7);
                sum += dice;

                Console.WriteLine("Du slog " + dice + ", du har nu " + sum + " poäng");

                answer = Console.ReadLine();
            }

            int dealerSum = 0;

            while(dealerSum < 17)
            {
                int dice = rand.Next(1, 7);
                dealerSum += dice;
                Console.WriteLine("Dealern slog " + dice + ", dealern har nu " + dealerSum + " poäng");
            }
        }
    }
}