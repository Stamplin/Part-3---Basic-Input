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

            double km1, km2, km3, average;

            Console.WriteLine("I will average three distances for you. (it can be decimals too)");

            Console.WriteLine("Enter a number");
            km1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            km2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a third number");
            km3 = Convert.ToDouble(Console.ReadLine());

            //round the average to 2 decimals
            average = Math.Round((km1 + km2 + km3) / 3, 2);
            Console.WriteLine("The average is " + average);

            //clear console
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            //part 4  - Hypotenuse calculator
            

            double side1, side2, hypotenuse;

            Console.WriteLine("I will calculate the hypotenuse for you. (it can be decimals too)");

            Console.WriteLine("Enter a side");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second side");
            side2 = Convert.ToDouble(Console.ReadLine());
            
            //use math class for squareroot
            hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));
            Console.WriteLine("The hypotenuse is " + hypotenuse);

            //exit program
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();



        }
    }
}
