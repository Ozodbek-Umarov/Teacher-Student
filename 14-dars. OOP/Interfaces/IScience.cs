using _14_dars._OOP.Models;

namespace _14_dars._OOP.Interfaces;
public interface IScience
{
    void PrintAllSciences();
    void AddNewScience();

    Science GetScienceById(int index);
}