namespace Semester2_Exercise2.Questions
{
    public class Question7
    {
        public void RandomNumber()
        {
            //store the real anser and the guess from the user;
            Random randomNum = new Random();

            int realNumber = randomNum.Next(1, 11);

            int userGuess = 0;

            Console.WriteLine("Guess a number between 1 and 10.  Can you guess what it is?");

            while (userGuess != realNumber)
            {
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < realNumber)
                {
                    Console.WriteLine($"No, the number I am thinking of is higher than ${userGuess}. Can you guess what it is?");
                }
                else if (userGuess > realNumber)
                {
                    Console.WriteLine($"No, the number I am thinking of is lower than ${userGuess}. Can you guess what it is?");
                }

            }
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Well done! The answer was ${realNumber}");
            Console.ReadLine();

        }
    }
}
