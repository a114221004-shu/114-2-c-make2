using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //宣告陣列並初始化元素
            int[] number = { 56, 78, 9, 354 };
            string[] name = { "Mary", "Judy", "Tomas", "Molly" };
            Write("排序前：\n");
            //讀取排序前的陣列元素
            foreach (int element1 in number)
                Write($"{element1,6} ");
            WriteLine();
            foreach (string element2 in name)
                Write($"{element2,6} ");
            Array.Sort(number, name);//遞增排序
            Write("\n 排序後：\n");
            //讀取排序後元素
            for (int item1 = 0; item1 < number.Length; item1++)
                Write("{0, 6} ", number[item1]);
            WriteLine();
            for (int item2 = 0; item2 < name.Length; item2++)
                Write("{0, 6} ", name[item2]);
            WriteLine();
            ReadKey();
        }
    }
}
