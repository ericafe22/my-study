using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////コレクション
            //var list = new List<string>();
            //list.Add("あいうえお");
            //Console.WriteLine(list[0]);

            ////コレクションの初期化
            //var list2 = new List<string>() { "ねこ", "いぬ", "きじ" };
            //Console.WriteLine(list2[0]);

            ////配列からコレクションの作成
            //var array = new[] { "バラ", "とげ", "漆黒" };
            //var list3 = new List<string>(array);
            //Console.WriteLine(list3[0]);

            ////コレクションの配列化
            //var list4 = new List<string>() { "red", "blue", "yellow" };
            //var array2 = list4.ToArray();
            //Console.WriteLine(array2[0]);

            ////ディクショナリ
            //var flower = new Dictionary<string, string>()
            //{
            //    {"Rose", "red" },
            //    {"Sunflower", "yellow"},
            //    {"Glory", "blue" }
            //};

            ////コレクションの配列処理
            //var list5 = new List<string>() { "a", "b", "c" };
            //foreach(var s in list5)
            //{
            //    Console.WriteLine(s);
            //}

            ////コレクションの配列処理(列挙子)
            //var enu = list5.GetEnumerator();
            //while(enu.MoveNext())
            //{
            //    string str = enu.Current;
            //    Console.WriteLine(str);
            //}

            ////List:インデックス操作が可能、要素の挿入・削除は遅い
            ////LinkedList：インデックス操作が不可、要素の挿入・削除が高速

            ////Listの操作
            //var list6 = new List<int> { 10, 15, 30, 60 };
            //list6.Insert(2, 7); //2番目の要素に7を挿入
            //list6.Add(120);

            //Console.WriteLine(list6.Count);
            //Console.WriteLine(list6.Contains(15));
            //list6.GetRange(1, 2);
            //list6.Reverse();

            ////LinkedListの操作
            //var animals = new[] { "かめ", "ひつじ", "うさぎ" };
            //var list7 = new LinkedList<string>(animals);

            ////foreach(var v in list7)
            ////{
            ////    Console.WriteLine(v);
            ////}

            ////要素の追加など
            //list7.AddFirst("ねずみ");
            //list7.AddLast("とら");
            //list7.AddBefore(list7.Last, "うま");
            //list7.AddAfter(list7.First, "やぎ");
            //list7.Remove("かめ");

            //STACK
            var s = new Stack<int>();
            s.Push(10); //アイテムを追加a
            s.Push(15);
            s.Push(20);

            Console.WriteLine(s.Count());
            Console.WriteLine(s.Contains(20));
            Console.WriteLine(s.Pop()); //要素を末尾から取り出し&削除
            Console.WriteLine(s.Peek());//要素を末尾から取り出し

            //QUEUE
            var ss = new Queue<int>();
            ss.Enqueue(10);
            ss.Enqueue(20);
            ss.Enqueue(30);

            Console.WriteLine(ss.Count());
            Console.WriteLine(ss.Contains(20));
            Console.WriteLine(ss.Dequeue());//要素を末尾から取り出し&削除
            Console.WriteLine(ss.Peek());//要素を末尾から取り出し

            //セット
            //要素の重複を許さない。集合。
            var hs = new HashSet<int> { 1, 2, 3, 4, 5 };
            var hs2 = new HashSet<int> { 3, 4, 5 };
            hs.Add(6);
            hs.Remove(1);

            Console.WriteLine(ss.Count());
            Console.WriteLine(ss.Contains(5));

            hs.UnionWith(hs2);

            //SortedSet
            var set = new SortedSet<int> { 30, 40, 50, 60 };
            Console.WriteLine(set.Min);
            Console.WriteLine(set.Max);

            //Dictionary
            var dic = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["SunFlower"] = "ひまわり",
                ["Glory"] = "あさがお"
            };

            Console.WriteLine(dic.Count);
            Console.WriteLine(dic.ContainsKey("Rose"));
            Console.WriteLine(dic.ContainsValue("バラ"));

            dic.TryGetValue("Rose", out string name);
            Console.WriteLine(name);

            //要素の追加
            dic.Add("Tulip", "チューリップ");
            //要素の更新
            dic["SunFlower"] = "向日葵";
            //要素の削除
            dic.Remove("Rose");

            foreach (var m in dic)
            {
                Console.WriteLine($"{m.Key}:{m.Value}");
            }

            foreach (var m2 in dic.Values)
            {
                Console.WriteLine(m2);
            }

            //SortedDictionary:要素の挿入/削除は高速
            //SortedList:検索は高速だが、要素の挿入/削除は低速

            //SortedDictionary(Red-Blackツリー)
            var sd = new SortedDictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["SunFlower"] = "ひまわり",
                ["Glory"] = "あさがお"
            };

            foreach (var key in sd.Keys)
            {
                Console.WriteLine($"{key}:{sd[key]}");
            }

            //SoterdList(二分探索)
            var sl = new SortedList<string, string>()
            {
                ["Rose"] = "バラ",
                ["SunFlower"] = "ひまわり",
                ["Glory"] = "あさがお"
            };

            foreach (var m in sl)
            {
                Console.WriteLine($"{m.Key}:{m.Value}");
            }


        }
    }
}
