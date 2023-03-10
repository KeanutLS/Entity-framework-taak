using System;
using System.Collections.Generic;
using System.Text;

namespace entity_framework_taak
{
    class ListView
    {
        public static void Print(IEnumerable<object> list, string prefix = "")
        {
            foreach (var item in list)
            {
                Console.WriteLine(prefix + item);
            }
        }
    }
}
