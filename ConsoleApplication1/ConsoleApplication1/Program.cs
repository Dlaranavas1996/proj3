using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola github");
            for (int i = 0; i < 5; i++)
            {
                do
                {

                    Console.Write("Texto  en bucle: {0}", i);
                } while ((Console.ReadLine() != "q"));
            }
           

            
        }
    }
}
