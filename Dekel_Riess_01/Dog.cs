namespace Dekel_Riess_01;

class Dog : Animal
{
    public Dog(string name, int age, bool isDomestic) : base(name, age, "Dog", isDomestic)
    {
        
    }
    public override void Sound()
    {
        Console.WriteLine($"{Name}::Bark");
    }
}