namespace static_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(AccessCounter.GetInstantce().Inc());
            }

            //Person person = new Person() { Id = 999, Name = "Nam" };

            //person.Print();
            //Console.WriteLine(C.x);
            //var c1 = new C() {};
            //var c2 = new C() {};

            //Console.WriteLine(C.x);

            //C.x = 999;

            //Console.WriteLine(C.x);

            //F1();

            //Console.WriteLine(C.x);

            //C.F();

            //Console.WriteLine(C.x);
            }

            static void Print(Person person)
        {
            Console.WriteLine($"ID: {person.Id}");
            Console.WriteLine($"Name: {person.Name}");
        }

        static void F1()
        {
            C.x = 1234;
        }
    }
}
