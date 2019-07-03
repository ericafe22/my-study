using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace _03_ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////文字列の長さ
            //string str1 = "test";
            //Console.WriteLine(str1.Length);

            ////文字列の長さ(サロゲートペアを含む)
            //string str2 = "津澤恵理加";
            //StringInfo strInfo = new StringInfo(str2);
            //Console.WriteLine(strInfo.LengthInTextElements);

            ////大文字・小文字を区別しない比較
            //var str3 = "wings";
            //var str4 = "WINGS";

            //Console.WriteLine(str3.Equals(str4, StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(string.Compare(str3, str4, StringComparison.OrdinalIgnoreCase)); //等しければ0、そうでなければ正数か負数

            ////全角・半角を区別しない比較
            //var ci = CultureInfo.CurrentCulture.CompareInfo;
            //Console.WriteLine(ci.Compare(str3, str4, CompareOptions.IgnoreWidth));

            ////ひらがなとカタカナを区別しない比較
            //Console.WriteLine(ci.Compare(str3, str4, CompareOptions.IgnoreKanaType));

            ////文字列がNULLまたは空文字かを判定
            //var null_str = "";
            //Console.WriteLine(String.IsNullOrEmpty(null_str));

            ////文字列がNULLまたは空文字または空白の文字列かを判定
            //var emp_str = "   ";
            //Console.WriteLine(String.IsNullOrWhiteSpace(emp_str));

            ////文字列の検索
            //var niwa_str = "にわにはにわにわとりがいる";
            //Console.WriteLine(niwa_str.IndexOf("にわ")); //インデックスの値を返却

            ////特定の文字列が含まれるかの検索
            //var str5 = "WINGSプロジェクト";
            //Console.WriteLine(str5.Contains("プロ"));
            //Console.WriteLine(str5.StartsWith("WINGS"));
            //Console.WriteLine(str5.EndsWith("WINGS"));

            ////1つでも数字が含まれるかを判定
            ////IsDigit:10進数の数値か
            ////IsNumber:数値か
            ////IsString:文字か
            //var str6 = "プロジェクト2号";
            //Console.WriteLine(str6.Any(ch => Char.IsDigit(ch)));

            ////部分文字列の取得
            //var str7 = "WINGSプロジェクト";
            //Console.WriteLine(str7.Substring(5, 2)); //開始位置、文字数

            ////特定の文字以降の文字列を抜き出す
            //var str8 = "tsuzawa@cns.co.jp";
            //Console.WriteLine(str8.Substring(str8.LastIndexOf("@") + 1));

            ////特定の文字で分割する
            //var str9 = "うめ,もも";
            //var result9 = str9.Split(',');
            //Console.WriteLine(string.Join("&", result9));

            ////特定の文字で分割する(ブロック数指定)
            //var str10 = "うめ,もも,さくら";
            //var result10 = str10.Split(new[] { ',' }, 2);
            //Console.WriteLine(string.Join("&", result10));

            ////整形する(文字列)
            //Console.WriteLine(string.Format("{0}は{1}歳です。", "さくら", "12"));

            ////整形する(文字列の幅を指定)
            //Console.WriteLine(string.Format("{0,5}は{1}歳です。", "さくら", "12")); //不足分は空白

            ////整形する(数値)
            //Console.WriteLine(string.Format("10進数で8桁:{0:d8}" , 12345)); //0埋め

            ////整形する(日付)
            //Console.WriteLine(string.Format("日付:{0:D}", DateTime.Now));

            ////正規表現
            //var tel = new[]{ "080-111-5555", "222-33-1111", "XXX-158" };
            //var rgx = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");

            //foreach (var t in tel)
            //{
            //    Console.WriteLine(rgx.IsMatch(t) ? t : "アンマッチ");
            //}

            ////正規表現(Match文字列_マッチした最初の1つだけを取得)
            //var str11 = "電話番号は,080-5555-6666";
            //var rgx2 = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");
            //var match = rgx2.Match(str11);

            //if (match.Success)
            //{
            //    Console.WriteLine($"位置{match.Index} 文字列{match.Value}");
            //}

            ////正規表現(Matchesメソッド)
            //var str12 = "電話番号は,080-5555-6666と080-1111-2222です";
            //var rgx3 = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");
            //var match2 = rgx3.Matches(str12);

            //foreach (Match m in match2)
            //{
            //    Console.WriteLine($"位置{m.Index} 文字列{m.Value} 長さ{m.Length}");
            //}

            ////正規表現による置換
            //var str13 = "電話番号は,080-5555-6666です";
            //var rgx4 = new Regex(@"\d{2,4}-\d{2,4}-\d{4}"); //正規表現でマッチした箇所を置換する
            //Console.WriteLine(rgx4.Replace(str13, "*これはテストです。$0*")); //$0には正規表現でマッチしたものが格納

            ////文字列の置換
            //var str14 = "私はかすみです。";
            //Console.WriteLine(str14.Replace("かすみ", "えりか"));

            ////正規表現による文字列の分割
            //var str15 = "にわ1にわにわ2にゃー3";
            //var rgx5 = new Regex(@"\d{1,}");
            //var result1 = rgx5.Split(str15);
            //Console.WriteLine(string.Join(",", result1));

            ////日付
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);

            ////日付(作成)
            //Console.WriteLine(new DateTime(2019, 12, 10, 13, 45, 11));

            ////日付(文字列からの変換)
            //string str16 = "2019/02/02 13:14:25";
            //Console.WriteLine(DateTime.Parse(str16));

            ////日付(任意の書式文字列)
            //var str17 = "20190101092534";
            //DateTime dt = DateTime.ParseExact(str17, "yyyyMMddHHmmss", new CultureInfo("ja-JP"));

            ////日付(個々の要素を取得する)
            //DateTime dt1 = new DateTime(2019, 12, 10, 13, 45, 11);
            //Console.WriteLine($"{dt1.Year}年{dt1.Month}月{dt1.Day}日");

            ////日付(整形)
            //DateTime dt2 = new DateTime(2019, 12, 10, 13, 45, 11);
            //Console.WriteLine(dt2.ToString("yyyy/MM/dd(ddd)"));

            ////日付(加算・減算)
            //DateTime dt3 = new DateTime(2019, 10, 04, 13, 45, 11);
            //Console.WriteLine(dt3.AddYears(10));
            //Console.WriteLine(dt3.AddMonths(-3));

            ////日付(2つの日付の加算・減算)
            //DateTime dt4 = new DateTime(2019, 08, 03, 19, 33, 08);
            //DateTime dt5 = new DateTime(2019, 10, 04, 13, 45, 11);
            //var sub = dt5.Subtract(dt4);
            //Console.WriteLine(sub.ToString("c"));

            //ファイルの操作
            /*PATHの取得*/
            var path1 = System.Environment.CurrentDirectory;
            var path2 = path1.Substring(0, path1.LastIndexOf(@"\"));
            var path3 = path2.Substring(0, path2.LastIndexOf(@"\"));
            var path4 = path2.Substring(0, path3.LastIndexOf(@"\"));
            string data_path = String.Concat(path4, @"\data\01_file.txt");
            string data_path1 = String.Concat(path4, @"\data\02_file.txt");
            string data_path2 = String.Concat(path4, @"\data\03_file.txt");

            ///*書き込み*///Encoding指定しないと出力されない
            //StreamWriter writer = new StreamWriter(data_path, append: true, Encoding.GetEncoding("UTF-8"));
            //writer.WriteLine("output");
            //writer.Close();

            ///*書き込み_using*///明示的に指定しなくてもCloseしてくれる
            //using (var writer2 = new StreamWriter(data_path1))
            //{
            //    writer2.WriteLine(DateTime.Now.ToString());
            //}

            ///*書き込み_まとめて*/
            //var lines = new[] { "ねこ", "イルカ" };
            //File.WriteAllLines(data_path2, lines);

            ////ファイルの操作(読み込み)
            ///*読み込み*/
            //using (var reader = new StreamReader(data_path))
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}

            ///*読み込み(行単位)*///メモリーの省エネ
            //using (var reader = new StreamReader(data_path))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        Console.WriteLine(reader.ReadLine());
            //    }
            //}

            ////ファイルの操作
            //var file = new FileInfo(data_path);

            ////存在チェック
            //Console.WriteLine(file.Exists);
            ////ファイル名取得
            //Console.WriteLine(file.Name);
            ////フォルダ名を取得
            //Console.WriteLine(file.DirectoryName);
            ////ファイルサイズ
            //Console.WriteLine(file.Length);

            ////ファイルのコピー
            //string data_path3 = String.Concat(path4, @"\data\01_file_copy.txt");
            //var file2 = file.CopyTo(data_path3, true);

            ////ファイルの移動
            //string data_path4 = String.Concat(path4, @"\data\04_file.txt");
            //string data_path5 = String.Concat(path4, @"\data2\04_file.txt");
            //var file3 = new FileInfo(data_path4);
            //var file4 = new FileInfo(data_path5);

            //if (!file3.Exists)
            //{ 
            //    StreamWriter sw = File.CreateText(data_path4);
            //    sw.Close();
            //}

            //if (file4.Exists)
            //{
            //    file4.Delete();
            //}

            //file3.MoveTo(data_path5);

            ////ファイル名の変更
            //string data_path6 = String.Concat(path4, @"\data2\05_file.txt");
            //var file5 = new FileInfo(data_path6);

            //if (!file5.Exists)
            //{
            //    StreamWriter sw1 = File.CreateText(data_path6);
            //    sw1.Close();
            //}

            //string data_path7 = String.Concat(path4, @"\data2\05_rename.txt");
            //var file6 = new FileInfo(data_path6);
            //file6.MoveTo(data_path7);

            ////フォルダーの操作
            //var dir = new DirectoryInfo(path4);

            ////サブフォルダの一覧を取得
            //var dirs = dir.GetDirectories();
            //foreach (var d in dirs)
            //{
            //    Console.WriteLine(d.FullName);
            //}

            ////全サブフォルダの一覧を取得
            //var dirs2 = dir.GetDirectories("*", SearchOption.AllDirectories);
            //foreach (var d in dirs2)
            //{
            //    Console.WriteLine(d.FullName);
            //}

            ////単発のファイル操作
            ///*コピー*/
            //var d_path = String.Concat(path4, @"\data3\01_file.txt");
            //var d_path1 = String.Concat(path4, @"\data3\01_file_copy.txt");

            //if (File.Exists(d_path1))
            //{
            //    File.Delete(d_path1);
            //}

            //File.Copy(d_path, d_path1, true);

            ///*移動*/
            //var d_path2 = String.Concat(path4, @"\data3\02_file.txt");
            //var d_path3 = String.Concat(path4, @"\data4\02_file.txt");

            //if (!File.Exists(d_path2))
            //{
            //    File.CreateText(d_path2);
            //}

            //if (File.Exists(d_path3))
            //{
            //    File.Delete(d_path3);
            //}

            //File.Move(d_path2, d_path3);

            //配列の操作
            var array1 = new[] { "fox", "dog", "cat" };

            Array.Sort(array1);
            Console.WriteLine(string.Join("&", array1));

            //ソート済み配列の検索
            Console.WriteLine(Array.BinarySearch(array1, "fox"));

            //配列のサイズを拡張
            Array.Resize(ref array1, array1.Length + 3);
            Console.WriteLine(string.Join("&", array1));

        }

    }
}
