namespace Semester2_Exercise2.Questions
{
    //    //Write a program that prompts the user for an hourly pay rate. If the value entered is less than $7.50
    //    or greater than $49.00, display an error message, otherwise display a message indicating that the
    //rate is okay
    public class Question5
    {
        public void HourlyPayRate()
        {
            //propmts the user the hourly rate expected
            Console.Write("Hello, please input your hourly rate between $7.50 and $49.00: ");
            double hourRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------");

            //A loop i created to check if the hour rate is within the range already set, if its not
            // prompt the user to do it again
            while (hourRate < 7.50 || hourRate > 49.00)
            {

                Console.WriteLine($"${hourRate} is invalid! Please, try an hourly rate between $7.50 and $49.00");

                Console.Write("\nPlease enter valid rate here:");

                //what does VS suggests _
                _ = double.TryParse(Console.ReadLine(), out hourRate);

            }
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Your valid hourly rate is ${hourRate}.");

            Console.WriteLine("----------------------------");

        }
    }
}
