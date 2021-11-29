using System;

namespace TypeConversion_6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;
            sbyte a=2;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine("i: "+i);

            string e = "eren";
            char c1 = 'k';
            object o = e + c1 + d;
            Console.WriteLine(o);
            
            Console.WriteLine("**** Explicit Conevrsion *****");

            int x = 4;
            byte t = (byte) x;
            Console.WriteLine("t:" +t);

            int z = 100;
            byte y = (byte) z;

            float w = 10.3f;
            byte v = (byte) w;
            
            //*** ToString Methodu****
            
            Console.WriteLine("***** ToString Methodu *****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);
            
            Console.WriteLine(" *********** System.Convert *********");

            string s1 = "10", s2 = "20";

            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine(Toplam);
            
            //Parse
            Console.WriteLine("*** Parse Methodu ****");

            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1;
            double d1;
            
            rakam1 = Int32.Parse(metin1);

            d1 = Double.Parse(metin2);
            Console.WriteLine("d1: "+d1);
            Console.WriteLine("rakam1: "+rakam1);
        }
    }
}