namespace control_structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}

            //int i = 0;
            //while(i <= 0)
            //{
            //    Console.WriteLine(++i);
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i++);
            //} while (i < 0);


            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            var list = new List<string>();
            foreach (string arg in args)
            {
                list.Add(arg.ToUpper());
            }

            foreach(var s in list)
            {
                Console.WriteLine(s);
            }


        }
    }
}
