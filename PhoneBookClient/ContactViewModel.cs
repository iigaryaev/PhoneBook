using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookClient
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public ContactViewModel()
        {

        }

        public ContactViewModel(Contact contact)
        {
            this.Id = contact.Id;
            this.Name = contact.Name;
            this.Phone = contact.Phone;
        }
    }
}
