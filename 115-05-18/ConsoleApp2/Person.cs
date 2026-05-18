using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // 表示一個人的類別，包含姓名欄位與相關操作
    internal class Person
    {
        // 儲存姓名的私有欄位
        private string name;

        // 公開的姓名屬性，提供取得與設定功能
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        // 將問候訊息輸出到主控台
        public void Display()=>Console.WriteLine($"Hollo!{Name}.");
        
    }
}
