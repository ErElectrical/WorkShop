using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTocProblem
{
    public class TicTacToc
    {
        public static void Position()
        {
            char[] posarr = new char[10];
            for (int i = 0; i < posarr.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                posarr[i] = ' ';
            }
            Console.WriteLine("Array initialise");
        }
    }
     
}
