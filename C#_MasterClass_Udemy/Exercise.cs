internal class Exercise
{
    public void SimulateRocketLanding()
    {
        string rocket =
            @"   
   ^
  /^\
  |-|
  | |
 /| |\ 
/_|_|_\
   V
            ";

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(rocket);

            if (i <= 0)
            {
                Console.WriteLine("\nThe rocket has landed. Woohoo! Another successful landing!");
                break;
            }
       
            Thread.Sleep(500);
            rocket = "\n" + rocket;
            Console.Clear();
        }
    }

    public void GuessTheNumber()
    {
        Random random = new Random();

        int answer = random.Next(1, 101);
        int tryCount = 0;
        int guessedNumber = 0;

        Console.WriteLine("Guess the number between 1 and 100 (inclusive): ");

        do
        {
            tryCount++;

            if (int.TryParse(Console.ReadLine(), out guessedNumber) && guessedNumber > 0 && guessedNumber <= 100)
            {
                if (guessedNumber == answer)
                {
                    Console.WriteLine($"You guessed the number in {tryCount} tries!");
                }
                else if (guessedNumber > answer)
                {
                    Console.WriteLine("Try a lower number: ");
                }
                else
                {
                    Console.WriteLine("Try a higher number: ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Try again: ");
            }

        } while (guessedNumber != answer);
    }
}
