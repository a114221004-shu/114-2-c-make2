using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 三個出拳名稱陣列，索引 0=剪刀、1=石頭、2=布
        string[] pName = new string[] { "剪刀", "石頭", "布" };

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立一個 Button 陣列並對應設計工具產生的 Btn1~Btn3 控制項
            Button[] arrBtn = new Button[3];
            arrBtn[0] = Btn1; arrBtn[1] = Btn2; arrBtn[2] = Btn3;

            for (int i = 0; i < 3; i++)
            {
                // 設定按鈕顯示的文字為剪刀/石頭/布
                arrBtn[i].Text = pName[i]; //設定文字內容
                // 以按鈕文字為檔名載入對應的 gif 圖檔（例如 "剪刀.gif"）
                arrBtn[i].Image = new Bitmap(arrBtn[i].Text + ".gif");//顯示對應圖檔
                // 三個按鈕共用同一個 Click 事件處理方法 MyClick
                arrBtn[i].Click += MyClick;//共用 MyClick 事件
            }
            // 設定畫面下方訊息提示文字
            LblMsg.Text = "請按鈕出拳！";
        }

        // Btn1、Btn2、Btn3 的 Click 事件共用事件
        private void MyClick(object sender, EventArgs e)
        {
            // 建立隨機數產生器並取得 0~2 的整數，代表電腦的出拳
            Random rnd = new Random();
            int p = rnd.Next(0, 3);//產生 0~2 變數

            // 根據隨機結果載入對應圖檔顯示為電腦出拳圖（例如 pName[p] + ".gif"）
            PicPc.Image = Image.FromFile(pName[p] + ".gif");//顯示電腦出拳

            // sender 是觸發事件的按鈕，將其轉型為 Button 後可取得使用者的出拳（按鈕文字）
            Button btnHit = (Button)sender;//取得目前的按鈕

            // 呼叫 GetWinner 方法來判斷誰獲勝，並把結果文字顯示在 LblMsg
            LblMsg.Text = GetWinner(btnHit.Text, pName[p]);
        }

        // GetWinner 方法會根據使用者與電腦的出拳傳回勝敗訊息
        private string GetWinner(string user, string pc)
        {
            string msg = "";
            // 如果雙方相同則平手
            if (user == pc)
            {
                return "雙方平手！";
            }
            else if (user == "剪刀")
            {
                // user=剪刀：遇到石頭則電腦獲勝，否則（遇到布）使用者獲勝
                msg = (pc == "石頭" ? "電腦獲勝！" : "你獲勝！");
            }
            else if (user == "石頭")
            {
                // user=石頭：遇到布則電腦獲勝，否則（遇到剪刀）使用者獲勝
                msg = (pc == "布" ? "電腦獲勝！" : "你獲勝！");
            }
            else
            {
                // user=布：遇到剪刀則電腦獲勝，否則（遇到石頭）使用者獲勝
                msg = (pc == "剪刀" ? "電腦獲勝！" : "你獲勝！");
            }
            return msg;
        }
    }
}
