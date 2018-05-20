using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro.Rabit.TestQuestion2
{
    class Program
    {
        public static readonly int[] arr = { 10, 12, 15, 21 };
        static void Main(string[] args)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The value is : " + arr[i]);              
            }
            Console.ReadLine();
        }
    }
}






