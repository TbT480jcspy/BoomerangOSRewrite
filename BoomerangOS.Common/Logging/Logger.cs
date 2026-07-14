using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.Common.Logging
{
    public static class Logger
    {
        public static void Info(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}] [INFO] {message}");
        }

        public static void Error(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}] [ERROR] {message}");
        }
    }
}
