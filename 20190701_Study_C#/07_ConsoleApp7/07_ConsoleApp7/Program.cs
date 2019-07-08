using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            ////アクセサリメソッド
            //var t = new Triangle();
            //t.SetWidth(10);
            //t.GetWidth();

            ////プロパティ
            //var t2 = new Triangle2();
            //t2.Width = 10;
            //t2.Height = 5;

            ////自動プロパティ
            //var p = new Person()
            //{
            //    LastName = "山田",
            //    FirstName = "タロウ"
            //};
            //Console.WriteLine(p.Show());

            //インデクサー
            var array = new FreeArray(5);
            array[0] = 1;
            array[1] = 10;
            array[2] = 15;
            array[3] = 30;
            array[4] = 60;

            Console.WriteLine(array[2]);   //結果：15 アルゴリズム：2÷5 = 0 … 2
            Console.WriteLine(array[-10]); //結果：1  アルゴリズム：問答無用で0
            Console.WriteLine(array[6]);   //結果：10 アルゴリズム：6÷5 = 1 … 1

            //文字列型のインデクサ

        }
    }
}

//アクセサリメソッド
class Triangle
{
    private double width;
    private double height;

    public double GetWidth()
    {
        return this.width;
    }

    public double GetHeight()
    {
        return this.height;
    }

    public void SetWidth(double width)
    {
        this.width = width;
    }

    public void SetHeight(double height)
    {
        this.height = height;
    }
}

//プロパティ
class Triangle2
{
    //プライベートなインスタンスフィールドには接頭辞として_(アンダースコア)を付けると良い
    private double _width;
    private double _height;
    private double _coefficient;

    //Widthのプロパティ定義
    public double Width
    {
        set { this._width = value; }
        get { return this._width; }
    }

    //Heightのプロパティ定義
    public double Height
    {
        set { this._height = value; }
        get { return this._height; }
    }

    //係数のプロパティ定義
    public double Coefficient
    {
        //値の取得はどこからでも行えるが、設定はクラスか派生クラスからのみ
        protected set { this._coefficient = value;  }
        get { return this._coefficient; }
    }
}

//自動プロパティ
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Show()
    {
        return $"名前は{this.LastName}{this.FirstName}です。";
    }
}


//インデクサ
class FreeArray
{
    private int _size; //配列サイズ
    private int[] _list; //配列本体

    //コンストラクタ
    public FreeArray(int size)
    {
        this._size = size;
        this._list = new int[size];
    }

    //インデクサ
    public int this[int index]
    {
        set { this._list[this.GetIndex(index)] = value; }
        get { return this._list[this.GetIndex(index)];  }
    }

    //メソッド
    private int GetIndex(int index)
    {
        if(index < 0){ return 0; }
        return index % this._size;
    }
}

//文字列型のインデクサ
class JapaneseMonth
{
    private string[] _month = { "如月", "弥生", "卯月" };


}