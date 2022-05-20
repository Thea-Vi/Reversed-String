using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();


            Console.Write("Results: ");

            DisplayResult(
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city)
                );
            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
     
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
            reversedFirstName,
            reversedLastName,
            reversedCity));
        }
    }

}
