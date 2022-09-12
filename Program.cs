using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InicijalnoPonavljanje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] znakovi = new char [5];
            znakovi[] = Convert.ToString(znakovi);
         
            Console.WriteLine("Unesi niz znakova: ");
            for(int i = 0;i < 5; i++)
            { 
                Console.WriteLine("Znak " + i);
                znakovi[i] = Console.ReadLine();
            }
            Console.ReadKey();
           
            
        }
    }
}
