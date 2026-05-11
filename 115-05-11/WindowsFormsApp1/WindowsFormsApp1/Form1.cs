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
            Student s1 = new Student();
            s1.Name = "珍妮佛";
            s1.Score = 5000;
            s1.ShowMsg();

            Student s2 = new Student();
            s2.Name = "布魯斯";
            s2.Score = -100;
            s2.ShowMsg();
        }
    }
}
