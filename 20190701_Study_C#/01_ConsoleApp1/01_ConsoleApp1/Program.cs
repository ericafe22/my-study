using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ■ショートカット
 Ctrl+k+Ctrl+c:コメントアウト
 Ctrl+k+Ctrl+u:コメントアウト解除
 Ctrl+Shift+L:選択した行を削除する
 Home(End):行頭(行末)に移動
 F5:デバッグ開始
 Ctrl+F5:デバッグなし実行
 */

namespace _01_ConsoleApp1
{
    class Program
    {
        public static object Con { get; private set; }

        static void Main(string[] args)
        {
            ////コンソールへの入出力
            //Console.WriteLine("あなたの名前は？");
            //string name = Console.ReadLine();
            //Console.WriteLine("こんにちは{0}さん！", name);

            ////インスタンスの作成(varは任意の型を選定してくれる型)
            //var p = new Person();
            //Console.WriteLine(p.Show(19));

            ////変数の記載
            //string name_id = "ericafe";
            //Console.WriteLine($"名前は{name_id}");

            ////文字列->数値
            //string str = "108";
            //Console.WriteLine(Int32.Parse(str));

            ////数値->文字列
            //int i = 123;
            //Console.WriteLine(i.ToString());

            //NULL許容型
            //int? num1 = 108;
            //int? num2 = null;

            //if(num1.HasValue)
            //{
            //    int j = num1.Value;
            //    Console.WriteLine(j);
            //}

            ////配列
            //int[] list1 = new int[5];
            //int[] list2 = { 1, 2, 3, 4, 5 };
            //var list3 = new[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(list2[0]);

            ////書き換えは可・要素の追加は付加
            //list2[0] = 15;

            //Console.WriteLine(list2[0]);

            ////多次元配列
            //int[,] list4 = new int[3, 3];
            //int[,] list5 = new[,]
            //{
            //    {10,12 },
            //    {15,17 },
            //};

            //Console.WriteLine(list5[1, 1]);

            ////Length:配列の長さ 
            ////Rank:配列の次元数
            ////DateTime.Now:現在時刻の取得

            //文字列の連結
            //string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog." };

            //var unreadablePhrase = string.Concat(words);
            //System.Console.WriteLine(unreadablePhrase);

            //var readablePhrase = string.Join(" ", words);
            //System.Console.WriteLine(readablePhrase);

            ////前置/後置演算での挙動
            //var m = 3;
            //var n = ++m;

            //Console.WriteLine(n); //1が加算された後の結果が代入される

            //var m2 = 3;
            //var n2 = m2++;

            //Console.WriteLine(n2); //1が加算される前の結果が代入される

            //除算
            //Console.WriteLine(15d / 7);
            //Console.WriteLine(15d / 0);

            //Console.WriteLine(Math.Floor((0.7M + 0.1M) * 10M)); //decimal型を使った方が安全だが遅い

            ////値型
            //var x = 1;
            //var y = x;
            //x += 10;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            ////参照型
            //var sb1 = new StringBuilder("あいう");
            //var sb2 = sb1;
            //sb1.Append("えお");
            //Console.WriteLine(sb1.ToString());
            //Console.WriteLine(sb2.ToString());

            ////関係演算子
            //Console.WriteLine((10 > 1) ? "正解" : "不正解");
            //Console.WriteLine($"{((10 > 1) ? "正解" : "不正解")}");

            //Console.WriteLine(null ?? "-");

            ////比較
            //var sb3 = new StringBuilder("あいう");
            //var sb4 = new StringBuilder("あいう");

            //Console.WriteLine(sb3 == sb4);
            //Console.WriteLine(sb3.Equals(sb4));

            ////配列の比較
            //var list7 = new[] { 1, 2, 3 };
            //var list8 = new[] { 1, 2, 3 };
            //Console.WriteLine(list7.SequenceEqual(list8));

            ////論理演算子(論理積&& ,  論理和||)
            //string str = null;
            //if(str !=null && str.StartsWith("http://"))
            //{
            //    Console.WriteLine("HTTP最高!");
            //}

            //値型のサイズを取得
            Console.WriteLine(sizeof(int));

            //変数を文字列リテラルとして取得
            string str2 = "test";
            Console.WriteLine(nameof(str2));
        }
    }
}
