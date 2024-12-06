namespace ndir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\";
            var dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();

            foreach (var d in directories)
            {
                Console.WriteLine($"{d.LastWriteTime:MM/dd/yyyy} {d.LastWriteTime:HH:mm}    <DIR>    {d.Name}");
            }

            var files = dir.GetFiles();


        }
    }
}
