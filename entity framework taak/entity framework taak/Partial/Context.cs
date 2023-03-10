
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace entity_framework_taak
{
    class Context : DbContext
    {
        private static Context instance = null;

        private Context(DbContextOptions<Context> options) : base(options) { }

        ~Context()
        {
            Dispose();
        }

        public static Context Get
        {
            get
            {
                if (instance == null)
                {
                    var optionsBuilder = new DbContextOptionsBuilder<Context>();
                    optionsBuilder
                        .UseLazyLoadingProxies()
                        .UseSqlite(@"Data Source=VriendenDB.db;");
                    instance = new Context(optionsBuilder.Options);
                }
                return instance;
            }
        }

        public static void Save()
        {
            instance.SaveChanges();
        }

        public DbSet<Vrienden> Vrienden { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Nerd> Nerd { get; set; }
        
    }
}
