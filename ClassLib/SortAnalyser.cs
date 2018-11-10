using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class SortAnalyser
    {
        public static int[] ShellSort(int[] arr, int d, out int n)
        {
            int[] result = new int[arr.Length];
            n = 0;
            int j;
            int step = arr.Length / d;
            while (d > 0)
            {
                for (int i = 0; i < (arr.Length - d); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + d]))
                    {
                        n++;
                        int tmp = arr[j];
                        arr[j] = arr[j + d];
                        arr[j + d] = tmp;
                        j -= d;
                    }
                    n++;
                }
                d = d / 2;
            }
            return arr;
        }

        public static int[] BubbleSort(int[] arr, out int n)
        {
            n = 0;
            int tmp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    n++;
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }

        public static void OutputArrToConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
