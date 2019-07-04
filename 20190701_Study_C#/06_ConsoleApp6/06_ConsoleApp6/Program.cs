using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //var p = new Person()
            //{
            //    firstName = "やまだ",
            //    lastName = "たろう"
            //};

            ////仮引数の既定値
            //p.Show();

            ////名前付き引数
            //p.Show(greeting: "こんばんは");

            ////可変長引数
            //var p1 = new Args();
            //Console.WriteLine(p1.TotalProducts(12, 15, 5));

            ////outキーワードによる参照渡し
            //var p2 = new Passout();
            //int resultMax, resultMin;
            //p2.GetMaxMin(5, 3, out resultMax, out resultMin);
            //Console.WriteLine(resultMax);
            //Console.WriteLine(resultMin);

            ////タプル(複数値の返却)
            //var p3 = new TupleBasic();
            //Console.WriteLine(p3.GetMaxMin(5, 3));
            //Console.WriteLine(p3.GetMaxMin(5, 3).max);
            //Console.WriteLine(p3.GetMaxMin(5, 3).min);

            ////タプル⇔変数
            //(int max, int min) t = (15, 13);
            //var (max, min) = t;
            //var (_, min2) = t; //値の破棄

            //var t2 = (13, 108);
            //Console.WriteLine(t2.Item1);
            //Console.WriteLine(t2.Item2);

            ////匿名型(intとstringが混ざっているけど、Tuple型にしたくないケース)
            //var info = new { Title = "速習C#", Price = 1000 };
            //Console.WriteLine(info.Title);
            //Console.WriteLine(info.Price);

            //イテレーター
            var ite = new IteratorBasic();
            foreach (var str in ite.GetStrings())
            {
                Console.WriteLine(str);
            }
            
        }
    }

    //仮引数の既定値・名前付き引数
    class Person
    {
        public string firstName;
        public string lastName;

        public void Show(string greeting= "こんにちは")
        {
            Console.WriteLine($"{greeting}!{firstName}{lastName}さん");
        }
    }

    //可変長引数
    class Args
    {
        //引数が1つもない場合はエラー
        public int TotalProducts(int initial ,params int[] values)
        {
            int result = 1;
            foreach(var value in values)
            {
                result *= value;
            }
            return result;
        }
    }

    //outキーワードによる参照渡し
    class Passout
    {
        public void GetMaxMin(int x, int y, out int max , out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }
    }

    //タプル(複数値の返却)
    class TupleBasic
    {
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
        }
    }

    //イテレーターを定義
    class IteratorBasic
    {
        public IEnumerable<string> GetStrings()
        {
            yield return "あいうえお";
            yield return "かきくけこ";
            yield return "さしすせそ";
        }
    }

}
