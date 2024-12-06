namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            int k;
            var arr = new int[10];
            for (k = 0; k < arr.Length; k++)
            {
                arr[k] = rand.Next() % 1000;
            }

            foreach (var n in arr)
            {
                Console.Write($"{n}\t");
            }

            Console.WriteLine();

            //sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //for(int j = arr.Length - 1; j > i; j--)
                for(int j = i + 1;  j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var n in arr)
            {
                Console.Write($"{n}\t");
            }
        }
    }
}
