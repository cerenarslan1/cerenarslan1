using System.Runtime.Remoting;

namespace _29._11._23_try_catch_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hata türleri
            //1-Sözdizimi(Syntax) hatası
            //Programlama dilinin kurallarına aykırı olan hatalardır.
            //Özellikle gelişmiş editörler sayesinde söz dizimi hataları derlemeye gerek kalmadan fark edilebilmektedir.
            //Hatanın bulunduğu satır derleyici tarafından 
            ///2- Çalışma Zamanı Hatası(Run-Time)
            //Synax!da bir sorun olmayan ama çalışma anında patlamaya sebep olan hatalardır.Böyle bir senaryo yaşanmasın diye yazılımdakihata 

            //Örnek

            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Girilen iki sayının çarpımı:" + (sayi1 * sayi2));

            //3-Mantıksal hatalar (Logic-Error)
            //Program mantığında akışında,algoritmasında,stratejisinde bir takım şeylerin yanlış hesaplanması, düşünülmesi, tasarlanması neticesinde alınan hatalardır.

            //Syntax!ta kodun derlenmesinde ve çalışma zamanında hata yoktur. Kod çalışır ama yanlış sonuç verir. Bu dueumda mantıksal hata yapmışız demektir.

            //Tespiti çok zor olduğu için hata türleri arasında en tehlikeli hatadır.
            //Mantıksal hatalardaki en büyük yardımcınız debug2dur.

            //try-catch 
            //Çalışma zamanında alınan olası hataları kontrol etmemizi,karş...

            //trycatch yapılanması,.........





            try
            {
                Console.WriteLine("Lütfen birinci sayıyı giriniz:");
                int s1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
                int s2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Girilen iki sayının çarpımı:" + (s1 * s2));
            }
            catch
            {
                Console.WriteLine("lütfen 0!dan farklı bir tam sayı giriniz");
            }
            //Exception Kullanımı 
            int number = 0, number2 = 9;
            object x = null;

            //Kullanıcı öğrenci ismi numarası ve not bilgisini girsin girdiği bilgileri listelerde tutalım. Not bilgisi int olacağından dolayı not yerine harf girdiğinde uygulama patlamasın. Kullanıcıyı bilgilendirsin ve not bilgisinin tekrar girilmesini sağlasın. 
            int not;
            string ad;
            List<string> adlar = new List<string>();
            List<int> notlar = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("lütfen {0}. öğrenci ismini giriniz", (i + 1));
                ad = Console.ReadLine();
                adlar.Add(ad);

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Lütfen {0}. öğrencinin puan bilgilerini giriniz", (i + 1));
                        not = int.Parse(Console.ReadLine());
                        notlar.Add(not);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Lütfen not bilgisini sayıyla giriniz");
                    }
                }


            }

            Console.Clear();
            foreach (int not1 in notlar)
            {
                Console.WriteLine(not1);
            }

            // 10 kişinin yaşı kullanıcıdan istenerek listeye atılsın daha sonra konsol ekranını temizleyelim Sonra ekranda girilen yaşları küçükten büyüğe sıralı bir şekilde gösterip, yaşların toplamını ve yaşların ortalamasını yazdıraalım. Yaş değeri tam sayı haricinde girildiğinde uygulama patlamasın.İ

            List<int> yaslar = new List<int>();
            int toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. yaşı giriniz.", (i + 1));
               
                try
                {
                    int yas = int.Parse(Console.ReadLine());
                    yaslar.Add(yas);
                }
                catch (Exception)
                {

                  Console.WriteLine("Lütfen sayı giriniz.");
                    i--;
                }
            }

            Console.Clear();
            yaslar.Sort();

            foreach (int yas in yaslar)
            {
                Console.WriteLine(yas);
            }



            Console.WriteLine();
            Console.ReadLine(); 
        }
    }
}