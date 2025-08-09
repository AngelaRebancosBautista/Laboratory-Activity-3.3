using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            Console.WriteLine("Enter 5 usernames");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Username {i + 1}: ");
                string username = Console.ReadLine();
                usernames.Add(username);
            }
            Console.Write("Enter a character to search for:");
            string searchChar = Console.ReadLine();

            if (!string.IsNullOrEmpty(searchChar) && searchChar.Length == 1)
            {
                Console.WriteLine("\nUser names containing the character '{0}':", searchChar);
                bool found = false;

                foreach (string username in usernames)
                {
                    if (username.ToLower().Contains(searchChar.ToLower()))
                    {
                        Console.WriteLine(username);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No usernames contain the character '{0}'.", searchChar);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid single character.");
            }
        }
    }
}

                
            
        

    

