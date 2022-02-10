namespace Semester2_Exercise2.Questions
{
    public class Question6
    {
        public void LawnMowingService()
        {
            int rate_1 = 25;
            int rate_2 = 35;
            int rate_3 = 50;
            Console.WriteLine("Green Places Mowing Services, please input the length and width of your lawn");
            Console.Write("\nLenght of lawn: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nWidth of lawn: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int lawnArea = length * width;


            if (lawnArea <= 400)
            {
                Console.WriteLine($"the weekly mowing fee per a week is ${rate_1}");
                Console.WriteLine($"The fee for your {lawnArea} square foot lawn is ${rate_1 * lawnArea} for 20 weeks of service");

            }
            else if (lawnArea > 400 || lawnArea < 600)
            {
                Console.WriteLine($"The weekly mowing fee per a week is ${rate_2}");
                Console.WriteLine($"The fee for your {lawnArea} square foot lawn is ${rate_2 * lawnArea} for 20 weeks of service");
            }

            else if (lawnArea >= 600)
            {
                Console.WriteLine($"The weekly mowing fee per a week is ${rate_3}");
                Console.WriteLine($"The fee for your {lawnArea} square foot lawn is  ${rate_3 * lawnArea} for 20 weeks of service");

                Console.WriteLine("----------------------------");
            }
        }
    }
}
