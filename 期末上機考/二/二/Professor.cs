using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二
{
    internal class Professor
    {
        private string number;
        private string name;
        private decimal salary;

        public Professor()
        {
        }

        public Professor(string number, string name, decimal salary)
        {
            Number = number;
            Name = name;
            Salary = salary;
        }

        public string Number
        {
            get
            {
                return number; 
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("編號不得為空白。", nameof(Number));
                number = value;
            }
        }

        public string Name
        {
            get 
            {
                return name; 
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("姓名不得為空白。", nameof(Name));
                name = value;
            }
        }

        /// <summary>
        /// 基本薪資。必須介於 80,000 ~ 100,000。
        /// </summary>
        public decimal Salary
        {
            get 
            {
                return salary; 
            }
            set
            {
                // 若低於下限，則設為下限；若高於上限，則設為上限；否則採用輸入值。
                if (value < 80000m)
                {
                    salary = 80000m;
                }
                else if (value > 100000m)
                {
                    salary = 100000m;
                }
                else
                {
                    salary = value;
                }
            }
        }

        /// <summary>
        /// 計算扣除 6% 稅金後之實領薪資。
        /// </summary>
        /// <returns>傳回實領薪資（decimal）</returns>
        public decimal CalculateNetSalary()
        {
            return Salary * 0.94m;
        }
    }
}
