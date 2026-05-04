using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0504
{
    internal class Student
    {
        public string Name;
        public int Score_Chi;
        public int Score_Math;
        public int Score_Eng;

        public void ShowSum()
        {
            int _total;
            _total = Score_Chi + Score_Math + Score_Eng;
            Console.WriteLine(Name + "同學的總分是" + Convert.ToString(_total));
        }

        public void ShowPass()
        {
            int _total;
            string _pass = "";
            _total = Score_Chi + Score_Math + Score_Eng;
            if (_total >= 200)
            {
                _pass = "PASS";
            }
            else
            {
                _pass = "NO PASS";
            }

            Console.WriteLine(Name + "同學是否通過?" + _pass);
        }
    }
}
