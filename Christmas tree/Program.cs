using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =0;
            Console.WriteLine("Columns: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Lines: ");
            int y = int.Parse(Console.ReadLine());
            char[,] massive = new char[x, y];
            Console.WriteLine();

            Console.WriteLine("fill in the matrix");

            for(int j =0; j<y; j++)
            {
                for (int i=0; i<x; i++)
                {
                    Console.Write("massive[" + i + "," + j+ "]: ");
                    massive[i, j] = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int j = 0; j<y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(massive[i, j] + "\t");
                }
                Console.ReadLine();
            }


            for (int j =0; j <y; j++)
            {
                for(int i =0; i<x; i++)
                {
                    if (massive[i,j] == '*')
                    {
                        n++;
                    }
                    massive[i, j] = '-';
                }
                if (n == 1)
                {
                    int i = x / 2;
                    massive[i, j] = '*';
                }
                else
                {
                    double Q = Convert.ToDouble(x);
                    double W = Convert.ToDouble(n);
                    Q = Math.Round(Q / W);
                    int k = Convert.ToInt32(Q);
                   
                    //k = k + 1;
                    for(int i=k; n>0; i++)
                    {
                        massive[i, j] = '*';
                        n--;
                    }
                    }

                n = 0;
            }

            Console.WriteLine("Calculation result: ");
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(massive[i, j] + "\t");
                }
                Console.ReadLine();
            }

        }
    }
}
