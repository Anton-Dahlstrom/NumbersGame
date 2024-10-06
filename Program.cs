namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generates a number between 1 and 20.
            Random rnd = new();
            int randomNumber = rnd.Next(21); 
            
            int guess;
            int maxGuesses = 5;
            string finalMessage = $"Tyvärr du lyckades inte gissa rätt tal på {maxGuesses} försök.";
            // Loop that asks the user to guess which number was generated. 
            for (int i = 0; i < maxGuesses; i++) 
            {
                Console.Write("Skriv in din gissning: ");
                string input = Console.ReadLine()?? string.Empty;
                while (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Skriv in ett heltal!");
                }
                // If the guess is correct the loop breaks.
                if(CheckGuess(guess, randomNumber))
                {
                finalMessage = "Wooho! Du klarade det!";
                break;
                }
                // Otherwise the user gets a hint.
                string feedback = (guess < randomNumber) ? "Tyvärr du gissade för lågt!" : "Tyvärr du gissade för högt!";
                Console.WriteLine(feedback);
            }
            Console.WriteLine(finalMessage);
        }

        // Kontrollerar ifall gissningen stämmer.
        static bool CheckGuess(int guess, int num)
        {
            if (guess == num){ return true; }
            return false;
        }
    }
}
