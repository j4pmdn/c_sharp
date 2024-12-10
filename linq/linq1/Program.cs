namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = GetIntNumber();

            Print(dataSource);


            // query syntax
            //var ns = from n in dataSource
            //         where GreaterThan0(n) && n % 2 != 0
            //         select n;

            // method syntax
             var ns = dataSource.Where(n => GreaterThan0(n) && n % 2 != 0);

            Print(ns);
            Console.WriteLine("-------------------------");
            Console.WriteLine(ns.Count());
        }

        static bool GreaterThan0(int n)
        {
            return (n > 0);
        }

        static IEnumerable<int> GetIntNumber()
        {
            var ns = new int[] { 1, 26, 36363, 5252, 622, 6664, 0 , -222, 42249, 3466, 113156, -2525};

            return ns;
        }

        static void Print(IEnumerable<int> values)
        {
            Console.WriteLine("-------------------------");
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
