using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 建立第一個 Student 物件
            Student s1 = new Student();

            // 提示使用者輸入名字，並將輸入值指定給 s1 的 Name 屬性
            WriteLine("請輸入你的名字:");
            s1.Name = ReadLine();

            // 提示使用者輸入年齡，並將輸入的字串解析為整數指定給 s1 的 Age 屬性
            WriteLine("請輸入你的年齡:");
            s1.Age = int.Parse(ReadLine());

            // 顯示 s1 的資訊
            s1.ShowMessage();

            // 建立第二個 Student 物件
            Student s2 = new Student();

            // 提示使用者輸入名字，並將輸入值指定給 s2 的 Name 屬性
            WriteLine("請輸入你的名字:");
            s2.Name = ReadLine();

            // 提示使用者輸入年齡，並將輸入的字串解析為整數指定給 s2 的 Age 屬性
            WriteLine("請輸入你的年齡:");
            s2.Age = int.Parse(ReadLine());

            // 顯示 s2 的資訊
            s2.ShowMessage();

            // 等待使用者按任意鍵後結束程式
            ReadKey();
        }
    }
}
