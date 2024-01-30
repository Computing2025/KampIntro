namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> fruits = new();

            fruits.Add("Apple");
            fruits.Add("Banana");
            Console.WriteLine("Eleman sayısı : " + fruits.Length);

            foreach (var item in fruits.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}



