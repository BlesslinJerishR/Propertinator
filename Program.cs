using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertinator
{
    class Program
    {

        public class Student
        {
            public int stuId { get; set; }
            public string stuName { get; set; }
            public string stuAddress { get; set; }
            public int stuMarks { get; set; }
            public string stuEmail { get; set; }
        }

        public class Person
        {
            public int personId { get; set; }
            public string personName { get; set; }
            public string personAddress { get; set; }
            public string personEmail { get; set; }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(@"
 +-+ +-+ +-+ +-+ +-+ +-+ +-+
 |C| |a| |n| |a| |r| |y| |s|
 +-+ +-+ +-+ +-+ +-+ +-+ +-+

[ Dev : Blesslin Jerish R | C# .net ]
");
            Console.WriteLine("Student Details\n");
            Console.WriteLine("===================== | Student 1 | ==============================");
            Student objStudent = new Student()
            {
                stuId = 101,
                stuName = "Ram",
                stuAddress = "Tamilnadu",
                stuMarks = 72,
                stuEmail = "ram@seetha.com"

            };

            Console.WriteLine("");

            Console.WriteLine($"Student Id : {objStudent.stuId}" +
                $"\nStudent name : {objStudent.stuName}" +
                $"\nStudent Address : {objStudent.stuAddress}" +
                $"\nStudent mark : {objStudent.stuMarks}" +
                $"\nStudent Email : {objStudent.stuEmail}");

            Console.WriteLine("");

            Console.WriteLine("===================== | Student 2 | ==============================");
            Student objStudent2 = new Student()
            {
                stuId = 102,
                stuName = "Kannan",
                stuAddress = "Karnataka",
                stuMarks = 84,
                stuEmail = "kannan@radhai.com"

            };

            Console.WriteLine("");

            Console.WriteLine($"Student Id : {objStudent2.stuId}" +
                $"\nStudent name : {objStudent2.stuName}" +
                $"\nStudent Address : {objStudent2.stuAddress}" +
                $"\nStudent mark : {objStudent2.stuMarks}" +
                $"\nStudent Email : {objStudent2.stuEmail}");

            Console.WriteLine("");

            Console.WriteLine("===================== | Student 3 | ==============================");
            Student objStudent3 = new Student()
            {
                stuId = 103,
                stuName = "Swetha",
                stuAddress = "TamilNadu",
                stuMarks = 32,
                stuEmail = "swetha@sweety.com"

            };

            Console.WriteLine("");

            Console.WriteLine($"Student Id : {objStudent3.stuId}" +
                $"\nStudent name : {objStudent3.stuName}" +
                $"\nStudent Address : {objStudent3.stuAddress}" +
                $"\nStudent mark : {objStudent3.stuMarks}" +
                $"\nStudent Email : {objStudent3.stuEmail}");

            Console.WriteLine("");
            Console.WriteLine("Person Details\n");
            Console.WriteLine("===================== | Person 1 | ===============");
            Person objPerson1 = new Person()
            {
                personId = 420,
                personName = "Neha",
                personAddress = "Kerala",
                personEmail = "neha@babu.com"

            };

            Console.WriteLine("");
            Console.WriteLine($"Person Id : {objPerson1.personId}" +
                $"\nPerson name : {objPerson1.personName}" +
                $"\nPerson Address : {objPerson1.personAddress}" +
                $"\nPerson Email : {objPerson1.personEmail}");
            Console.WriteLine("");

            Console.WriteLine("===================== | Person 2 | ===============");
            Person objPerson2 = new Person()
            {
                personId = 504,
                personName = "not",
                personAddress = "Kerala",
                personEmail = "server@error.com"

            };
            Console.WriteLine("");
            Console.WriteLine($"Person Id : {objPerson2.personId}" +
                $"\nPerson name : {objPerson2.personName}" +
                $"\nPerson Address : {objPerson2.personAddress}" +
                $"\nPerson Email : {objPerson2.personEmail}");

            Console.WriteLine("");

            Console.WriteLine("===================== | Person 3 | ===============");
            Person objPerson3 = new Person()
            {
                personId = 63,
                personName = "prahana",
                personAddress = "Kerala",
                personEmail = "prahana@gmail.com"

            };
            Console.WriteLine("");
            Console.WriteLine($"Person Id : {objPerson3.personId}" +
                $"\nPerson name : {objPerson3.personName}" +
                $"\nPerson Address : {objPerson3.personAddress}" +
                $"\nPerson Email : {objPerson3.personEmail}");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
