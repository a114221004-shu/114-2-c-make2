using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Add(int a, int b)
        {
            return a + b;
        }

        private int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        private string Add(string a, string b)
        {
            return a + b;
        }

        private int Add(int[] a)
        { 
              int sum = 0;
              foreach (int x in a)
              
                sum += x;
                return sum;
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Add(5, 6).ToString(),"兩數相加");
            MessageBox.Show(Add(5, 6, 7).ToString(), "三數相加");
            MessageBox.Show(Add(" A ", " B "), "字串相加");
            int[] num = new int[] { 1, 3, 8, 4, 9 };
            MessageBox.Show(Add(num).ToString(), "陣列元素相加");
            Application.Exit();

        }
    }
}
