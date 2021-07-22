using System;

namespace L2Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string errors = "";
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            name = name.Trim();
            if (name.Length < 1)
            {
                errors += "Some probles with your name; ";
            }

            Console.Write("Enter your age: ");
            bool age_check = Int32.TryParse(Console.ReadLine(), out int age);
            if (!age_check)
            {
                errors += "Wrong age input; ";
            }
            if (age < 0) 
            {
                errors += "Age cant be negative; ";
            }

            Console.Write("Enter your height: ");
            bool height_check = Int32.TryParse(Console.ReadLine(), out int height);
            if (!height_check)
            {
                errors += "Wrong height input; ";
            }
            if (height < 0)
            {
                errors += "Height cant be negative; ";
            }
            double height_m = (double)height / 100;

            if (errors.Length > 0)
            {
                Console.WriteLine(errors);
            }
            else
            {
                Console.WriteLine("Привет "+ name+", тебе " + age +" лет, рост (метров) "+ height_m);        
            }

            Console.ReadKey();
        }
    }
}
