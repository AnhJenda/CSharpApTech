interface ITerrestrialAnimal
{
    string Eat();
}
interface IMarineAnimal
{
    string Swim();
}
class Crocodile : ITerrestrialAnimal, IMarineAnimal
{
    string ITerrestrialAnimal.Eat()
    {
        string terCroc = "Ca Sau an ca loai khac";
        return terCroc;
    }
    string IMarineAnimal.Eat()
    {
        string marCroc = "Ca Sau an ca";
        return marCroc;
    }

    public string EatTerrestrial()
    {
        ITerrestrialAnimal objTerAnimal;
        objTerAnimal = this;
        return objTerAnimal.Eat();
    }
    public string EatMarine()
    {
        IMarineAnimal objMarAnimal;
        objMarAnimal = this;
        return objMarAnimal.Eat();
    }
    public static void Main(string[] args)
    {
        Crocodile objCrocodile = new Crocodile();
        string terCroc = objCrocodile.EatTerrestrial();
        Console.WriteLine(terCroc);
        string marCroc = objCrocodile.EatMarine();
        Console.WriteLine(marCroc);
    }
}

