using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblMsg_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empolyee Jennifer = new Empolyee(); // Employee 父類別
            Jennifer.Name = "珍妮佛";
            Jennifer.Salary = 30000;
            LblMsg.Text = $"員工姓名：{Jennifer.Name} \n 實領薪水：{Jennifer.Salary}";
            LblMsg.Text += "\n======================\n";
            Manager Alice = new Manager(); // Manager 子類別
            Alice.Name = "艾莉絲";
            Alice.Salary = 40000;
            Alice.Bonus = 20000; // Manager 子類別新增的 Bonus 屬性
            LblMsg.Text += Alice.GetTotal(); //Manager 子類別新增的 GetTotal()方法
        }
    }
}
