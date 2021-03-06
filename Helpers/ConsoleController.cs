﻿using System;

namespace Helpers
{
    public class ConsoleController
    {
        public void FreezeConsole()
        {
            Console.ReadLine();
        }

        public void WriteToConsole(String content)
        {
            Console.WriteLine(content);
        }

        public void ChangeColor(System.ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void ChangeBackground(System.ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
    }
}
