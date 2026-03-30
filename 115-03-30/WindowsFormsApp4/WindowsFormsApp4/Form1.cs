using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        // 類別層級的 Random 實例，避免每次點擊都建立新實例造成重複亂數
        private readonly Random _rnd = new Random();

        // 快取載入的圖檔，避免每次都從磁碟重新讀取
        private readonly Dictionary<string, Image> _images = new Dictionary<string, Image>();

        public Form1()
        {
            InitializeComponent();
        }
        string[] pName = new string[] { "剪刀", "石頭", "布" };

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] arrBtn = new Button[3];
            arrBtn[0] = Btn1; arrBtn[1] = Btn2; arrBtn[2] = Btn3;
            for (int i = 0; i < 3; i++)
            {
                arrBtn[i].Text = pName[i]; //設定文字內容

                // 使用 Application.StartupPath 組合相對路徑，並將圖檔載入快取
                string filePath = Path.Combine(Application.StartupPath, arrBtn[i].Text + ".gif");
                try
                {
                    Image img = Image.FromFile(filePath);
                    // 保留一份原始影像在快取，按鈕顯示使用 Clone()，避免同一張 Image 多處共享導致 dispose 問題
                    if (!_images.ContainsKey(arrBtn[i].Text))
                    {
                        _images[arrBtn[i].Text] = img;
                    }
                    arrBtn[i].Image = (Image)_images[arrBtn[i].Text].Clone(); //顯示對應圖檔
                }
                catch (Exception)
                {
                    // 如果載入失敗，不阻斷程式，按鈕可只顯示文字
                    arrBtn[i].Image = null;
                }

                arrBtn[i].Click += MyClick;//共用MyClick事件
            }
            LblMsg.Text = "請按鈕出拳！";

        }
        private void MyClick(object sender, EventArgs e)
        {
            int p = _rnd.Next(0, 3);//產生0~2變數

            // 顯示電腦出拳：使用快取並 Clone() 一份給 PictureBox，並妥善處理舊的 Image 釋放
            try
            {
                Image newImg = null;
                if (_images.ContainsKey(pName[p]))
                {
                    newImg = (Image)_images[pName[p]].Clone();
                }
                else
                {
                    string filePath = Path.Combine(Application.StartupPath, pName[p] + ".gif");
                    newImg = Image.FromFile(filePath);
                }

                // 釋放舊的影像（如果有）
                if (PicPc.Image != null)
                {
                    var old = PicPc.Image;
                    PicPc.Image = null;
                    old.Dispose();
                }

                PicPc.Image = newImg;
            }
            catch (Exception)
            {
                // 若載入失敗就不顯示圖檔
                PicPc.Image = null;
            }

            Button btnHit = (Button)sender;//取得目前的按鈕
            //呼叫GetWinner方法來判斷誰獲勝
            LblMsg.Text = GetWinner(btnHit.Text, pName[p]);
        }
        private string GetWinner(string user, string pc)
        {
            string msg = "";
            if (user == pc)
            {
                return "雙方平手！";
            }
            else if (user == "剪刀")
            {
                msg = (pc == "石頭" ? "電腦獲勝！" : "你獲勝！");
            }
            else if (user == "石頭")
            {
                msg = (pc == "布" ? "電腦獲勝！" : "你獲勝！");
            }
            else
            {
                msg = (pc == "剪刀" ? "電腦獲勝！" : "你獲勝！");
            }
            return msg;
        }

        // 在表單關閉時釋放快取的圖檔資源
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // 釋放 PictureBox 的影像
            if (PicPc.Image != null)
            {
                PicPc.Image.Dispose();
                PicPc.Image = null;
            }

            // 釋放快取的圖檔
            foreach (var kv in _images)
            {
                kv.Value.Dispose();
            }
            _images.Clear();
        }
    }
}
