using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puppy Dennispuppy = new Puppy(1, "Dennis", "White", 500, "阿拉斯加", "8");
            //最後,叫用DennisCar的方法PrintAllAttrib( )印出所有屬性參數.
            Dennispuppy.PrintAllAttrib();

            //===============================================
            //第二個 使用有參數的建構子設一台車MarysCar.
            //經由建構子函式2 來設定所有屬性
            Puppy Maryspuppy = new Puppy(2, "Mary", "black", 300, "吉娃娃", "5");

            //最後,叫用 MarysCar的方法PrintAllAttrib( )印出所有屬性參數.
            Maryspuppy.PrintAllAttrib();


        }
    }
}
