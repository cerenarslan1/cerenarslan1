using System.Runtime.CompilerServices;

namespace metotlar_kurs_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metodun geriye döndürmesi nedir?
            /* Bir metodun geriye değer döndürmesi demek, içerisinde yapılan operasyon ile üretilen sonucun ekrana yazılması demek değildir.
             Metodun geriye döndürdüğü değer, programatik olarak yakalanıp algoritmanın akışında kullanabileceğimiz değerdir.
            */
            double karekök = Math.Sqrt(100);


            #endregion

            #region Optional parameters (isteğe bağlı parametreler)
            /* Parametrreli bir metot kullanırken parametrelerin uygun türde değer göndermesi zorunludur. Eğer zorunlu bir şekilde
             parametre göndermek istemiyorsak sadece istediğimiz durumda göndermek istiyorsak ilgili paraöetrenin opsiyonel olması
            gerekmektedir. Bir parametrenin opsiyonel olması için default değeri olması gerekir.
            Birden fazla parametre alan metotlarda sadece bir kısım opsiyonel olabilir ama önemli nokta opsiyonel olan parametreler
            sağ tarfta olmalıdır.
             */
            //KENDİ MUTLAK DEĞER METODUMUZU YAZALIM.

            Console.WriteLine("Sayı giriniz:");
            double sayi = Convert.ToDouble(Console.ReadLine());
            double sonuc = mutlakDeger(sayi);

            Console.WriteLine("sayının mutlak değeri : " + sonuc);

            //hesap makinesi metodu oluşturma
            int sayi1;
            int sayi2;
            string isaretler;
            Console.WriteLine("1. sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemin işaretini giriniz");
            isaretler =Console.ReadLine();
            
            #endregion


            #region metodu tanımlandığı sınıf içerisinde kullanımı 
            //bir metot tanımlandığı sınıf içerisinde başka bir metot tarafından çağırılıcaksa isminin yazılması yeterlidir.
            Console.WriteLine("ceren");
            #endregion
            #region metodun başka sınıf içerisinden kullanımı 
            Random random = new Random();
            Matematik mat = new Matematik();//matematik sınıfımın mat adında referansını oluşturdum.
            mat.Topla(); //matematik sınıfından public olan metotdlara erişebiliyorum.                                

            #endregion

            #region non-trailing named arguments 
            //hangi parametreye hangi değerlerin gönderildiğini direkt görebilmek -----------


            CokParaMetreliMetot(20, 30, "onur", "aktas", "25");
            CokParaMetreliMetot
            #endregion

            #region In Keyword 
            //In komutu sayesinde parametreye verilen değeri sabit tutabilmekteyiz
            //ın komutu metodun parametresini readonly (sadece okunabilir ) halde getirir
            //In komutunun kullanıldığı değişkenle ilgili değişim söz konusu olduğunda derleyici hata verecektir.
            const string Marka = "samsung";

            #endregion
            #region local function 

            #endregion


            #region tanımlama kuralları 

            #endregion

            #region kullanım kuralları 

            #endregion

            #region amacı

            #endregion   


            #region örnek
            //kullanıcıya adını soralım daha sonra adını metotta gönderip örneğin "hoşgeldiniz onur bey" döndürelim eğer kullanıcı adını girmezse "misafir girişi" yazdıralım.
            Console.WriteLine("adınızı giriniz");
            string kullanıcı = Console.ReadLine();  
            
            Console.WriteLine(Hosgeldiniz(kullanıcı));
            #endregion
        }
        static double mutlakDeger(double numara)
        {
            if (numara < 0)
            {
                return -1 * numara;
            }
            else
            {
                return numara;
            }
        }

     
        static string Hosgeldiniz(string giris)
        {
            if (string.IsNullOrEmpty(giris))
            {
                return $"misafir giriş";
            }
            else
            {
               
                return $"hoşgeldiniz {giris} bey";
            }
        }
        static int HesapMakinesi (int sayi1, int sayi2, string isaretler)
        {
           return $
        }
    }



    class Matematik
    {
        public void Topla()
        {

        }
        private void Carps()
        {

        }
        public void Bol()
        {

        }
        public void Cıkar()
        {

        }
    }
}
