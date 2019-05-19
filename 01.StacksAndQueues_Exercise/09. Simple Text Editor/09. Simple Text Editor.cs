namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            Stack<string> stackOFText = new Stack<string>();
            StringBuilder text = new StringBuilder();
            int counts = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < counts; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commands = input[0];
                if (commands == "1")
                {
                    stackOFText.Push(text.ToString());
                    text.Append(input[1]);
                }
                else if (commands == "2")
                {
                    //2 3
                    int index = int.Parse(input[1]);
                    stackOFText.Push(text.ToString()); //asdasdas
                    text = text.Remove(text.Length - index, index);
                }
                else if (commands == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (commands == "4")
                {
                    if (stackOFText.Count>0)
                    {
                        text.Clear();
                        text.Append(stackOFText.Pop());
                    }                    
                }
            }
        }
    }
}
