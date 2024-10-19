using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class FloweringPlant : Plant
{
    private string color;

    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }

    public FloweringPlant(int id, string name, double humidityLevel, double fertilityLevel, string color) : base(id, name, "flower", humidityLevel, fertilityLevel)
    {
    }

    public override string ToString()
    {
        return base.ToString() + $"\nColor: {Color}";
    }
}
