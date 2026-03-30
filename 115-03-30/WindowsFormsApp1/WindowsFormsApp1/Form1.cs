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

        // CountSum 方法用來傳回 n 累加到 m 的結果
        private void CountSum(int n, int m)
        {
            int tot = 0;
            for (int i = n; i <= m; i++)
            {
                tot += i;
            }
            MessageBox.Show(n.ToString() + "加到" + m.ToString() + "的總和為 ：" + tot.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CountSum(1, 10); //呼叫 CountSum 方法進行 1 累加到 10
            CountSum(5, 12); //呼叫 CountSum 方法進行 5 累加到 12
            Application.Exit();
        }
    }
}
