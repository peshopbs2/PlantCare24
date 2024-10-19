using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Plant
{
    private int id;

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    private string type;

    public string Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
    }

    private List<CareItem> careItems = new List<CareItem>();

    private double humidityLevel;

    public double HumidityLevel
    {
        get
        {
            return humidityLevel;
        }
        set
        {
            humidityLevel = value;
        }
    }


    private double fertilityLevel;

    public double FertilityLevel
    {
        get
        {
            return fertilityLevel;
        }
        set
        {
            fertilityLevel = value;
        }
    }

    public Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        Id = id;
        Name = name;
        Type = type;
        HumidityLevel = humidityLevel;
        FertilityLevel = fertilityLevel;
    }

    public void AddCareItem(CareItem careItem)
    {
        careItems.Add(careItem);
    }

    public int TotalCaresDone()
    {
        return careItems.Count(item => item.Status);
    }

    public bool Water(double percent)
    {
        if (humidityLevel + percent <= 1)
        {
            humidityLevel += percent;
            return true;    
        }
        else
        {
            return false;
        }
    }

    public bool Fertilize(double percent)
    {
        if (fertilityLevel + percent <= 1)
        {
            fertilityLevel += percent;
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string ToString()
    {
        return $"Id: {Id}\nName: {Name}\nType: {Type}\nHumidity Level: {HumidityLevel:F2}%\nFertility Level: {FertilityLevel:F2}%";
    }
}
