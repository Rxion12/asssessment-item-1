using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack deck = new Pack();
            Console.WriteLine("Which Type of Shuffle would you like?\n [1] Fisher-Yates\n [2] Riffle Shuffle\n [3] No shuffle");
            string Val = Console.ReadLine();
            int shuffletype = Convert.ToInt32(Val);
            Pack.ShuffleCardPack(shuffletype);


        }
    }
}
