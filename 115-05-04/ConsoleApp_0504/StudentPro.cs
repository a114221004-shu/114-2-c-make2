using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0504
{
    internal class StudentPro
    {
        public string Name;
        public int Score_PL;
        public int Score_AI;
        public int Score_Cloud;

        public void ShowSum()
        {
            int _total;
            _total = Score_PL + Score_AI + Score_Cloud;
            Console.WriteLine(Name + "同學的專業總分是" + Convert.ToString(_total));
        }

        public void ShowPass()
        {
            int _total;
            string _pass = "";
            _total = Score_PL + Score_AI + Score_Cloud;
            if (_total >= 180)
            {
                _pass = "PASS";
            }
            else
            {
                _pass = "NO PASS";
            }

            Console.WriteLine(Name + "同學專業科目是否通過?" + _pass);
        }
    }
}
