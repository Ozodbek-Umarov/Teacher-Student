using _14_dars._OOP.Interfaces;

namespace _14_dars._OOP.Models;
public record Teacher(string fullName,
                      byte age,
                      Gender gender,
                      string nationality,
                      string Science)
    : Person(age, gender, nationality)
{
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Full name: {fullName}");
        Console.WriteLine($"Fani: {Science}");
        Console.WriteLine();
    }
}
