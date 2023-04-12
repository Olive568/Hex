using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> bits = new Stack<int>();
            string[] letters = new string[] { "A", "B", "C", "D", "E", "F", };
            int index = 0;
            string reman = "";
            string div = "";

            int numToConvert = 0;
            Random rnd = new Random();

            numToConvert = rnd.Next(255);

            Console.Write(numToConvert + " in binary is ");


            int remainder = numToConvert % 16;
            numToConvert = numToConvert / 16;

            if (numToConvert > 9)
            {
                index = numToConvert - 10;
                div = letters[index];
                Console.Write(div);

            }
            else if (numToConvert == 0)
            {

            }
            else
            {
                bits.Push(numToConvert);
                Console.Write(bits.Pop());
            }


            if (remainder > 9)
            {
                index = remainder - 10;
                reman = letters[index];
                Console.Write(reman);
            }
            else
            {
                bits.Push(remainder);
                Console.Write(bits.Pop());
            }

            Console.ReadKey();
        }
    }
}


