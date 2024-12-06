namespace p3Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //f();
            //g();
            jaggedArray2();
        }


        static void f()
        {
            int[] arrays = [1, 2, 3, 4, 5];

            Console.WriteLine($"length: {arrays.Length}");

            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(arrays[i]);
            }
        }

        static void g()
        {
            int[,] arrays2D =
            {
                {1,2,3,4,4,5,6,7,8,9,10 },
                {1,2,3,4,5,6,7,8,9,10,11 }
            };

            Console.WriteLine(arrays2D[0, 5]);
        }

        static void jaggedArray2()
        {
            int[][] mn = new int[4][];
            mn[0] = new int[4];

            mn[0][0] = 1;

        }
    }
}
