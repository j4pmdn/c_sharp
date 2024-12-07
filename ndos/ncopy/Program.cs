namespace ncopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = @"C:\test\testcopy.txt";
            var dest = @"C:\test\testcopy-copy.txt";

            var buffer = new byte[1024];
            
            using var inStream = File.OpenRead(source); // khi dùng từ khóa using thì nó tự đóng kết nối -> inStream.Close();
            using var outStream = File.OpenWrite(dest);

            int n = inStream.Read(buffer, 0, buffer.Length);
            while (n > 0)
            {
                Console.WriteLine(n.ToString());

                outStream.Write(buffer, 0, n);

                n = inStream.Read(buffer, 0, buffer.Length);
            }
           
        }
    }
}
