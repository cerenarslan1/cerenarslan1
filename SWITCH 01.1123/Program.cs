namespace SWITCH_01._1123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch kullanarak mevsimleri yazdıralım.
            //Kullanıcı mevsimi girsin örneğin =yaz çıktı olarak: Haziran Temmuz Ağustos.

            Console.WriteLine("Lütfen Mevsimi Giriniz.");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "ilkbahar":
                    Console.WriteLine("Mart, Nisan,Mayıs");
                    break;
                case "yaz":
                    Console.WriteLine("Haziran, Temmuz, Ağustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Eylül, Ekim, Kasım");
                    break;
                case "kış":
                    Console.WriteLine("Aralık, Ocak, Şubat");
                    break;
                default:
                    Console.WriteLine("Böyle bir mevsim yoktur");
                    break;


            }
            Console.ReadLine();

        }
    }
}