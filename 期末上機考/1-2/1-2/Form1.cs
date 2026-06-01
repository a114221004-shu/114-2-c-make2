using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算單一學生最終成績的 method，接受三個參數 (學測、書審、口試)
        // 並以回傳值回傳最終成績與是否因超過滿分而被 cap。
        // 學測滿分75，占比10%；書審滿分100，占比45%；口試滿分100，占比45%
        // 最後滿分為 97.5 分
        private (double finalScore, bool capped) ComputeFinalScore(double exam75, double review100, double interview100)
        {
            // 將各項依其比例換算
            double examPortion = (exam75 / 75.0) * 7.5; // 75 分換算到 7.5
            double reviewPortion = (review100 / 100.0) * 45.0;
            double interviewPortion = (interview100 / 100.0) * 45.0;
            double finalScore = examPortion + reviewPortion + interviewPortion;
            bool capped = false;
            // 若超過滿分 97.5，則 cap 並標記
            if (finalScore > 97.5)
            {
                finalScore = 97.5;
                capped = true;
            }
            return (finalScore, capped);
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            var rnd = new Random(0);

            // 產生包含詳細三項分數的資料，並示範每 10 號學生輸入超出滿分以觀察最終成績被限制為 97.5
            var detailedList = new List<Tuple<int, double, double, double, double>>(); // id, final, exam, review, interview
            rnd = new Random(0);
            for (int i = 1; i <= 100; i++)
            {
                double exam, review, interview;
                if (i % 10 == 0)
                {
                    exam = 80.0;
                    review = 110.0;
                    interview = 105.0;
                }
                else
                {
                    exam = rnd.Next(0, 76);
                    review = rnd.Next(0, 101);
                    interview = rnd.Next(0, 101);
                }
                var result = ComputeFinalScore(exam, review, interview);
                double finalScore = result.finalScore;
                bool capped = result.capped;
                detailedList.Add(Tuple.Create(i, finalScore, exam, review, interview));
            }

            var sorted = detailedList.OrderByDescending(t => t.Item2).ToList();

            listBoxResults.Items.Clear();
            listBoxResults.Items.Add("排名\t編號\t學測\t書審\t口試\t最終成績");
            int rank = 1;
            foreach (var item in sorted)
            {
                listBoxResults.Items.Add(string.Format("{0}\t{1}\t{2:F1}\t{3:F1}\t{4:F1}\t{5:F2}", rank, item.Item1, item.Item3, item.Item4, item.Item5, item.Item2));
                rank++;
            }
        }
    }
}
