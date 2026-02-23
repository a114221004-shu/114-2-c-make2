using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dn: 使用者輸入的十進位整數
            // p: 目標進位 (範圍 0~9)
            // nd: 用於記錄陣列索引（儲存各位數時使用）
            // i: 迴圈變數（用於輸出反向的各位數）
            // r: 儲存每次除法的餘數（即該位的數字）
            // q: 目前待處理的商（初始為 dn，之後不斷除以 p）
            int dn,p,nd,i,r,q;   
            // N 陣列用來暫存各位數（由低位到高位），此處預設大小為 10
            int[] N = new int[10];
            Console.Write("輸入十進位數字dn(>0):");
            dn = int.Parse(Console.ReadLine());
            Console.Write("輸入轉換的進位p(0~9):");
            p = int.Parse(Console.ReadLine());
            // nd 初始為 -1，表示尚未存入任何位數
            nd = -1; q = dn;
            // 以重複除以 p 並取餘數的方式取得各位數（從低位到高位）
            while (q != 0)
            {
                r = q % p;           // 取得目前最低位（餘數）
                N[++nd] = r;         // 將該位儲存在陣列（先遞增索引再指派）
                q = q / p;           // 更新商，準備處理下一位
                Console.Write($"{N[nd]}\n"); // 輸出剛儲存的位數（由低位開始）
            }
            // nd 目前為最後填入索引，實際位數為 nd + 1
            nd = nd + 1;
            Console.Write($"共有幾個位數 = {nd}\n",nd);
            // 由高位到低位依序輸出，組成最終的轉換結果
            for (i = nd - 1; i >= 0; i--) 
                Console.Write($"{N[i]}");   

            Console.Write("\n程式即將結束，請按任意一建結束!    ");
            Console.Read();

        }
    }
}
