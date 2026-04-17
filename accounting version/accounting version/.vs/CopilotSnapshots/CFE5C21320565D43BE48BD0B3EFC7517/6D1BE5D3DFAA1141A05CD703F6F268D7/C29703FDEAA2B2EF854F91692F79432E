using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace accounting_version
{
    // 主表單：記帳應用程式的主要視窗
    public partial class Form1 : Form
    {
        // 使用 decimal 存放金額以支援小數（自訂方法會使用此欄位）
        private List<decimal> moneyList = new List<decimal>();

        // 建構子：初始化元件並訂閱自訂事件
        public Form1()
        {
            InitializeComponent();

            // 訂閱自訂事件 `ExpenseAdded`，處理方法為 `OnExpenseAdded`
            this.ExpenseAdded += OnExpenseAdded;
        }

        // 按下 Ok 新增一筆支出（自訂方法）
        private void BtnOk_Click(object sender, EventArgs e)
        {
            // 驗證項目名稱是否輸入
            if (TxtItem.Text.Trim() == "")
            {
                MessageBox.Show("請輸入項目");
                return;
            }

            // 驗證金額顯示欄位是否有值
            if (label1.Text.Trim() == "")
            {
                MessageBox.Show("請輸入金額");
                return;
            }

            // 解析金額，可接受小數（先用 invariant culture 嘗試，再用系統預設文化做容錯）
            decimal money;
            if (!decimal.TryParse(label1.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out money))
            {
                if (!decimal.TryParse(label1.Text, out money))
                {
                    MessageBox.Show("金額格式不正確，請輸入數字（可包含小數）");
                    return;
                }
            }

            // 取得項目名稱並記錄金額
            string item = TxtItem.Text;
            GetMoneyList().Add(money);

            // 把記錄顯示到 listBox，顯示兩位小數
            listBox1.Items.Add(item + " - $" + money.ToString("F2"));

            // 清空輸入顯示
            label1.Text = "";
            TxtItem.Text = "";

            // 觸發自訂事件，通知其他處理（例如更新總額）
            ExpenseAdded?.Invoke(this, EventArgs.Empty);
        }

        // 自訂方法：回傳記錄清單（提供給其他方法使用）
        private List<decimal> GetMoneyList()
        {
            return moneyList;
        }

        // 按下「計算總金額」的處理方法（目前可能未綁在 UI 上，但保留）
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額：" + GetTotal().ToString("F2"));
        }

        // 按下「清除」按鈕的處理方法：清空資料與顯示
        private void BtnClear_Click(object sender, EventArgs e)
        {
            moneyList.Clear();
            listBox1.Items.Clear();

            // 清除後也觸發自訂事件以更新 UI
            ExpenseAdded?.Invoke(this, EventArgs.Empty);
        }

        // 自訂方法：計算並回傳目前總金額（使用 decimal）
        private decimal GetTotal()
        {
            decimal sum = 0m;
            foreach (decimal m in moneyList)
            {
                sum += m;
            }
            return sum;
        }

        // 處理數字按鈕與功能鍵（包含小數點）——自訂方法
        private void NumericButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            var key = btn.Text;

            // 全部清除
            if (key == "AC")
            {
                label1.Text = "";
                return;
            }

            // 回退鍵：刪除最後一個字元
            if (key == "⬅" || key == "←")
            {
                if (!string.IsNullOrEmpty(label1.Text))
                {
                    label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
                }
                return;
            }

            // 小數點處理：若為空則先補 0，且避免重複小數點
            if (key == ".")
            {
                if (string.IsNullOrEmpty(label1.Text))
                {
                    label1.Text = "0.";
                }
                else if (!label1.Text.Contains("."))
                {
                    label1.Text += ".";
                }
                return;
            }

            // 處理 "00" 鍵：若為空，設為 "0"，避免變成空前置多個 0
            if (key == "00")
            {
                if (string.IsNullOrEmpty(label1.Text))
                {
                    label1.Text = "0";
                }
                else if (label1.Text == "0")
                {
                    // 已是 0 就不動
                    return;
                }
                else
                {
                    label1.Text += "00";
                }
                return;
            }

            // 處理數字鍵（0~9）：如果目前顯示為單一 "0"，按下數字要取代它
            if (!string.IsNullOrEmpty(key) && char.IsDigit(key, 0))
            {
                if (label1.Text == "0")
                {
                    label1.Text = key; // 取代 leading zero
                }
                else
                {
                    label1.Text += key;
                }
            }
        }

        // 新增離開按鈕的處理方法（自訂方法）：離開前可呼叫自訂事件或做清理
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // 在關閉前觸發事件（示範如何在離開時觸發自訂事件）
            ExpenseAdded?.Invoke(this, EventArgs.Empty);

            // 關閉視窗
            this.Close();
        }

        // 自訂事件：當新增支出或清除資料時會觸發此事件
        public event EventHandler ExpenseAdded;

        // 自訂事件的處理方法（自訂方法）：更新總額顯示
        private void OnExpenseAdded(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => LblTotal.Text = "目前總額：" + GetTotal().ToString("F2")));
            }
            else
            {
                LblTotal.Text = "目前總額：" + GetTotal().ToString("F2");
            }
        }

        // 表單載入時的處理（可放初始化程式）
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
