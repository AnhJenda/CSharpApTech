class Animal
{
    protected string Food;
    protected string Activity;
}
class Cat : Animal
{
    static void Main(string[] args)
    {
        Cat objCat = new Cat();

        objCat.Food = "Mouse";
        objCat.Activity = "laze around";

        Console.WriteLine(objCat.Food);
        Console.WriteLine(objCat.Activity);
    }
}
