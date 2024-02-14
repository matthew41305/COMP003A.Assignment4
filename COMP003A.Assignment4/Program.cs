/*
 * Author: Matthew Hudson
 * Course: COMP003A
 * Purpose: Assignment on looping statements
 */
namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("for loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("***************************************************");
            Console.Write("Enter a positive whole number: ");
            int limit = int.Parse(Console.ReadLine());
            string output = "#";
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine(new string('#', i));
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("***************************************************");
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("***************************************************");
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Pheobe" };
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("***************************************************");
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("***************************************************");

            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("***************************************************");
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("***************************************************");

            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
        }
    }
}
