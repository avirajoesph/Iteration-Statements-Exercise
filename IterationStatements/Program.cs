using System.Diagnostics.CodeAnalysis;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void numbers()
        {
            for (int i = 1000; i > -1000; i--)
            {
                Console.WriteLine(i);

            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Number()
        {
            for (int i = 3; i <= 999; i += 3)
            {

                Console.WriteLine(i);

            }



        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool TrueOrFalse(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;


            }
            else
            {
                return false;


            }


        }


        //Write a method to check whether a given number is even or odd
        public static string EvenOrOdd(int number)
        {
            string result = (number % 2 == 0) ? "even" : "odd";
            return result;


        }

        //Write a method to check whether a given number is positive or negative
        public static string PosOrNeg(int number)
        {
            string result = (number > 0) ? "posative" : "negative";
            return result;


        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool Age(int age)
        {
            if (age >= 18)
            {
                return true;


            } else
            {
                return false;


            }




        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool InRange(int num)
        { if (num <= 10 && num >= -10)
            {
                return true;


            }
            else
            {
                return false


            }




        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multiples(int num1)
        {
            


            for (int i = 1; i <= 12; i++)
            {

                Console.WriteLine(num1*i);


            }
        }
        







        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd(9));
            Console.WriteLine(PosOrNeg(5));
            numbers();
            Console.WriteLine(Age(18));

        }
    }
}
