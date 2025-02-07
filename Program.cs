using System.Text.Json.Serialization;

namespace Part_3___Basic_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            //Ask for name, agek, and current year (year get from system) and store them in variables
            string name;
            int age;
            int year = DateTime.Now.Year;
            int birthYear;

            Console.WriteLine("Hello, what is your name!");
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", how old are you?");
            age = Convert.ToInt32(Console.ReadLine());


           //take system year and subtract age to get birth year
            birthYear = year - age;
            Console.WriteLine("You were born in " + birthYear + "!!");

            //press enter to continue
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();


            //part 2 - basic calculator???
            int num1, num2, num3, total;

            Console.WriteLine("I will add three 'intergers' for you. (for free dw bro, I gotchu)");

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2 + num3;
            Console.WriteLine("The total is " + total);

            //clear console
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            //part 3 - distance calculator (take 3 distance in km and as double and print average)




        }
    }
}
