using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student Bruce = new Student("布魯斯", 100);
            Student Jennifer = new Student("珍妮佛", 56);
            Student Alice = new Student("艾莉絲", 99);
            label1.Text = Bruce.GetMsg() + "\n";
            label1.Text += Jennifer.GetMsg() + "\n";
            label1.Text += Alice.GetMsg() + "\n";
            label1.Text += "=====================\n";
            //呼叫Student類別的GetTotalStudent靜態方法取得目前有多少位學生
            label1.Text += Student.GetTotalStudent();
        }
    }
}
