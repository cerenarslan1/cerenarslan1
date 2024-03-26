using System.Diagnostics;

namespace metotlarr_3.__14._12._23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametre alan*geriye değer döndüren metot tanımlama
            //return anahtar kelimesi
            //metot sonu
            int DonenDeger = toplamaYap(6, 7);
            if (DonenDeger > 10)
            {
                Console.WriteLine("Değer 10'dan büyüktür");
            }
            else
            {
                Console.WriteLine("Değer 10'dan küçüktür");
            }
            string gelenisimsoyisimdegeri = isimsoyisimdondur("Ceren", "Arslan");
            Console.WriteLine(gelenisimsoyisimdegeri);
            Console.ReadLine();

            //kullanıcıdan aldığınız sayının karesini alalım eğer 25 ten büyükse 
            //karesi 25 den büyüktür
            //değilse 25 ten küçüktür yazdırsın
            int sayi;
            Console.WriteLine("karesini bulmak istediğiniz sayıyı giriniz");
            sayi = int.Parse(Console.ReadLine());
            KaresiniAl(sayi);
            int KareDeger = KaresiniAl(sayi);
            if (KareDeger > 25)

            {
                Console.WriteLine("Karesi 25 ten büyüktür");
            }
            else
            {
                Console.WriteLine("Karesi 25 ten küçüktür");
            }

            Console.WriteLine("Lütfen sayı giriniz");
            int girilensayi = int.Parse(Console.ReadLine());
            TekMİCiftMi(girilensayi);
            Console.ReadLine();



            //kullanıcıdan 2 tane sayı alalım hangisi büyükse büyük olan sayıyı ekrana yazdıralım 

            Console.WriteLine("Lütfen sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen sayı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            KontrolEt(sayi1, sayi2);
            Console.ReadLine();

            static int toplamaYap(int sayi1, int sayi2)
            {
                int sonuc = sayi1 + sayi2;
                return sonuc;
            }
            static string isimsoyisimdondur(string isim, string soyisim)
            {
                return isim + " " + soyisim;
                //1. değerleri döndürmesi;
                //2. return anahtar kelmesi metodu bitiren anahtar kelimedir.
            }
            static int KaresiniAl(int sayi)
            {
                return sayi * sayi;
            }
            static void TekMİCiftMi(int sayi)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("sayı çifttir");
                }
                else
                {
                    Console.WriteLine("sayı tektir");
                }
            }
            static void KontrolEt (int sayi1, int sayi2)
            {
                if (sayi1 > sayi2)
                {
                    Console.WriteLine("1. sayı 2. sayıdan büyüktür"); 
                }
                else if (sayi1 == sayi2)
                {
                    Console.WriteLine("iki sayının değeri birbirine eşittir");    
                }
                else
                {
                    Console.WriteLine("1. sayı 2. sayıdan küçüktür.");
                }
            }
        }
    }
}