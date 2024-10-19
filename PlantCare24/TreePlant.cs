using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TreePlant : Plant
{
    private int height;

    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }

    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel, int height)
        : base(id, name, "tree", humidityLevel, fertilityLevel)
    {
        
    }

    public override string ToString()
    {
        return base.ToString() + $"\nHeight: {Height}";
    }
}

