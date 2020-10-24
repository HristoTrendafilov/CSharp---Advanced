using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.list = new List<T>();
        }
        public List<T> list { get; set; }

        public int CountOfElements(T targetItem)
        {
            int counter = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(targetItem)>0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
        public void AddElements(T value)
        {
            list.Add(value);
        }
        public void SwapElements(int index1, int index2)
        {
            var firstIndex = list[index1];
            var secondIndex = list[index2];

            list[index1] = secondIndex;
            list[index2] = firstIndex;
        }
    }
}
