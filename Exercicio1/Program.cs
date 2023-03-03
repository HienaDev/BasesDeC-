using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 0xFEDE;
            string a_bin = Convert.ToString(a, 2);
            Console.WriteLine(String.Format("Decimal: {0}, em binário é {1}", a, a_bin));


            a &= 0x0F0F;

            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(String.Format("{0:x}".ToUpper(), a));
        }
    }
}
