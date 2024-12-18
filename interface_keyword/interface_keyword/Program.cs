namespace interface_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DatabaseReadable();
            Run(reader);
        }

        static void Run(IDoubleReadable reader)
        {
            reader.WriteName();

            IReadable.WriteName(reader);

            Console.WriteLine(reader.Name);

            int n = reader.ReadInt();

            string s = reader.ReadString();

            Console.WriteLine($"int: {n}, string: {s}");
        }
    }
}
