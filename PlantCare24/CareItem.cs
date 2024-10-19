using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CareItem
{
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

    private bool status;

    public bool Status
    {
        get
        {
            return status;
        }
        set
        {
            status = value;
        }
    }

    public CareItem(string name, bool status)
    {
        Name = name;
        Status = status;
    }

    public override string ToString()
    {
        return $"CareItem {Name}\nStatus: {Status}";
    }
}