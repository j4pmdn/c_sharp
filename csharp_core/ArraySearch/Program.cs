namespace ArraySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            var arr = new int[10];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 1000;
            }

            foreach (var n in arr)
            {
                Console.Write($"{n}\t");
            }

            Console.WriteLine();
            Console.Write("Nhap so can tim: ");
            var s = Console.ReadLine();
            int soCanTim = int.Parse(s);

            i = 0;
            while(i < arr.Length && soCanTim != arr[i])
            {
                i++;
            }

            if (i == arr.Length)
            {
                Console.WriteLine("Khong tim thay");
            }
            else {
                Console.WriteLine($"{soCanTim} duoc tim thay tai vi tri {i}");

            }
        }
    }
}
