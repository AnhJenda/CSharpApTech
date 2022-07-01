interface ITerrestrialAnimal
{
    void Eat();
}
interface IMarineAnimal
{
    void Swim();
}
class Crocodile : ITerrestrialAnimal, IMarineAnimal
{
    public void Eat()
    {
        Console.WriteLine("The Ca Sau eat flesh");
    }
    public void Swim()
    {
        Console.WriteLine("The Ca Sau co the boi nhanh gap 4 lan vdv boi loi");
    }
    static void Main(string[] args)
    {
        Crocodile objCrocodile = new Crocodile();
        objCrocodile.Swim();
        objCrocodile.Eat();
    }
}
