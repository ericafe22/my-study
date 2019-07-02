using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03_ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //文字列の長さ
            string str1 = "test";
            Console.WriteLine(str1.Length);

            //文字列の長さ(サロゲートペアを含む)
            string str2 = "津澤恵理加";
            StringInfo strInfo = new StringInfo(str2);
            Console.WriteLine(strInfo.LengthInTextElements);

            //大文字・小文字を区別しない比較
            var str3 = "wings";
            var str4 = "WINGS";

            Console.WriteLine(str3.Equals(str4, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Compare(str3, str4, StringComparison.OrdinalIgnoreCase)); //等しければ0、そうでなければ正数か負数

            //大文字・小文字、全角・半角を区別しない比較
            var str5 = "test";
            var str6 = "TEST";


        }
    }
}
