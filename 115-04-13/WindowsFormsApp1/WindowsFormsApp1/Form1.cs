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

        private void Swap(ref int n1, ref int n2)
        { 
         int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 10, b = 15;
            MessageBox.Show("呼叫Swap方法前: a = " + a.ToString() + " b = " + b.ToString());
            Swap(ref a, ref b);
            MessageBox.Show("呼叫Swap方法後: a = " + a.ToString() + " b = " + b.ToString());
        }
    }
}
