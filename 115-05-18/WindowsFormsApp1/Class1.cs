using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Empolyee
    {
        public string Name { get; set; }
        public int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value <= 20000) value = 20000;
                if (value >= 40000) value = 40000;
                _salary = value;
            }
        }

    }

    public class Manager : Empolyee
    {
        private int _bonus;
        public int Bonus
        {
            get
            {
                return _bonus;
            }
            set
            {
                if (value <= 10000) value = 10000;
                if (value >= 50000) value = 50000;
                _bonus = value;
            }
        }

        public string GetTotal()
        {
            return $"經理姓名：{Name}\n 實領薪水：{Salary}\n 實領獎金：{Bonus}\n 合計薪資：{ Bonus + Salary}";
        }
    }
}

