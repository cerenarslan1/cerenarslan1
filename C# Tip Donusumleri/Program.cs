using System.Security.Cryptography.X509Certificates;

namespace C__Tip_Donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TÜR DÖNÜŞÜMLERİ
            int a = 5;
            byte b = (byte)a;
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();

            string sayi1 = "1";
            string sayi2 = "2";
            Console.WriteLine(sayi1 + sayi2);
            Console.ReadLine();

            string isim = "Ceren";
            string soyisim = "Arslan";
            Console.WriteLine(isim + soyisim);
            Console.ReadLine();


          

            //İNT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞTÜRME YAPTIK
            //int sayi1 = 5;
            //int sayi2 = 10;
            //string a = sayi1.ToString();
            //string b = sayi2.ToString();    

            //Console.WriteLine(b+a);
            //Console.ReadLine();

            //DOUBLE VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME
            double sayi = 5.22;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();

            //KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR.
            string kullanici_yas = Console.ReadLine();



            // //Kullanıcıdan 3 not alan ve bu notların ortalamasını bulan
            // //Eğer 80-100 arasındaysaa A+ yazdıran 
            // //60-80 arasındaysa A yazdıran 
            // //40-60 arasındaysa B+ yazdıran 
            // //40 dan küçükse F yazdıran örneğin kod kod parçalarını yazınız. 


            Console.WriteLine("Lütfen 1. notunuzu giriniz.");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());
            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("Not ortalamanız A+");

            }
            else if (sonuc > 60 && 80 < sonuc)
            {
                Console.WriteLine("Not ortalamanız A");
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Not ortalamanız B+");

            }
            else if (sonuc < 40)
            {
                Console.WriteLine("Not ortalamanız F ");

            }

            Console.ReadLine();

        }
    }
}