using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_taak
{
    public class Group
    {
        public int Id { get; set; }
        public string GroepsNaam { get; set; }
        public virtual Nerd Nerd { get; set; }
        public virtual IList<Vrienden> Vrienden { get; set; } = new List<Vrienden>();


        public override string ToString()
        {
            return $"groep {Id}: groepsnaam: {GroepsNaam}";
        }
    }

}
