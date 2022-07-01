using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every animal eats something.");
    }
}
class Mammal : Animal
{
    public void Feature()
    {
        Console.WriteLine("Mammals give birth to young one.");
    }
}
class Dog : Mammal
{
    public void Noise()
    {
        Console.WriteLine("Dong barks");
    }
    static void Main(string[] args)
    {
        Dog objDog = new Dog();

        objDog.Feature();
        objDog.Eat();
        objDog.Noise();
    }
}
