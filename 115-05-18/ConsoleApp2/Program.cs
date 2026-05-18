using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        // 主程式類別
        static void Main(string[] args)
        {
            // 建立第一個 Person 實例，要求使用者輸入名字並顯示問候
            Person p1 = new Person();
            WriteLine("請輸入你的名字:");
            p1.Name = ReadLine();
            p1.Display();

            // 建立第二個 Person 實例，重複輸入與顯示流程
            Person p2 = new Person();
            WriteLine("請輸入你的名字:");
            p2.Name = ReadLine();
            p2.Display();

            // 等待使用者按任意鍵後結束程式
            ReadKey();

        }
    }
}
