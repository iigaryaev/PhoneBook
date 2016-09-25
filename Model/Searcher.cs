using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Searcher
    {
        protected readonly PhoneBookDb db;

        public Searcher()
        {
            this.db = new PhoneBookDb();
        }

        public Searcher(PhoneBookDb db)
        {
            this.db = db;
        }

        public IQueryable<Contact> Contains(string substring)
        {
            return this.db.Contacts.Where(e => e.Name.Contains(substring) && e.IsActual);
        }
    }
}
