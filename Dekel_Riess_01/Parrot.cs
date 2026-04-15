namespace Dekel_Riess_01;

public class Parrot : Animal
{
    protected string Color;
    public Parrot(string name, int age, bool isDomestic, string color) : base(name, age, "Parrot", isDomestic)
    {
        Color = color;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Color: {Color}");
    }

    public override void Sound()
    {
        if (CanTalk())
            Console.WriteLine($"{Name}::Hello!");
        else
            Console.WriteLine($"{Name}::Squawk");
    }

    public bool CanTalk()
    {
        return IsDomestic;
    }
}