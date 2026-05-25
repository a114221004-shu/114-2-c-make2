using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherits
{
    internal class Empolyee
    {
        public string Name;    // Name姓名欄位
        private int _salary;     // _salary薪水欄位
        public int Salary      // Salary薪水介於20000~40000之間
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value <= 20000) value = 20000;  // 薪水最少20000
                if (value >= 40000) value = 40000;  // 薪水最多40000
                _salary = value;
            }
        }

        public class Manager : Empolyee
        {
            private int _bonus;      // 加入_bonus獎金欄位
            public int Bonus         // _bonus獎金介於10000~50000之間
            {
                get
                {
                    return _bonus;
                }
                set
                {
                    if (value <= 10000) value = 10000;  // 獎金最少10000
                    if (value >= 50000) value = 50000;  // 獎金最多50000
                    _bonus = value;
                }
            }
            public string GetTotal()     // 定義GetTotal()方法
            {
                return $"經理姓名：{Name}\n實領薪水：{Salary}\n實領獎金：{Bonus}\n合計薪資：{Bonus + Salary}";
            }
        }
    }

}



