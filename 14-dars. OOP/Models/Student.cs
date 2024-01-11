namespace _14_dars._OOP.Models;
public record Student(string fullName, 
                      string otm, 
                      byte age, 
                      Gender gender, 
                      string nationality, 
                      params Science[] Sciences) 
    : Person(age, gender, nationality)
{
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Full name: {fullName}");
        Console.WriteLine($"Otm: {otm}");
        string sciences = "";
        foreach (var item in Sciences)
        {
            sciences += item.name + ", ";
        }
        Console.WriteLine($"Sciences: {sciences}");
    }
}
