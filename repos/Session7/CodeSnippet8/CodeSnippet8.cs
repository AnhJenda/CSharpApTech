interface IAnimal
{
    void Drink();
}
interface ICarivoruos
{
    void Eat();
}
interface IReptile : IAnimal, ICarivoruos
{
    void Habitat();
}
class Crocodile : IReptile
{
    public void Drink()
    {
        Console.WriteLine("Drinks fresh water.");
    }
    public void Habitat()
    {
        Console.WriteLine("Can stay in water and land");
    }
    public void Eat()
    {
        Console.WriteLine("Eats Flesh");
    }
    static void Main(string[] args)
    {
        Crocodile objCrocodile = new Crocodile();
        Console.WriteLine(objCrocodile.GetType().Name);
        objCrocodile.Drink();
        objCrocodile.Eat();
        objCrocodile.Habitat();
    }
}
