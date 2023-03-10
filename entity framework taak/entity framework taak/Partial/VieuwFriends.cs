
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_taak
{
    class VieuwFriends
    {
        public static async Task<Vrienden> Create()
        {
            Caption.Title("Add Ant");
            List<Group> group = await Context.Get.Groups.ToListAsync();
            if (group.Count == 0)
            {
                Caption.Error("You can't add friends to your group");
                return null;
            }

            var Vriend = new Vrienden();
            Console.WriteLine("Add a friend");
            Vriend.Name = Ask.String("Name");
            Vriend.Leeftijd = Ask.Value("Age?");
            Vriend.Hobby = Ask.String("the hobby of your friend");

            return Vriend;
        }
    }
}
