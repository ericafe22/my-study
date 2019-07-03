//プリプロセッサはファイルの頭に定義
//#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////基本的なif構文
            ////if(flag) if(!flag)
            //var i = 8;
            //if(i == 10)
            //{
            //    Console.WriteLine(i);
            //}
            //else if(i == 8)
            //{
            //    Console.WriteLine($"10じゃないけど{i}だよ！");
            //}
            //else
            //{
            //    Console.WriteLine("10じゃないよ");
            //}

            ////switch構文
            //var rank = "甲";

            //switch(rank)
            //{
            //    case "甲":
            //        Console.WriteLine("大変良いです");
            //        break;                               //基本的にbreakは省略できない

            //    case "乙":
            //        Console.WriteLine("良いです");
            //        break;

            //    case "丙":
            //        Console.WriteLine("頑張りましょう");
            //        break;

            //    default:
            //        Console.WriteLine("???");
            //        break;
            //}

            ////switch構文+α
            //var drink = "ビール";

            //switch(drink)
            //{
            //    case "日本酒":
            //    case "ビール":
            //        Console.WriteLine("これはお酒です。");
            //        break;
            //}

            ////switch構文による型判定
            //object obj = -123;
            //switch(obj)
            //{
            //    case int j:
            //        Console.WriteLine(Math.Abs(j));
            //        break;
            //    case string str:
            //        Console.WriteLine(str[0]);
            //        break;
            //    default:
            //        Console.WriteLine("意図しない型です");
            //        break;
            //}

            ////while文
            //var k = 1;
            //while(k < 6)
            //{
            //    Console.WriteLine($"{k}番目のループです");
            //    k++;
            //}

            ////do...while文:必ずdoの中が1回は実行される
            //var l = 1;
            //do
            //{
            //    Console.WriteLine($"{l}番目のループです");
            //    l++;
            //}
            //while (l < 6);

            ////for文
            //for (var i = 1; i < 6; i++) //(初期化子; 条件; 反復子;)
            //{
            //    Console.WriteLine($"{i}番目のループです。");
            //}

            ////for文(省略ver)
            //for (var i = 1; i < 6; Console.WriteLine($"{i}番目のループです。"), i++) ;

            ////forEach文
            //var data = new[] { "a", "i", "u", "e", "o" };
            //foreach(var val in data)
            //{
            //    Console.WriteLine(val);
            //}

            ////コマンドライン引数
            ////ソリューションエクスプローラー->Properties->デバック->コマンドライン引数
            //foreach (var value in args)
            //{
            //    Console.WriteLine($"こんにちは、{value}さん");
            //}

            ////goto命令
            //goto THERE;
            //Console.WriteLine("ここはスキップされます。");

            //THERE:
            //Console.WriteLine("コードが終了しました");

            ////プリプロセッサ命令
            //#if DEBUG
            //    Console.WriteLine("デバッグ時にのみ表示");
            //#endif

            //折りたたみ可能なブロック
            #region 定数/変数の定義
            var price = 1000;
            var tax = 1.08;
            string morning = "Good Morning";
            #endregion
            Console.WriteLine($"{price * tax}円");


        }
    }
}
