using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // internal：此類別僅在同一組件內可見，外部組件無法直接存取
    internal class Student
    {
        // 私有欄位，用來儲存學生的姓名
        // private 表示此欄位只能在 Student 類別內部存取，外部無法直接讀取或修改
        private string name;

        // InputName：設定學生姓名的方法
        // 參數 title 為欲儲存的姓名字串，方法以 expression-bodied member 的形式將參數指派給私有欄位 name
        public void InputName(string title) => name = title;

        // ShowName：回傳學生姓名的方法
        // 若尚未呼叫 InputName 設定姓名，回傳值可能為 null，呼叫端應視情況處理或先行檢查
        public string ShowName() => name;
    }
}
