using System;

namespace RefVeOutKeyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 42;
            int z = Carpma(x, y);

            Console.WriteLine( z ); // bu satırda 8 çıktısını alırız. Çünkü biz değer tipli olarak methoda göndermiş olduk.
            Console.WriteLine("----ref keywordunu kullanırsak----");
            int a = 1;
            int b = 4;
            int c = Carpma1(ref a, b);
            Console.WriteLine(c); //burda ref keywordu ile a 'yı referans tipine dönüştürmüş olduk bu nedenle çıktımız a'nın değerini  kullanacaktır
                                  // cıktı:8 olacaktır
            Console.WriteLine(a); // ref keyworduyle beraber a değeri 2 olmuş olacak.
            Console.WriteLine("---- out keywordu-----");

            int m; // m'yi out ile kullandığımız için burda setleme yapmaya ihtiyacımız olmayacaktır.
            int t = 2;
            int l = Carpma2(out m,  ref t);
            Console.WriteLine(l); // burda da hem ref hemde out olarak kullandık verilerimizi.
            Console.WriteLine("m ve t değerlerimiz:  " );
            Console.WriteLine(m); // burda 2 değerini
            Console.WriteLine(t); // burda ise 4 değeri çıktı olarak verilecektir.

            




        }
        static int Carpma(  int number1, int number2)
        {
            number1 = 2;
            number2 = 4;
            int sonuc = number1 * number2;
            return sonuc;
        }
        static int Carpma1(ref int number1, int number2)
        {
            number1 = 2;
            number2 = 4;
            int sonuc = number1 * number2;
            return sonuc;
        }
        static int Carpma2(out int number1,  ref int number2)
        {
            number1 = 2; // out için burda setleme yapmak zorundayız.
            number2 = 4;
            int sonuc = number1 * number2;
            return sonuc;
        }
    }
}
    

