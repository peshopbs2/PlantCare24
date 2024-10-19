using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Numerics;


public class Controller
{
    private readonly Dictionary<int, Plant> plants;

    public Controller()
    {
        plants = new Dictionary<int, Plant>();
    }

    public string AddCareItem(List<string> args)
    {
        int id = int.Parse(args[0]);
        string name = args[1];
        string status = args[2];
        if (plants.ContainsKey(id))
        {
            if (status == "true")
            {
                CareItem careItem = new CareItem(name, true);
            }
            else
            {
                CareItem careItem = new CareItem(name, false);
            }

            return $"Created Care {name} for {id}!";
        }
        else
        {
            return "Plant not found!";
        }
    }

    public string AddPlant(List<string> args)
    {
        int id = int.Parse(args[0]);
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];
        if (type == "flower")
        {
            string color = args[5];
            FloweringPlant plant = new FloweringPlant(id, name, humidityLevel, fertilityLevel, color);
            plants.Add(id, plant);
            return $"Created Plant {name} with ID {id}!";
        }
        else
        {
            int height = int.Parse(args[5]);
            TreePlant plant = new TreePlant(id, name, humidityLevel, fertilityLevel, height);
            plants.Add(id, plant);
            return $"Created Plant {name} with ID {id}!";
        }


    }

    public string GetTotalCaresByPlantId(List<string> args)
    {
        int id = int.Parse(Console.ReadLine());
        if (!plants.ContainsKey(id))
        {
            return "Plant not found!";
        }

        var plant = plants[id];
        return $"Total cares for plant {plant.Id}: {plant.TotalCaresDone()}";
    }

    public string WaterPlantById(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string FertilizePlantById(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string GetTallestTree(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

}