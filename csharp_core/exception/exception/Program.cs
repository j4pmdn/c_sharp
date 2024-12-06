namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());
                    double x = 10 / n;
                    Console.WriteLine(x);

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Loi chia 0");
                    throw;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ban phai nhap vao 1 so nguyen");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Console.WriteLine("FINALLY");
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
