using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Quest> QuestAvailables { get; set; }
        public List<Treasure> TreasureAvailables { get; set; }
        public List<MonsterSpawn> MonsterAvailables { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToWest { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToSouth { get; set; }
        public Location() { }
        public Location(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
            QuestAvailables = new List<Quest>();
            TreasureAvailables = new List<Treasure>();
            MonsterAvailables = new List<MonsterSpawn>();
        }

        public void East(Location east) { LocationToEast = east; }
        public void West(Location west) { LocationToWest = west; }
        public void North(Location north) { LocationToNorth = north; }
        public void South(Location south) { LocationToSouth = south; }
    }
}
