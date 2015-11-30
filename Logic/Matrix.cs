using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public delegate int Collect(int[] a);
    public class Matrix
    {
        public static void Show(int[][] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write("{0} ", a[i][j]);
                Console.WriteLine();
            }

        }

        public static int SumStrin(int[] a)
        {
            int sum = 0;
            for (int j = 0; j < a.Length; j++)
            {
                sum = sum + a[j];
            }
            return sum;
        }


        public static int SearchMax(int[] a)
        {
            int max = 0;
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] > max)
                { max = a[j]; }
            }
            return max;
        }

        public static int SearchMin(int[] a)
        {
            int min = a[0];
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] < min)
                { min = a[j]; }
            }
            return min;
        }


    }

    public static class Sort
    {
        public static void SortByString(int[][] array, Collect collectBy)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (collectBy(array[j]) < collectBy(array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        public static void SortByMax(int[][] array, Collect collectBy)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (collectBy(array[j]) < collectBy(array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        public static void SortByMin(int[][] array, Collect collectBy)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (collectBy(array[j]) > collectBy(array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        public static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }

}

