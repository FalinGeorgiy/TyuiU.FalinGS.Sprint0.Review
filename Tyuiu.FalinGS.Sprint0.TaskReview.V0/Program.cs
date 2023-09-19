using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.FalinGS.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int First = 1;
            int Second = 2;
            int Third = 3;

            int result = DataService.Calc(First, Second, Third);

            Console.WriteLine($"({First} + {Second} + {Third}) * 5 = {result}");
            Console.ReadKey();

        }
    }
}
