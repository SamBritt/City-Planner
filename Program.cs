using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Building> city = new List<Building>();
            City city = new City("Nashville");

            Building stateCapitol = new Building("615 America Way");
            Building walmart = new Building("615 Strongarm Court");
            Building amazonHub = new Building("615 SellYourSoul Plaza");
            Building marathonMusicWorks = new Building("2344 MMW Place");

            stateCapitol.Width = 2500;
            walmart.Width = 2000;
            amazonHub.Width = 8500;
            marathonMusicWorks.Width = 1300;

            stateCapitol.Depth = 1000;
            walmart.Depth = 1000;
            amazonHub.Depth = 6000;
            marathonMusicWorks.Depth = 800;

            stateCapitol.Stories = 4;
            walmart.Stories = 1;
            amazonHub.Stories = 12;
            marathonMusicWorks.Stories = 3;

            stateCapitol.Construct();
            walmart.Construct();
            amazonHub.Construct();
            marathonMusicWorks.Construct();

            stateCapitol.Purchase("Megan Barry");
            walmart.Purchase("John Hoogman");
            amazonHub.Purchase("Jeff Bezos");
            marathonMusicWorks.Purchase("Steel Panther");

            city.addBuilding(walmart);
            city.addBuilding(stateCapitol);
            city.addBuilding(marathonMusicWorks);
            city.addBuilding(amazonHub);

            foreach(Building building in city.buildingsList){
                Console.WriteLine(building.getAddress());
                Console.WriteLine("-------");
                Console.WriteLine($"Designed by: {building.getDesigner()}");
                Console.WriteLine($"Constructed on: {building.getBuildDate()}");
                Console.WriteLine($"Owned by: {building.getOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space");
                Console.WriteLine("-------***--------");
            }

            // city.Add(stateCapitol);
            // city.Add(walmart);
            // city.Add(amazonHub);
            // city.Add(marathonMusicWorks);

            // foreach(Building building in city){
            //     Console.WriteLine(building.getAddress());
            //     Console.WriteLine("-------");
            //     Console.WriteLine($"Designed by: {building.getDesigner()}");
            //     Console.WriteLine($"Constructed on: {building.getBuildDate()}");
            //     Console.WriteLine($"Owned by: {building.getOwner()}");
            //     Console.WriteLine($"{building.Volume} cubic meters of space");
            //     Console.WriteLine("-------***--------");
            // }
            
            Console.WriteLine("Hello World!");
        }
    }
}
