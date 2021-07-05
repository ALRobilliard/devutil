using System;

namespace DevUtil.Utils
{
    public static class WriteLineColoured
    {
        public static void Write(string message, ConsoleColor? colour = null)
        {
            if (colour.HasValue)
            {
                Console.ForegroundColor = colour.Value;
            }
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}