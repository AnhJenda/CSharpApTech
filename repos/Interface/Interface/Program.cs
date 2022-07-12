using System;

public interface IBeverage
{
    int GetServingTemperature(bool includesMilk);
    bool IsFairTrade
    {
        get; set;
    }
}
public class Coffee : IBeverage
{
    private int servingTempWithoutMilk
    {
        get;
        set;
    }
    private int servingTempWithMilk
    {
        get;
        set;
    }
    int IBeverage.GetServingTemperature(bool includesMilk)
    {
        if (includesMilk)
        {
            return servingTempWithMilk;
        }
        else
        {
            return servingTempWithoutMilk;
        }
    }
    bool IBeverage.IsFairTrade { get; set; }
}