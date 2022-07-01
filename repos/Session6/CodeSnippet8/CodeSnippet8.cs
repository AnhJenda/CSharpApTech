class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal eats something.");
    }
    protected void DoSomething()
    {
        Console.WriteLine("Animal does something.");
    }
}
class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat loves to eat mouse");
    }
    static void Main(string[] args)
    {
        Cat objCat = new Cat();
        objCat.Eat();
    }
}
