namespace interface_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new ConsoleReadable();

            Console.WriteLine(reader.Name);
            
            Console.Write("Nhap int: ");
            int n = reader.ReadInt();

            Console.Write("Nhap string: ");
            string s = reader.ReadString();

            Console.WriteLine($"int: {n}, string: {s}");
        }
    }
}
