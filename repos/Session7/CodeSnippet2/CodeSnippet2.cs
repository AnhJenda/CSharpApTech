abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eat somthing to order survive");
    }
    public abstract void AnimalSound();
}
class Lion : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Lion Roar");
    }
    static void Main(string[] args)
    {
        Lion objLion = new Lion();

        objLion.AnimalSound();
        objLion.Eat();
    }
}
