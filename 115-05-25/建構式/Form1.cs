using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 建構式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s1 = new Student();  // 無引數的建構式
            s1.Name = "布魯斯";
            s1.Score = 88;
            LblMsg.Text = s1.GetMsg() + "\n\n";

            Student s2 = new Student("珍妮佛");  //傳一個引數的建構式
            s2.Score = 77;
            LblMsg.Text += s2.GetMsg() + "\n\n";

            Student s3 = new Student("艾莉絲", 99);  //傳兩個引數的建構式
            LblMsg.Text += s3.GetMsg();

        }
    }
}
