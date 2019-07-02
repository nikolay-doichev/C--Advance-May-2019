using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        //•	Name: string
        //•	Capacity: int

        public SpaceStation(string name, int capacity)
        {
            this.astronauts = new List<Astronaut>();

            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.astronauts.Count;

        public void Add(Astronaut astronaut)
        {
            if (this.Capacity > this.astronauts.Count)
            {
                this.astronauts.Add(astronaut);
            }            
        }
        public bool Remove(string name)
        {
            Astronaut targetAstronaut = astronauts.FirstOrDefault(a => a.Name == name);

            bool exist = false;

            if (astronauts.Contains(targetAstronaut))
            {
                exist = true;
            }

            return exist;
        }
        public Astronaut GetOldestAstronaut()
        {
            return this.astronauts.OrderByDescending(a => a.Age).First();
        }
        public Astronaut GetAstronaut(string name)
        {
            Astronaut searchedAstronaut = astronauts.FirstOrDefault(a => a.Name == name);

            return searchedAstronaut;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var astronaut in this.astronauts)
            {
                sb.AppendLine(astronaut.ToString());
            }
            

            return $"Astronauts working at Space Station {this.Name}:" + Environment.NewLine + sb.ToString().TrimEnd();
        }
    }
}
