using System;
using System.Collections.Generic;
using System.Text;

namespace entity_framework_taak
{
    class Caption
    {
        public static void Title(string label)
        {
            Console.WriteLine("**");
            Console.WriteLine($"** {label}");
            Console.WriteLine("**");
            Console.WriteLine("");
        }

        public static void Action(string label)
        {
            Console.WriteLine($" ... {label}");
        }

        public static void Error(string label)
        {
            Console.WriteLine($"!!! {label} !!!");
        }
    }
}
