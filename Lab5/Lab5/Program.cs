/*
 * K9195
 * CIS 199-02
 * Lab 5
 * Oct 20, 2019
 * A console app that utilizes For loops in order to create 4 different patterns
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;//Constant to set the max amount of rows each outer For loop will create
            WriteLine("Pattern A");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)
                Write("*");
                WriteLine();
            }

            WriteLine("Pattern B");
            for (int row = MAX_ROWS; row >= 1; row--)
            {
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }
            WriteLine("Pattern C");
            
            for (int row = MAX_ROWS; row >= 1; row--)
            {
                for (int space = 1; space <= MAX_ROWS-row; space++)
                    Write(" ");
                for (int star=1; star <=row; star++)
                    Write("*");
                WriteLine();
            }
        
            WriteLine("Pattern D");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int space = 1; space <= MAX_ROWS - row; space++)
                    Write(" ");
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }

        }
    }
}
