namespace enum_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region enum nedir?
            //enum(sıralı numalandırma), bir türün belirli sabit değerlerini temsil etmek için kullanılır. Enum,bir veri türüdür ve sabit değerlere anlamlı isimler atamak için kullanılır. Enumumlar genellikle bir türün olası değerlerini açıklamak, kodu daha anlaşılır ve bakımı daha kolay hale getirmek amacıyla kullanılır.
            #endregion
            //renk enum'ı oluşturalım içerisinde kırmızı mavi ve yeşil durumları olsun
            //kullanıcıdan 1,2 veya 3 e basmasını isteyelim
            //eğer kullanıcı 1 e basarsa yazılar yeşile,
            //eğer kullanıcı 2 ye basarsa yazılar maviye,
            //eğer kullanıcı 3 e basarsa konsoldoki yazıları kırmızıya  çevirelim

            Console.WriteLine("lütfen 1-2-3 arasından bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Renk consoleRenk = new Renk();  
            if (sayi == 1)
            {
                consoleRenk = Renk.yesil;
            }
            else if (sayi == 2)
            {
                consoleRenk = Renk.mavi;
            }
            else if (sayi == 3)
            {
                consoleRenk = Renk.kirmizi;
            }
            else 
            {
                Console.WriteLine("hatalı tuşlama yaptınız");
            }
            switch (consoleRenk)
            {
                case Renk.kirmizi:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Renk.mavi:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Renk.yesil:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    break;
            }
            Console.WriteLine(  "renkli metin");



        }
        public enum Renk
        { 
        kirmizi,
        mavi,
        yesil,
        }

    }
}