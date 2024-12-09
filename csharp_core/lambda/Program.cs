using System.Runtime.CompilerServices;

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, string> sum = (int a, int b) => (a + b).ToString();
            //var printUpper = (string s) => Console.WriteLine(s.ToUpper());

            //var t = object (int a, int b) => a > b ? 0 : "A";
            //Console.WriteLine(t(1,2));
            //Console.WriteLine(t(2, 1));

            //Console.WriteLine(sum(3, 5));

            //printUpper("Skipped loading symbols.Module is optimized and the debugger");

            //int A = 100;
            //int B = 200;

            //Call((a, b) => a + b, A, B);
            //Call((a, b) => a * b, A, B);
            //Call((a, b) => a * b * 100, A, B);

            int[] arr = [111, 2424, 5356, 111, 434, 222, 424242, 3687];

            Print((x) => x % 2 == 0, arr);
        }

        static void Print(Func<int, bool> f, int[] arr)
        {
            foreach (int i in arr)
            {
                if (f(i))
                {
                    Console.WriteLine($"{i}   ");
                }
            }
        }

        static void Call(Func<int, int, int> f, int a, int b)
        {
            Console.WriteLine(f(a, b));
        }
    }
}
