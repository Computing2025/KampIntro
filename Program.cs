namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.45;
            double dolarBugun = 7.72;

            if(dolarBugun > dolarDun)
            {
                Console.WriteLine("Yukarı ok göster..");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Aşağı ok göster.");
            } 
            else 
            {
                Console.WriteLine("Yatay çizgi gösterir.");
            }
        }
    }
}


