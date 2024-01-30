
namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new()
            {
                Konusu = "Yapay Zeka",
                KursAdi = "Python ile Yapay Zeka",
                IzlenmeOrani = 25
            };

            Kurs kurs2 = new()
            {
                Konusu = "ASP.NET Core",
                KursAdi = "Web App Geliştirme",
                IzlenmeOrani = 12
            };

           Kurs[] kurslar = [kurs1, kurs2];

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Konusu);
                Console.WriteLine("İzlenme oranı: " + kurs.IzlenmeOrani);
                Console.WriteLine("------------------");
            }
        }
    }

    class Kurs
    {
        public string? KursAdi { get; set; }
        public string? Konusu { get; set; }
        public int IzlenmeOrani { get; set; }   

    }
}


