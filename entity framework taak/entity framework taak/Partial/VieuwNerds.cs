using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_taak
{
    class VieuwNerds
    {
        public static Nerd Create()
        {
            Caption.Title("Add Nerd");
            var nerd = new Nerd();
            nerd.Naam = Ask.String("Name");
            nerd.Leeftijd = Ask.Value("Age");
            nerd.Hobby = Ask.String("hobby?");

            return nerd;
        }

        public async static Task List()
        {
            Caption.Title("View All Nerds that you made");
            List<Nerd> nerds = await Context.Get.Nerd.ToListAsync();

            if (nerds.Count == 0)
            {
                Console.WriteLine("There are no nerds in your group. weird");
                return;
            }

            ListView.Print(nerds);
        }
    }
}
