
namespace linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = GetStudents();
            //Print(students.OrderByDescending(s => s.YoB).OrderBy(s => s.Name));

            foreach(var student in students.Where(s => s.YoB == 2012))
            {
                Console.WriteLine(student.Name); 
            }

            var s = GetStudents().Where(s => s.YoB == 2012).Skip(1).Take(2);
            Print(s);
        }

        static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Print(student);
            }
        }

        private static void Print(Student student)
        {
            Console.WriteLine($"Name: {student.Name}, City: {student.City}, YoB: {student.YoB}");
        }

        // Tất cả các kiểu Collection hoặc Arrays đều implements IEnumerable
        static IEnumerable<Student> GetStudents()
        {
            return new Student[]
            {
                new Student()
                {
                    Name = "Test 2010",
                    City = "HCMC",
                    YoB = 2010
                },
                new Student()
                {
                    Name = "Test 2012-1",
                    City = "HCMC",
                    YoB = 2012
                },
                new Student()
                {
                    Name = "Test 2012",
                    City = "HCMC",
                    YoB = 2012
                },
                new Student()
                {
                    Name = "Test 2012-2",
                    City = "HCMC",
                    YoB = 2012
                },
                new Student()
                {
                    Name = "Test 2011",
                    City = "HCMC",
                    YoB = 2011
                }
            };
        }
    }
}
