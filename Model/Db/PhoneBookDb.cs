using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PhoneBookDb : DbContext
    {
        public PhoneBookDb() : base("PhoneBook")
        {
            //Database.SetInitializer<PhoneBookDb>(null);
            Database.SetInitializer<PhoneBookDb>(new MigrateDatabaseToLatestVersion<PhoneBookDb, Configuration>());
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        //public DbSet<ContactType> ContactTypes { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}
