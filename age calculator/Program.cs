using System;

namespace age_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("AGE CALCULATOR 3000");
            Console.WriteLine("enter age:");

            if (int.TryParse(Console.ReadLine(),out int age))
            {
                string result = string.Format("{0:n0}", (age * (60 * 60 * 24 * 365.25f)));
                Console.WriteLine("here is your age in seconds " + result);

                Console.ReadKey();
                Console.Clear();
                goto start;
            }

        }
    }
}
