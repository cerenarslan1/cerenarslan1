namespace _16._11._23_ders_calısma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // x den y ye(yde dahil) kadar olan çift sayıların 
            //toplamını bulan bir program yazınız.
            // X ve Y tek yada çift olabilir. 
            int x, y;
            Console.WriteLine("Lütfen başlangıç sayısı giriniz");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş sayısını giriniz");
            y = int.Parse(Console.ReadLine());

            int toplam = 0;
            for (int i = x; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("Toplam:" + toplam);
            Console.ReadLine();


            //Üst hesaplayan programı yazınız.
            int taban, üst;
            Console.WriteLine("Taban için bir sayı giriniz");
            taban = int.Parse(Console.ReadLine());
            Console.WriteLine("Üs için bir sayı giriniz");
            üst = int.Parse(Console.ReadLine());
            int sonuc = taban;
            for (int i = 1; i < üst; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine("Toplam:" + sonuc);
            Console.ReadLine();

            //Faktöriyel hesaplayan programı yazınız.
            //5!-5x4x3x2x1
            int sayi;
            Console.WriteLine("faktöriyel hesaplanacaj sayıyı yazınız.");
            sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            for (int i = 2; i <= sayi; i++)
            {
                sonuc *= i;
               ///* sonuc = sonuc * i;
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();


            //Tuttuğum sayıyı tahmin etmeye çalışan ve 3 hak veren programı yazınız
            Random rnd = new Random();
            int tutulanSayi = rnd.Next(1, 10);
            int tahmin = 0;
            bool dogruBildi = false;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Lütfen tahminizi giriniz");
                if (tahmin == tutulanSayi)
                {
                    dogruBildi = true;
                    break;

                }
            }
            if (dogruBildi)
            {
                Console.WriteLine("Doğru bildiniz");
            }
            else
            {
                Console.WriteLine("Bilemediniz! Tuttuğum sayı:" + tutulanSayi);
            }
            Console.ReadLine();



            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = 0;
            for (int i = 0; i < sayi2; i++)
            {
                toplam +=i;
            }

            double ortalama = toplam / sayi;
            if (ortalama > 50)
            {
                Console.WriteLine("Ortalama 50'den büyüktür.");
                Console.ReadLine();
            }
            else if (ortalama > 50)
            {
                Console.WriteLine("Ortalama 50'den küçüktür.");
                Console.ReadLine();
            }













        }
    }
}