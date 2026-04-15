namespace Dekel_Riess_01;
class Program
{
	static void Main(string[] args)
	{
		Animal dog = new Dog("Moshe", 10, true);
		Animal cat = new Cat("Fluffy", 4, true);
		Animal parrot1 = new Parrot("Polly", 2, true, "Gray");
		Animal parrot2 = new Parrot("Lichie", 5, false, "Green");
		
		dog.DisplayInfo();
		dog.Sound();
		
		cat.DisplayInfo();
		cat.Sound();
		
		parrot1.DisplayInfo();
		parrot1.Sound();
		
		parrot2.DisplayInfo();
		parrot2.Sound();
	}
}