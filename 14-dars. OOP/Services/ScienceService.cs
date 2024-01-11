using _14_dars._OOP.Interfaces;
using _14_dars._OOP.Models;

namespace _14_dars._OOP.Services;
public class ScienceService : IScience
{
    private Science[] sciences = [
            new Science("Matematika", new TimeSpan(15, 0, 0)),
            new Science("Fizika", new TimeSpan(10, 0, 0)),
        ];

    public void AddNewScience()
    {
        Console.Clear();
        Console.WriteLine("Fan nomini kiriting:");
        string name = Console.ReadLine();
        Console.WriteLine("Fan davomiyligini kiriting(soatlarda):");
        int duration = int.Parse(Console.ReadLine());
        TimeSpan timeSpan = new(duration, 0, 0);
        Console.Clear();

        //massiv o'lchamini bittaga oshirish
        Array.Resize(ref sciences, sciences.Length + 1);
        //yangi science obyektini yaratish
        Science newScience = new(name, timeSpan);
        //oxirgi bo'sh elementga tenglash
        sciences[^1] = newScience;
        Console.WriteLine("Fan qo'shildi!");
    }

    public Science GetScienceById(int index)
    {
        return sciences[index];
    }

    public void PrintAllSciences()
    {
        Console.WriteLine("T/R\tFan nomi\tDavomiyligi");
        for (int i = 0; i < sciences.Length; i++)
        {
            Console.WriteLine($"{i+1}.\t{sciences[i].name}\t{sciences[i].duration.ToString()}");    
        }
    }
}
