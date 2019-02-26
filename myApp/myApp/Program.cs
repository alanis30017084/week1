using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, nice to meet you.", name);
            Console.ReadLine();
            */

            // Interger variable
            int age;
            string name;


            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("We have recorded your age as {0} and name as {1}.", age, name);
            Console.ReadLine();

            
        }
    }
}
