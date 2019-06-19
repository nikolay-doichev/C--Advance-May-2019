using System;
using System.Collections.Generic;
using System.Text;

namespace _06GenericCountMethodDouble
{
    public class Box<TItem> where TItem : IComparable<TItem>
    {
        private List<TItem> boxCollection;
        public int CountGreater { get;private set; }
        public Box()
        {
            this.boxCollection = new List<TItem>();
        }        
        public void Add(TItem item)
        {
            boxCollection.Add(item);
        } 
        public void Campare(TItem item)
        {
            foreach (var currentItem in this.boxCollection)
            {
                if (currentItem.CompareTo(item) > 0)
                {
                    CountGreater++;
                }
            }
        }
        public void Swap(int firstIndex, int secondIndex)
        {            
            var temp = boxCollection[firstIndex];
            boxCollection[firstIndex] = boxCollection[secondIndex];
            boxCollection[secondIndex] = temp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var text in this.boxCollection)
            {
                sb.AppendLine($"{text.GetType().FullName}: {text}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
