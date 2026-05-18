using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        // Student 類別：代表一個學生的資料結構，包含姓名與年齡屬性以及顯示資訊的方法
        public string Name { get; set; }
        // Age 屬性：以整數表示學生的年齡
        public int Age { get; set; }

        public void ShowMessage()
        {
            // 將學生的姓名與年齡輸出到主控台
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
}
