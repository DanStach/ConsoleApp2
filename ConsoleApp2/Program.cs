using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // hello world app
            Console.WriteLine("Hello World!");
            
            // slow actions so humans can read it
            Thread.Sleep(2000);

            // lets call a function
            ask_a_question();

            // wait for user to press a key before closing the window.
            Console.ReadKey();


        }

        static void ask_a_question()
        {
            // ask a question
            Console.Write(Environment.NewLine);
            Console.WriteLine("Is the cake a lie?");

            string responce = Console.ReadLine();

            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
            foreach (char letter in responce)
            {
                Thread.Sleep(500);
                Console.WriteLine(letter);
            }

            int repeatcount = 5;
            for (int i = 0; i < repeatcount; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(responce.Last());
            }
        }
    }
}
