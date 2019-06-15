namespace CustomStructure
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack st = new CustomStack();

            st.Push(6);
            st.Push(8);
            st.Push(78);
            st.Push(3);
            var x = st.Pop();
            st.Push(777);
            st.Push(123);
            x = st.Peek();

            st.ForEach(Console.WriteLine);

        }
    }
}
