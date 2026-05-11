using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Student
    {
        private string name;
        private int _score;

        public string Name
        {
            get 
            {
                return name;     //當外部程式讀取Name的值時，會呼叫get方法，並回傳name變數的值
            }
            set 
            {
                name = value;    //value為set方法的參數，當外部程式設定Name的值時，會將該值傳入set方法中，並將name變數設定為該值
            }
        }

        public int Score    //沒有()為屬性
        {
            get   //get方法用來讀取Score的值
            { 
                return _score; 
            }
            set   //set方法用來設定Score的值
            {
                if(value  >= 100) value = 100;
                if(value <= 0) value = 0;
                _score = value; 
            }
        }

        public void ShowMsg()    //有()為方法
        {
            MessageBox.Show($"{Name} 同學的分數是 {Score}");
        }
    }
}
