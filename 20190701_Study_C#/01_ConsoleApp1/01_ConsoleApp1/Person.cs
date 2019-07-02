using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp1
{
    class Person
    {        
        ///<summary>
        ///人物の苗字
        /// </summary>
        public string firstName = "maike";

        ///<summary>
        ///人物の名前
        /// </summary>
        public string lastName = "hi";

        ///<summary>
        ///氏名を表示する
        /// </summary>
        ///<param name="Age">年齢</param>
        ///<returns>氏名と年齢に基づいて成型された文字列</returns>
        public string Show(int Age)
        {
            return $"名前は{lastName}{firstName}、{Age}歳です。";
        }
    }
}
