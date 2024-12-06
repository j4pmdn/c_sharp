namespace MyApp.HelloWorld
{
    internal class Program
    {
        int x;

        static void Main(string[] args)
        {

            string s = $"asdasdsad sdgsdg {DateTime.Now} \\";

            Console.WriteLine(s);

            int? x = null;

            Console.WriteLine(x.HasValue.ToString());


            Console.WriteLine("abcdefghijklmnopqrstuvwxyz".ToUpper());

            int n;
            int max = int.MinValue;

            Console.WriteLine("So 1");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.WriteLine("So 2");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.WriteLine("So 3");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.WriteLine("So 4");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.WriteLine("So 5");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.WriteLine("So lon nhat la: " + max.ToString());
        }

        void f()
        {
            x = 10;
        }
    }
}
