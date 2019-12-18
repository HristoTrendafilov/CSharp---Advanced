using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;
        public Cage(string name,int capacity)
        {
            data = new List<Rabbit>();
            Name = name;
            Capacity = capacity;
        }
        public string Name { get; set; }

        public int Capacity { get; set; }
        public int Count => data.Count;
        public void Add(Rabbit rabbit)
        {
            if (Capacity > 0)
            {
                data.Add(rabbit);
                Capacity--;
            }
        }
        public bool RemoveRabbit(string name)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == name)
                {
                    data.Remove(data[i]);
                    return true;
                }
            }
            return false;
        }
        public void RemoveSpecies(string species)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Species == species)
                {
                    data.Remove(data[i]);
                }
            }
        }
        public Rabbit SellRabbit(string name)
        {
            var currRabbit = new Rabbit("", "");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == name)
                {
                    data[i].Available = false;
                    currRabbit = data[i];
                }
            }
            return currRabbit;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var rabbitsBySpecies = new Rabbit[Capacity];
            var counter = 0;
           
            for (int i=0; i<data.Count;i++)
            {
                if (data[i].Species == species)
                {
                    data[i].Available = false;
                    rabbitsBySpecies[counter] = data[i];
                    counter++;
                }
            }
            return rabbitsBySpecies = rabbitsBySpecies.Where(c => c != null).ToArray();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");
            foreach (var rabbit in data)
            {
                if (rabbit.Available == true)
                {
                    sb.AppendLine(rabbit.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
