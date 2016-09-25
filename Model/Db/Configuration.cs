using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Configuration : DbMigrationsConfiguration<PhoneBookDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(PhoneBookDb db)
        {
            db.Database.ExecuteSqlCommand(@"if (object_id('DF_Contact_IsActual') is null)
	alter table Contact add constraint DF_Contact_IsActual  default(1) for IsActual");

            db.Database.ExecuteSqlCommand(@"if (object_id('DF_Contact_CreatedUtc') is null)
	alter table Contact add constraint DF_Contact_CreatedUtc  default(getutcdate()) for CreatedUtc");
        }
    }
}
