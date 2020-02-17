using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ez_írja_ki_zebraba_a_szoveget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a szöveget: ");
            string szöveg = Console.ReadLine();
            Console.WriteLine();
            szinezo(szöveg);
            Console.ReadKey();
        }

        private static void szinezo(string szöveg)
        {
            for (int i = 0; i < szöveg.Length; i++)
            {
                if (i%2==0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(szöveg[i]);
                }
                if (i%2==1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(szöveg[i]);
                }
            }
        }
    }
}
