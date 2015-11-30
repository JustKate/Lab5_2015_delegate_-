using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array;
            array = new int[4][];
            array[0] = new int[4] { 5, 33, 2, 1 };
            array[1] = new int[7] { 8, 5, 4, 9, 22, 5, 3 };
            array[2] = new int[5] { 88, 3, 5, 4, 7 };
            array[3] = new int[6] { 9, 4, 9, 99, 7, 6 };
            string k;
            
            Boolean a = true;
            Console.WriteLine("This is start matrix");
            Matrix.Show(array);
            while (a)
            {
                Console.WriteLine("Choose your action ");
                Console.WriteLine(" 1-sort by lines\n 2-sort by Max element\n 3-sort by Min element\n 4-end");
                k = Console.ReadLine();
                switch (k)
                {
                    case "1":
                        Sort.SortByString(array, Matrix.SumStrin);
                        Matrix.Show(array);
                        break;
                    case "2":
                        Sort.SortByString(array, Matrix.SearchMax);
                        Matrix.Show(array);
                        break;
                    case "3":
                        Sort.SortByString(array, Matrix.SearchMin);
                        Matrix.Show(array);
                        break;

                    case "4":
                        a = false;
                        break;

                }
            }
        }
    }
}
