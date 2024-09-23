namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(21);
            int guess = -1;
            Console.WriteLine(randomNumber);
            int maxGuesses = 5;
            string finalMessage = $"Tyvärr du lyckades inte gissa rätt tal på {maxGuesses} försök";
            for (int i = 0; i < maxGuesses; i++) 
            {
                Console.Write("Skriv in din gissning: ");
                string input = Console.ReadLine();
                while (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Skriv in ett heltal!");
                }
                if(guess == randomNumber)
                {
                finalMessage = "Wooho! Du klarade det!";
                break;
                }
                string feedback = (guess < randomNumber) ? "Tyvärr du gissade för lågt!" : "Tyvärr du gissade för högt!";
                Console.WriteLine(feedback);
            };
            Console.WriteLine(finalMessage);
        }
    }
}
