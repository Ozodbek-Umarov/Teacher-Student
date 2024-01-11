using _14_dars._OOP.Interfaces;
using _14_dars._OOP.Models;
using System;

namespace _14_dars._OOP.Services
{
    public class TeacherService : ITeacher
    {
        private readonly IScience scienceService1;
        private Teacher[] teachers1;

        public TeacherService(IScience scienceService)
        {
            scienceService1 = scienceService;
            teachers1 = new Teacher[0];
        }

        public void AddNewTeacher()
        {
            Console.Clear();
            Console.WriteLine("Yoshini kiriting:");
            byte age = byte.Parse(Console.ReadLine());

            if (age < 20)
            {
                throw new CustomException("Ustoz yoshi 20 dan katta bo'lishi kerak!");
            }

            Console.WriteLine("Jinsini tanlang:");
            Console.WriteLine("1. Erkak\n2. Ayol");
            int g = int.Parse(Console.ReadLine());
            Gender gender = (Gender)g;

            Console.WriteLine("Millatini kiriting:");
            string nation = Console.ReadLine();

            Console.WriteLine("Ism familiyani kiriting:");
            string fullName = Console.ReadLine();
            if (string.IsNullOrEmpty(fullName))
            {
                throw new CustomException("Ism familiya bo'sh bo'lmasligi kerak!");
            }

            Console.Clear();
            Console.WriteLine("Ustoz fanini kiriting:");
            string fan = Console.ReadLine();

            Teacher newTeacher = new Teacher(fullName, age, gender, nation, fan);

            Array.Resize(ref teachers1, teachers1.Length + 1);
            teachers1[^1] = newTeacher;
            Console.WriteLine("Ustoz qo'shildi!");
        }

        public void PrintAllTeachers()
        {
            Console.Clear();
            Console.WriteLine("Ustozlar ro'yxati:");
            foreach (Teacher teacher in teachers1)
            {
                teacher.GetInfo();
            }
        }
    }
}
