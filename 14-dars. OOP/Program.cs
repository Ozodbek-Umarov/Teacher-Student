using _14_dars._OOP;
using _14_dars._OOP.Interfaces;
using _14_dars._OOP.Services;

class Program
{
    static void Main()
    {
        IScience science = new ScienceService();
        IStudent student = new StudentService(science);
        ITeacher teacher = new TeacherService(science);
        
        while (true)
        {
            Console.Clear();
            string raw1 = """
            Buyruq nomerini kiriting:
            1. Fanlar bo'limi
            2. Ustozlar bo'limi
            3. Talabalar bo'limi
            4. Tozalash
            """;
            Console.WriteLine(raw1);

            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            bool kirish = true;
            switch (n)
            {
                case 1:
                    {
                        while (kirish)
                        {
                            string raw = """
                            ==========================================
                            Fanlar bo'limi
                            ==========================================

                            Buyruq nomerini kiriting:
                            1. Yangi fan qo'shish
                            2. Barcha fanlarni ko'rsatish
                            3. Tozalash
                            4. Chiqish
                            """;
                            Console.WriteLine(raw);

                            int n1 = int.Parse(Console.ReadLine());
                            switch (n1)
                            {
                                case 1: science.AddNewScience(); break;
                                case 2: science.PrintAllSciences(); break;
                                case 3: Console.Clear(); break;
                                case 4: kirish = false; break;
                                default: break;
                            }
                        }

                    } break;
                case 2:
                    {
                        while (kirish)
                        {
                            string raw = """
                            ==========================================
                            Ustozlar bo'limi
                            ==========================================

                            Buyruq nomerini kiriting:
                            1. Yangi Ustoz qo'shish
                            2. Barcha ustozlarni ko'rsatish
                            3. Tozalash
                            4. Chiqish
                            """;
                            Console.WriteLine(raw);

                            int n1 = int.Parse(Console.ReadLine());
                            switch (n1)
                            {
                                case 1:
                                    {
                                        try
                                        {
                                            teacher.AddNewTeacher();
                                        }
                                        catch (CustomException e)
                                        {
                                            Console.WriteLine(e.Message);
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Qandaydir xatolik sodir bo'ldi");
                                        }
                                    }
                                    break;
                                case 2: teacher.PrintAllTeachers(); break;
                                case 3: Console.Clear(); break;
                                case 4: kirish = false; break;
                                default: break;
                            }
                        }

                    } break;
                case 3:
                    {
                        while (kirish)
                        {
                            string raw = """
                            ==========================================
                            Talabalar bo'limi
                            ==========================================

                            Buyruq nomerini kiriting:
                            1. Yangi talaba qo'shish
                            2. Barcha talabalarni ko'rsatish
                            3. Tozalash
                            4. Chiqish
                            """;
                            Console.WriteLine(raw);

                            int n1 = int.Parse(Console.ReadLine());
                            switch (n1)
                            {
                                case 1:
                                    {
                                        try
                                        {
                                            student.AddNewStudent();
                                        }
                                        catch (CustomException e)
                                        {
                                            Console.WriteLine(e.Message);
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Qandaydir xatolik sodir bo'ldi");
                                        }
                                    }
                                    break;
                                case 2: student.PrintAllStudents(); break;
                                case 3: Console.Clear(); break;
                                case 4: kirish = false; break;
                                default: break;
                            }
                        }

                    }
                    break;
            }
        }

    }
}