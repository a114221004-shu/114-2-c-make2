using System; 
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using static System.Console; // 使用 static 匯入，讓 WriteLine、ReadKey 等可直接呼叫

namespace ConsoleApp1
{
    // internal：類別只在同一組件內可見
    internal class Program
    {
        // Main 為程式進入點（靜態方法）
        // 參數 args 為字串陣列，可接收命令列引數
        static void Main(string[] args)
        {

            // 建立兩個 Student 類別的實例（物件）
            // s1 與 s2 為參考型別變數，各自指向新建立的 Student 物件
            Student s1 = new Student();
            Student s2 = new Student();

            // 呼叫 Student 的 InputName 方法，將姓名字串設定到物件內部
            // 這裡使用範例英文姓名作為參數傳入
            s1.InputName("Toams Dalton");
            s2.InputName("Emily VanCamp");

            // 使用字串內插（interpolation）輸出學生姓名
            // 假設 Student.ShowName() 會回傳儲存在物件內的姓名字串
            WriteLine($"第一個學生{s1.ShowName()}");
            WriteLine($"第二個學生{s2.ShowName()}");

            // ReadKey()：等待使用者按下任意鍵，避免主控台視窗立即關閉
            ReadKey();

        }
    }
}
