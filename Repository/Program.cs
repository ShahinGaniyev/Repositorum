////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");


//using Repository;

//Student student = new("Aliyev", "Kamran", 21);


//Book book = new Book();


//using Repository.NewFolder;
//Print();
//GC.Collect();

//void Print()
//{
//    Car car = new("Toyota", "Baku", 9999);

//}
using Repository;


try
{
    StudentGrade student = new StudentGrade();
    student.Name = "Alicja";
    student.Grade = 95;
    Console.WriteLine($"Name:{student.Name}, Grade:{student.Grade}");

    // ashagi hisseni chatgpt verdi

    student.Grade = -10;
}
catch (ArgumentOutOfRangeException ex)
{
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}