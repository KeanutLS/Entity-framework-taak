using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_taak
{
    public class Vrienden
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Leeftijd { get; set; }
        public string Hobby { get; set; }

        public override string ToString()
        {
            return $"Vriend {Id}: {Name} is {Leeftijd} jaar oud en doet {Hobby} als hobby";
        }
    }
}
