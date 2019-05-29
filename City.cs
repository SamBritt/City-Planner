using System;
using System.Collections.Generic;

// Name of the city.
// The mayor of the city.
// Year the city was established.
// A collection of all of the buildings in the city.
// A method to add a building to the city.

namespace Planner
{
    class City
    {
        public City(string name)
        {
            this.name = name;
        }

        public string name { get; set; }
        public string mayor { get; set; }
        public DateTime establishDate { get; set; }

        public List<Building> buildingsList = new List<Building>();

        public void addBuilding(Building building)
        {
            this.buildingsList.Add(building);
        }


    }
}

