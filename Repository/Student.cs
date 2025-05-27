
namespace Repository
{
    public class Student
    {
        public string Name;

        public string Surname;

        public byte age;
    }

    public Student(string surname, string name, byte age)

        {
            Name = name;
            Surname = surname;
            age = age;

            Console.WriteLine($"Name:{name}, Surname:{surname}, Age:{age}");

        }


        void Show()
        {
            Student student = new Student("John", 20);
        }

    }
