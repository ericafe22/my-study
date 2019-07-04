using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////クラスの基本
            //var p1 = new Person("太郎", "田中");
            //Console.WriteLine(p1.Show());

            //p1.firstName = "次郎";
            //p1.lastName = "山田";
            //Console.WriteLine(p1.Show());

            ////ローカル変数
            //Console.WriteLine(DisCount(1000, 0.2));

            //double DisCount(int price, double rate)
            //{
            //    return price * (1 - rate);
            //}

            ////コンストラクター初期化子
            //var p2 = new Person();
            //Console.WriteLine(p2.Show());

            ////コンストラクタ初期化子(構文)
            //var p3 = new Person2 {
            //    firstName = "モモ",
            //    lastName = "タロウ"
            //};
            //Console.WriteLine(p3.Show());

            ////クラスメソッド
            //Console.WriteLine(Figure.divNum);
            //Figure.GetTriangleArea(10, 20);

            //静的コンストラクタ
            var p4 = new Message(3);
            var p5 = new Message(2);
        }
    }

    //public:全てのクラスからアクセス可能。
    //internal:プログラム内からのみアクセス可能。

    //Pascal記法:すべての単語を大文字で始める。use)クラス名・メソッド ex)StringBuilder
    //camelCase記法：最初は小文字で単語の区切りは大文字。use)フィールド ex)firstName

    public class Person
    {
        //フィールド定義
        public string firstName;
        public string lastName;

        //コンストラクタ定義
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //コンストラクタ(引数を省略)
        public Person() : this("権兵衛", "名無し") { }

        //プロパティ定義
        public string FirstName
        {
            get
            {
                return null;
            }
            set { }
        }

        //メソッド定義
        //thisはフィールド変数へアクセスする
        public string Show()
        {
            return $"名前は{this.lastName} {this.firstName}です";
        }

        //デストラクタ(オブジェクト破棄のタイミングで実行される。不確実。)
        ~Person()
        {
            Console.WriteLine("finish");
        }
    }

    //コンストラクタ初期化子(構文)
    //優先順位：コンストラクタ初期化子(構文)>コンストラクタ>フィールド値
    public class Person2
    {
        //フィールド定義
        public string firstName;
        public string lastName;

        //メソッド定義
        public string Show()
        {
            return $"名前は{this.lastName} {this.firstName}です";
        }
    }

    //オーバーロード
    public class OverLoadMethod
    {
        public static void Test(decimal value)
        {   
        }
        //引数の型が異なる
        public static void Test(double value)
        {
        }
        //引数の個数が異なる
        public static void Test(decimal value , decimal value2)
        {
        }
    }

    //クラスメソッド
    class Figure
    {
        public static int divNum = 2; //ほぼグローバル変数のようなもの
        public static void GetTriangleArea(int width, int height)
        {
            Console.WriteLine($"三角形の面積は、{ width * height / divNum }");
        }

    }

    //シングルトン
    class MySingleton
    {
        //フィールド
        private static MySingleton instance = new MySingleton();
        //コンストラクタ
        private MySingleton() { }
        //プロパティ
        public static MySingleton Instance
        {
            get
            {
                return instance;
            }

        }
    }

    //静的コンストラクタ
    class Message
    {
        int number;

        static Message()
        {
            Console.WriteLine("静的コンストラクタ");
        }

        public Message(int number)
        {
            this.number = number;
            Console.WriteLine($"通常のコンストラクタ:{number}");
        }
    }


}
