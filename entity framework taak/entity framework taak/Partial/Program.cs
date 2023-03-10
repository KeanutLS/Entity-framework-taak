
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace entity_framework_taak
{
    class Program
    {
        static void Main()
        {
            Context.Get.Database.EnsureCreated();

            var menu = new SMUtils.Menu();

            menu.AddOption('1', "Add Nerds", AddNerd);
            menu.AddOption('2', "View Nerds", Vieuwnerds);
            menu.AddOption('3', "Add Group", AddGroup);
            menu.AddOption('4', "View Groups", Vieuwgroups);
            menu.AddOption('5', "Add Friends", AddFriend);
            menu.Start();
        }

        private async static void AddFriend()
        {
            var friend = await VieuwFriends.Create();
            if (friend == null) return;

            Context.Get.Vrienden.Add(friend);

            Caption.Title("Available Groups");
            ListView.Print(await Context.Get.Groups.ToListAsync());

            var GroupId = Ask.Value("Enter Groups ID");
            var group = Context.Get.Groups.Find(GroupId);
            if (group != null)
            {
                group.Vrienden.Add(friend);
            }
            Context.Save();
        }

        private async static void Vieuwgroups()
        {
            await VieuwGroups.List();
        }

        private async static void AddGroup()
        {
            var group = await VieuwGroups.Create();

            if (group != null)
            {
                Context.Get.Groups.Add(group);
                Context.Save();
                Caption.Action($"A new group has been made: { group }");
            }
            else
            {
                Caption.Action("No groups have been added");
            }

        }

        private async static void Vieuwnerds()
        {
            await VieuwNerds.List();
        }

        private static void AddNerd()
        {
            var nerd = VieuwNerds.Create();

            Context.Get.Nerd.Add(nerd);
            Context.Save();
            Caption.Action($"A nerd has been added: {nerd}");
        }
    }
}
