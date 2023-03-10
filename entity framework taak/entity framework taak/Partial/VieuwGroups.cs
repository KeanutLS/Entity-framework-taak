
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_taak
{
    class VieuwGroups
    {
        public static async Task<Group> Create()
        {
            Caption.Title("Add Group");
            List<Nerd> Nerds = await Context.Get.Nerd.ToListAsync();

            if (Nerds.Count == 0)
            {
                Console.WriteLine("You need a nerd friend to start a group");
                return null;
            }

            ListView.Print(Nerds);

            var group = new Group();
            var NerdID = Ask.Value("Group ID");
            group.Nerd = Context.Get.Nerd.Find(NerdID);
            group.GroepsNaam = Ask.String("Name");

            return group;
        }

        public static async Task List()
        {
            Caption.Title("All Groups");
            List<Group> groups = await Context.Get.Groups.ToListAsync();
            if (groups.Count == 0)
            {
                Console.WriteLine("No groups have been Found");
                return;
            }

            groups.ForEach(group =>
            {
                Console.WriteLine(group);
                Console.WriteLine($" => owned by a nerd who needs friends called {group.Nerd.Naam}");
                Console.WriteLine($" => has {group.Vrienden.Count} friends");

                ListView.Print(group.Vrienden, "    => ");
                Console.WriteLine();
            });
        }
    }
}
