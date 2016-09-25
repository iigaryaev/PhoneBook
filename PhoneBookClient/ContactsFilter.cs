using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookClient
{
    public class ContactsFilter
    {
        public string SearchFilter { get; set; }
        
        public int PageSize { get; private set; }

        public int CurrentPage { get; set; }
        
        public ContactsFilter(int pageSize)
        {
            this.PageSize = pageSize;
        }
    }
}
