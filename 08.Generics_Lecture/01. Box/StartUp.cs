﻿namespace BoxOfT
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var box = new Box<int>();

            box.Add(4);
        }
    }
}
