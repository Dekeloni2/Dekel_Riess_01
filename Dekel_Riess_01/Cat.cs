namespace Dekel_Riess_01;

public class Cat : Animal
{
    public Cat(string name, int age, bool isDomestic) : base(name, age, "Cat", isDomestic)
    {
        
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name}::Meow");
    }
}