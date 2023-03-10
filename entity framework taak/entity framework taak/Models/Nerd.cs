using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_taak
{
    public class Nerd
    {
        public int Id { get; set; }
        public int Leeftijd { get; set; }
        public string Naam { get; set; }
        public string Hobby { get; set; }


        public override string ToString()
        {
            return $"Nerd {Id}: {Naam}, leeftijd: {Leeftijd}, {Naam} zijn hobby is: {Hobby}";
        }
    }
}
