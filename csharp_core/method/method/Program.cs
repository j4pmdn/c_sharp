namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*
            Console.WriteLine("Hello, World!");
            int x = 5; // [1000] = 5
            int y = 10; // [1001] = 10

            // [2000] = [1000]
            // [2001] = [1001]

            DemoParameters(x ,ref y);
            Console.WriteLine($"Main.x = {x}");
            Console.WriteLine($"Main.y = {y}");
            */

            var mc = new MyClass() { M = 100 }; //[1000] = 9000

            Print(mc);
            
            //[2000] = [1000] = 9000
            UpdateMyClass(mc);

            Print(mc);
            int z = Add(10, 20);
        }

        static void Print(MyClass mc) => Console.WriteLine($"mc.M = {mc.M}");

        static int Add(int x, int y) => x + y;

        static void UpdateMyClass(MyClass mc)
        {
            mc.M = 200;
            Print(mc);
        }

        // Pass by value -> chỉ thay đổi giá trị bản sao cho hàm này ko thay đổi giá trị gốc
        // Nếu muốn thay đổi giá trị gốc -> thêm từ khóa ref vào tham số
        //public static int DemoParameters(int x,  // [2000]
        //                                ref int y) // [2001] -> ref [1001]
        //{
        //    Console.WriteLine($"x = {x}");
        //    Console.WriteLine($"y = {y}");

        //    x = 100;
        //    y = 200;

        //    Console.WriteLine($"x = {x}");
        //    Console.WriteLine($"y = {y}");
        //    return x + y;
        //}

        private void LocalMethod()
        {

        }

    }
}
