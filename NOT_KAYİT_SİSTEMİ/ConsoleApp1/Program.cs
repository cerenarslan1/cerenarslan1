using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KOSULLAR
            //Kullanıcıdan 2 sayı isteyelim ve girilen 2 sayıyı +-+/ işlem sonucu olarak gösterelim.
            Console.WriteLine("Lütfen ilk sayıyı giriniz");
            int sayı = int.Parse(Console.ReadLine());
            int sayı2 = int.Parse(Console.ReadLine());

            Console.WriteLine(sayı + sayı2);
            Console.WriteLine(sayı - sayı2);
            Console.WriteLine(sayı / sayı2);
            Console.WriteLine(sayı * sayı2);
            Console.ReadLine();
            Console.WriteLine("Lütfen ilk sayıyı giriniz.");
            int sayi1, sayi2;
            string secilenIslem;
            sayi1 = int.Parse(Console.ReadLine());
            sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, (sayi1 + sayi2));
            Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, (sayi1 - sayi2));
            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, (sayi1 * sayi2));
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin (+ - * /)");
            secilenIslem = Console.ReadLine();

            if (secilenIslem == "+")
            {
                Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, (sayi1 + sayi2));
            }

            string user;
            Console.WriteLine("personel harici giremez. /nKimsin?");
            user = Console.ReadLine();

            if (user == "personel")
            {
                Console.WriteLine("hoşgeldiniz");

            }
            else if (user == "öğrenci")
            {
                Console.WriteLine("öğrenciler yan kapıdan");

            }
            else
            {
                Console.WriteLine("hatalı taşlama yaptınız.");
            }
            Console.ReadLine();



            int sinav1, sinav2, ortalama;
            Console.WriteLine("1: sınav giriniz");
            sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sınav giriniz");
            sinav2 = Convert.ToInt32(Console.ReadLine());
            ortalama = (sinav1 + sinav2) / 2;

            //kişi sınavları 0-100 arası girebilsin. 
            if (ortalama >= 90 && sinav1 > 0 && sinav2 > 0 && sinav1 <= 100 && sinav2 <=100)
            {
                Console.WriteLine("Tebrikler üstün başarı ile geçtiniz.");

            }
            else if (ortalama >= 50)
            {
                Console.WriteLine("Tebrikler ortalama başarı ile geçtiniz.");
            }
            else
            {
                Console.WriteLine("Sınıf tekrarı");


            }
        }
    }
}



