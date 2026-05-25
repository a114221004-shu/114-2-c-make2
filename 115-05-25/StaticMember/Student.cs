using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    internal class Student
    {
        public string Name;                 // Name姓名欄位宣告為public
        private static int _total = 0;
        private int _score;                 // _score成績欄位宣告為private      
        public int Score    // 建立Score屬性，此屬性限制在0~100
        {
            get
            {
                return _score;
            }
            set
            {
                if (value >= 100) value = 100;   // Score屬性最大值為100
                if (value <= 0) value = 0;       // Score屬性最小值為0
                _score = value;
            }
        }
        public Student(string _vName, int _vScore)  // 可設定姓名和分數的建構式3
        {
            Name = _vName;
            Score = _vScore;
            _total++;       //_total++讓物件總數加1
        }
        public string GetMsg()             // GetMsg傳回姓名與成績的方法
        {
            return $"{Name}同學的分數是 {Score}";
        }
        public static string GetTotalStudent()  // 傳回共產生多少學生物件
        {
            return $"本班共有 {_total} 位同學";
        }
    }

}

