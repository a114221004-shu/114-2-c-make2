using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inherits.Empolyee;

namespace Inherits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empolyee Jennifer = new Empolyee();  // Employee父類別
            Jennifer.Name = "珍妮佛";
            Jennifer.Salary = 30000;
            LblMsg.Text = $"員工姓名：{Jennifer.Name} \n實領薪水：{Jennifer.Salary}";
            LblMsg.Text += "\n======================\n";
            Manager Alice = new Manager();      // Manager子類別
            Alice.Name = "艾莉絲";
            Alice.Salary = 40000;
            Alice.Bonus = 20000;               // Manager子類別新增的Bonus屬性
            LblMsg.Text += Alice.GetTotal();   //Manager子類別新增的GetTotal()方法

        }
    }
}
