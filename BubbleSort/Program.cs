using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка пузырьком");
            Console.WriteLine("Введите массив для сортировки, разделяя элементы пробелом: ");
            string[] strelems = Console.ReadLine().Split(' ');
            int[] arrToSort = new int[strelems.Length];
            for (int i = 0; i < strelems.Length; i++)
            {
                arrToSort[i] = int.Parse(strelems[i]);
            }
            int n = 0;
            arrToSort = SortAnalyser.BubbleSort(arrToSort, out n);
            SortAnalyser.OutputArrToConsole(arrToSort);
            Console.WriteLine("Количество операций: {0}", n);
        }
    }
}
