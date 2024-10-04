namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int randomNumber = rnd.Next(1, 2);
            int guess;
            int maxGuesses = 5;
            string finalMessage = $"Tyvärr du lyckades inte gissa rätt tal på {maxGuesses} försök.";
            for (int i = 0; i < maxGuesses; i++) 
            {
                Console.Write("Skriv in din gissning: ");
                string input = Console.ReadLine()?? string.Empty;
                while (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Skriv in ett heltal!");
                }
                if(CheckGuess(guess, randomNumber))
                {
                finalMessage = "Wooho! Du klarade det!";
                break;
                }
                string feedback = (guess < randomNumber) ? "Tyvärr du gissade för lågt!" : "Tyvärr du gissade för högt!";
                Console.WriteLine(feedback);
            };
            Console.WriteLine(finalMessage);
        }
        static bool CheckGuess(int guess, int num)
        {
            if (guess == num){ return true; }
            return false;
        }
    }
}
