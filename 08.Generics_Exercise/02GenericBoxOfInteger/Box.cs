using System;
using System.Collections.Generic;
using System.Text;

namespace _02GenericBoxOfInteger
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
