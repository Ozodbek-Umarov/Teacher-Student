namespace _14_dars._OOP.Models;
public abstract record Person(byte age,
                              Gender gender,
                              string nationality )
{
    public virtual void GetInfo()
    {
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Nation: {nationality}");
    }
}

public enum Gender
{
    Male = 1,
    Female
}