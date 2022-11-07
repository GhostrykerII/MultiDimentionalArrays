using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimentionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi-Dimentional Arrays:");
            Console.WriteLine();

            //single value
            int score = 1000;

            // array
            int[] ammo = new int[4]; //4 values
            ammo[0] = 1;
            ammo[1] = 2;   
            ammo[2] = 3;
            ammo[3] = 4;

            //2d array 
            int[,] map = new int[20, 10]; // 200 values
            map[0, 0] = 0;
            map[1, 0] = 0;
            map[2, 0] = 0;
            //...
            map[18, 2] = 0;

        }
    }
}
