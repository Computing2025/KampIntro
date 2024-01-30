namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new()
            {
                Id = 1,
                Name = "Elma",
                Price = 25,
                Description = "Amasya elması."
            };

            Product urun2 = new()
            {
                Id = 2,
                Name = "Karpuz",
                Price = 30,
                Description = "Diyarbakır karpuzu"
            };

            Product urun3 = new()
            {
                Id = 3,
                Name = "Mandalina",
                Price = 25,
                Description = "Bodrum mandalinası"
            };
             
            Product[] urunler = [urun1, urun2, urun3];

            SepetManager sepetManager = new();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);



            /*
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Id+" "+urun.Name);
                Console.WriteLine(urun.Price+" "+urun.Description);
                Console.WriteLine("----------------------");
            }
            */
        } // main
    }
}
