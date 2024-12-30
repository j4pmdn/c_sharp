namespace AttributeCSharp
{
    [DBMethod("ABC")]
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMethodAttr = (DBMethodAttribute)Attribute.GetCustomAttribute(typeof(Class1).GetMethod("PrintHelloWorld1"), typeof(DBMethodAttribute));
            Console.WriteLine(dbMethodAttr.Message);
            

            dbMethodAttr = (DBMethodAttribute)Attribute.GetCustomAttribute(typeof(Class1).GetMethod("PrintHelloWorld2"), typeof(DBMethodAttribute));
            Console.WriteLine(dbMethodAttr.Message);
        }
    }
}