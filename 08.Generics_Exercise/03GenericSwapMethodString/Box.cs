using System;
using System.Collections.Generic;
using System.Text;

namespace _03GenericSwapMethodString
{
    public class Box<TItem>
    {
        private List<TItem> boxCollection;

        public Box()
        {
            this.boxCollection = new List<TItem>();
        }        
        public void Add(TItem item)
        {
            boxCollection.Add(item);
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
