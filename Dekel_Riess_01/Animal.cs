public class Animal
{
    protected string Name;
    protected int Age;
    protected string Species;
    protected bool IsDomestic;

    public Animal(string name, int age, string species, bool isDomestic)
    {
        Name = name;
        Age = age;
        Species = species;
        IsDomestic = isDomestic;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{Name}::???");
    }
}