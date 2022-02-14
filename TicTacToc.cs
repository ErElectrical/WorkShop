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

        public static void AskPlayer()
        {
            char PlayerChoice = ' ';
            char ComputerChoice = ' ';
            Console.WriteLine("Choose between X and O");
            PlayerChoice = Convert.ToChar(Console.ReadLine());
            if(PlayerChoice == 'X' || PlayerChoice == 'x')
            {
                ComputerChoice = 'O';
            }
            else if(PlayerChoice == 'O' || PlayerChoice == 'o')
            {
                ComputerChoice = 'X';
            }
            else
            {
                Console.WriteLine("Champ choose wisely");
            }
            Console.WriteLine("PlayerChoice : {0} ComputerChoice : {1} ", PlayerChoice, ComputerChoice);
        }
    }
     
}
