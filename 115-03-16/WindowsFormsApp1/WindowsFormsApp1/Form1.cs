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

        private void PassValue(int x,int y)
        {
            LblMsg.Text += $"2.方法中:參數計算前: x = {x}, y = {y}\n\n";
            x += 3;
            y += 2;
            LblMsg.Text += $"3.方法中:參數計算後: x = {x}, y = {y}\n\n";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 10, b = 15;
            LblMsg.Text += $"1.主程式:呼叫方法前: a = {a}, b = {b}\n\n";
            PassValue(a, b);
            LblMsg.Text += $"4.主程式:呼叫方法後: a = {a}, b = {b}\n\n";
        }
    }
}
