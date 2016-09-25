using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace PhoneBookClient
{
    public class ContactsSearcherForPage
    {
        private ContactsFilter filter;

        private Searcher searcher;
        

        public ContactsSearcherForPage(ContactsFilter filter, Searcher searcher)
        {
            this.filter = filter;
            this.searcher = searcher;
        }

        public IList<ContactViewModel> CurrentPage()
        {
            if(string.IsNullOrEmpty(this.filter.SearchFilter))
            {
                throw new Exception("Пустой фильтр");
            }

            var resultQuery = this.searcher.Contains(this.filter.SearchFilter);

            return this.GetResultFromQuery(resultQuery);
        }
        
        //public IList<ContactViewModel> NextPage()
        //{
        //    this.filter.CurrentPage++;
        //    return this.CurrentPage();
        //}

        //public IList<ContactViewModel> PrevPage()
        //{
        //    if(this.filter.CurrentPage <= 0)
        //    {
        //        throw new Exception("Достигнута первая страница");
        //    }

        //    this.filter.CurrentPage--;
        //    return this.CurrentPage();
        //}

        private IList<ContactViewModel> GetResultFromQuery(IQueryable<Contact> resultQuery)
        {
            if(this.filter.CurrentPage < 0)
            {
                throw new Exception("Первая страница уже была достигнута");
            }

            return resultQuery.OrderBy(e => e.Name).Skip(this.filter.PageSize * this.filter.CurrentPage).Take(this.filter.PageSize).ToList()
                .Select(e => new ContactViewModel(e)).ToList();
        }
    }
}
