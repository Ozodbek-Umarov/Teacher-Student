using _14_dars._OOP.Interfaces;
using _14_dars._OOP.Models;

namespace _14_dars._OOP.Services;
public class StudentService(IScience scienceService)
    : IStudent
{
    private readonly IScience scienceService = scienceService;
    private Student[] students = new Student[0];

    public void AddNewStudent()
    {
        Console.Clear();
        Console.WriteLine("Yoshini kiriting:");
        byte age = byte.Parse(Console.ReadLine());

        if (age < 18)
        {
            throw new CustomException("Talaba yoshi 18 dan katta bo'lishi kerak!");
        }

        Console.WriteLine("Jinsini tanlang:");
        Console.WriteLine("1. Erkak\n2. Ayol");
        int g = int.Parse(Console.ReadLine());
        Gender gender = (Gender)g;

        Console.WriteLine("Millatini kiriting:");
        string nation = Console.ReadLine();

        Console.WriteLine("Ism familiya kiriting:");
        string fullName = Console.ReadLine();
        if (fullName == "")
        {
            throw new CustomException("Ism familiya bo'sh bo'lmasligi kerak!");
        }
        Console.WriteLine("OTM nomini kiriting:");
        string otm = Console.ReadLine();
        if (otm == "")
        {
            throw new CustomException("OTM nomi bo'sh bo'lmasligi kerak!");
        }
        Console.Clear();
        Console.WriteLine("Fanlar nomerlarini tanlang");
        scienceService.PrintAllSciences();
        string[] input = Console.ReadLine().Split();
        int[] scienceIds = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            scienceIds[i] = int.Parse(input[i]) - 1;
        }
        Science[] studentTanlaganFanlari = new Science[scienceIds.Length];
        for (int i = 0; i < scienceIds.Length; i++)
        {
            studentTanlaganFanlari[i] = scienceService.GetScienceById(scienceIds[i]);
        }

        Student student = new Student(fullName, 
                                      otm, 
                                      age,
                                      gender,
                                      nation,
                                      studentTanlaganFanlari);

        Array.Resize(ref students, students.Length + 1);
        students[^1] = student;
        Console.WriteLine("Talaba qo'shildi!");
    }

    public void PrintAllStudents()
    {
        Console.Clear();
        Console.WriteLine("Talabalar ro'yxati:");
        foreach (Student student in students)
        {
            student.GetInfo();
        }
    }
}
