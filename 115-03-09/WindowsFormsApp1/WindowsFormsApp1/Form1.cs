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

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] stu = new string[] { "A001", "A002", "A003", "A004" }; //存放學生學號
            string[] sub = new string[] { "計概", "程設", "專題" }; //存放科目名稱
            int[,] score = new int[,] { { 82, 84, 90 }, { 85, 92, 87 }, { 80, 73, 82 }, { 62, 68, 84 } };
            int[] sum = new int[4] { 0, 0, 0, 0 };
            for (int y = 0; y <= score.GetUpperBound(0); y++)
            {
                for (int x = 0; x <= score.GetUpperBound(1); x++)
                    sum[y] += score[y, x];
            }
            string msg = "學號\t";
            foreach (string s in sub)
                msg += s + "\t";
            msg += "總分\n";
            for (int y = 0; y <= stu.GetUpperBound(0); y++)
            {
                msg += stu[y] + "\t";
                for (int x = 0; x <= sub.GetUpperBound(0); x++)
                    msg += $"{score[y, x]}\t";
                msg += $"{sum[y]}\n";
            }
            MessageBox.Show(msg, "成績表");
            Application.Exit();
        }
    }
}
