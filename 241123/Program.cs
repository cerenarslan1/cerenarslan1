using System.Security.Cryptography;
using System.Transactions;

namespace _241123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziyi listeye çevirme
            int[] sayilarDizi = { 1, 2, 3, 4, 5, 6 };
            List<int> sayilarList = new List<int>(sayilarDizi);
            foreach (var item in sayilarList)
            {
                Console.WriteLine(item);
            }
           // Şehir dizisi oluşturalım ve içerisine 5 tane şehir girsin Daha sonra bu diziyi listeye çevirelim ve kullanıcıya aramak istediği şehiri soralım eğer şehir varsa ekranda o şehirin index numarasını gösterelim yoksa şehir bulunamadı yazdıralım.

            string[] sehirler = new string[5];
            Console.WriteLine("Lütfen 5 adet şehir giriniz");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. şehri giriniz :", (i + 1));
                Console.ReadLine();
            }

            List<string> sehirList = new List<string>(sehirler);

            Console.WriteLine("Lütfen aranacak şehiri giriniz");
            string arananSehir = Console.ReadLine();
            if (sehirList.Contains(arananSehir))
            {
                Console.WriteLine("Aranan şehir listede mevcut");
            }
            else
            {
                Console.WriteLine("Aranan {0} şehir listede mevcut değil:", arananSehir);
            }
            Console.ReadLine();

            //4 tane liste oluşturalım bu listelerde öğrencilere ait: öğrenci numarası, öğrenci ismi, öğrenci telefon  numarası ve 
            //öğrenci mail adresini tutalım. Daha sonra kullanıcıya aramak istediği öğrencinin öğrenci numarasını girmesini isteyelim.
            //girdiği öğrenci numarasınaa ait öğrenci var ise öğrencinin tüm bilgilerini ekranda yszdıralım eğer yoksa aranan öğrenci bulunmadı yazalım.
            List<string> ogrencilerIsım = new List<string> { "ahmet", "mehmet", "burak", "beyza", "nisa" };
            List<string> ogrencilerNo = new List<string> { "1", "2", "3", "4", "5" };
            List<string> ogrencilerTelNo = new List<string> { "111", "222", "333", "444", "555" };
            List<string> ogrencilerMail = new List<string> { "aa@gmail.com", "bb@gmail.com", "cc@gmail.com", "dd@gmail.com", "a@gmail.com" };

            Console.WriteLine("Aramak istediğiniz öğrencinin numarasının giriniz");
            string ArananEleman = Console.ReadLine();
            int index = ogrencilerNo.IndexOf(ArananEleman);
            if (index != -1)
            {
                Console.WriteLine("Aranan öğrencinin adı : {0}  telefon numarası : {1}  mail adresi {2} :", ogrencilerIsım[index], ogrencilerTelNo[index], ogrencilerMail[index]);
            }
            else
            {
                Console.WriteLine("Aranan eleman mevcut değildir");
            }
            Console.ReadLine();



            //Kullanıcıya eklemek istediğiniz öğrenci var mı e/h diye soralım eğer e ye basarsa listelere yeni öğrenci ekletelim eğer h ye basarsa uygulama sonlansın. Her öğrenci eklendiğinde aynı soruyu tekrark soralım.Yanikullanıcı e yanıtını verdiği  süredce yeni öğrenci ekleyebilsin. h ye bastıktan sonra listeninson halini gösterip uygulamaya son verelim.

            Console.WriteLine("Eklemek istediğiniz öğrenci var mı? e/h");
            string cevap = Console.ReadLine();
            if (cevap == "e")
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Yeni öğrenci bilgilerini girebilirsiniz");
                } 
                
                Console.WriteLine("Öğrencinin ismini giriniz");
                ogrencilerIsım.Add(Console.ReadLine());

                Console.WriteLine("Öğrenci no giriniz");
                string ogrno = Console.ReadLine();
                ogrencilerNo.Add(ogrno);



                Console.WriteLine("Öğrencinin telefon numarasını giriniz");
                string telNo =Console.ReadLine();
                ogrencilerTelNo.Add(telNo);

                Console.WriteLine("Öğrencinin mail adresini giriniz");
                string ogrmail=Console.ReadLine();  
                ogrencilerMail.Add(ogrmail);


                Console.WriteLine("Eklemek istediğin öğrenci var mı? e/h");
                cevap = Console.ReadLine(); 
            }
            else
            {
                for (int i = 0; i < ogrencilerIsım.Count; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine ();    

        }
    }
}