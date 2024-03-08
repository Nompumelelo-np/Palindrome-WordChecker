using System;
namespace PalindromeWordChecker
{
    public class PalindromeWordExample
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine($"{name} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not a Palindrome");
            }
            Console.ReadKey();
        }
    }
}
