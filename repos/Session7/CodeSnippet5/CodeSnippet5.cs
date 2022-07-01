interface IAnimal
{
    void Habitat();
}

class Dog : IAnimal
{
    public void Habitat()
    {
        Console.WriteLine("Can be houses with human being.");
    }
    static void Main(string[] args)
    {
        Dog objDog = new Dog();
        Console.WriteLine(objDog.GetType().Name);
        objDog.Habitat();
    }
}
