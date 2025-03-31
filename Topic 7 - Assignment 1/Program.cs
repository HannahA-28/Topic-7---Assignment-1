namespace Topic_7___Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task one: Average of numbers in a loop.");
            int average = 0;
            int count = 0;
            int numbers = 4;
            int input;
            Console.WriteLine("Enter four numbers and I will find the average.");
            while (count < numbers)
            {
                Console.WriteLine("Please enter a number.");
                input = Convert.ToInt32(Console.ReadLine());
                average += input;
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("The total is: " + average + "." + " The average is " + average / 4 + ".");

            Console.WriteLine("Task two: Hi Low with Limited Tries.");
            bool done = false;
            Random generator = new Random();
            int guess = 0, tries = 0, secretNumber = generator.Next(1, 101);
            while (!done)
            {
                Console.WriteLine("In 7 tries, guess the random number from 1 to 100:");
                guess = Convert.ToInt32(Console.ReadLine());
                tries++;
                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed it!");
                    done = true;
                }
                else if (tries > 7)
                {
                    Console.WriteLine("Incorrect, you used all your tries!");
                    done = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Incorrect, too low!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Incorrect, too high!");
                }
            }
        }
    }
}
