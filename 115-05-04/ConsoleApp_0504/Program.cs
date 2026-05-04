using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "賈斯柏";
            s1.Score_Chi = 90;
            s1.Score_Math = 70;
            s1.Score_Eng = 80;
            s1.ShowSum();
            s1.ShowPass();

            Student s2 = new Student();
            s2.Name = "愛麗絲";
            s2.Score_Chi = 60;
            s2.Score_Math = 70;
            s2.Score_Eng = 60;
            s2.ShowSum();
            s2.ShowPass();


            StudentPro p1 = new StudentPro();
            p1.Name = "賈斯柏";
            p1.Score_PL = 50;
            p1.Score_AI = 40;
            p1.Score_Cloud = 62;
            p1.ShowSum();
            p1.ShowPass();

            StudentPro p2 = new StudentPro();
            p2.Name = "愛麗絲";
            p2.Score_PL = 80;
            p2.Score_AI = 90;
            p2.Score_Cloud = 82;
            p2.ShowSum();
            p2.ShowPass();

        }
    }
}
