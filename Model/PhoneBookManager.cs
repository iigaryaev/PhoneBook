using Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PhoneBookManager
    {
        private readonly PhoneBookDb db;

        public PhoneBookManager()
        {
            this.db = new PhoneBookDb();
        }

        public PhoneBookManager(PhoneBookDb db)
        {
            this.db = db;
        }

        public Contact AddIfNotExists(string name, string phone)
        {
            if(string.IsNullOrEmpty(phone))
            {
                throw new PhoneBookManagerException("Телефон не может быть пустым");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new PhoneBookManagerException("Имя контакта не может быть пустым");
            }

            var existingContact = this.db.Contacts.FirstOrDefault(e => e.Name == name && e.Phone == phone && e.IsActual);

            if(existingContact != null)
            {
                return existingContact;
            }
            else
            {
                var contact = new Contact(name, phone);
                this.db.Entry(contact).State = System.Data.Entity.EntityState.Added;
                this.db.SaveChanges();

                return contact;
            }
        }

        public Contact Update(Contact contact)
        {
            if(!this.db.Contacts.Any(e => e.Id == contact.Id && e.IsActual))
            {
                throw new PhoneBookManagerException(string.Format("Не найдены контакт Id={0}.", contact.Id));
            }

            contact.IsActual = false;
            this.db.Contacts.Attach(contact);
            this.db.Entry(contact).Property(e => e.IsActual).IsModified = true;
            this.db.SaveChanges();

            return this.AddIfNotExists(contact.Name, contact.Phone);
        }

        public void Delete(Contact contact)
        {
            if(contact == null)
            {
                throw new PhoneBookManagerException("Не получен контакт для удаления.");
            }

            contact.IsActual = false;

            this.db.Entry(contact).Property(e => e.IsActual).IsModified = true;

            this.db.SaveChanges();
        }

        public void Delete(int contactId)
        {
            var contact = this.db.Contacts.First(e => e.Id == contactId);
            if (contact == null)
            {
                throw new PhoneBookManagerException("Не найден контакт для удаления.");
            }

            contact.IsActual = false;

            this.db.Entry(contact).Property(e => e.IsActual).IsModified = true;

            this.db.SaveChanges();
        }

        public int DeleteAllContactPhones(string name)
        {
            var contacts = this.db.Contacts.Where(e => e.Name == name && e.IsActual).ToList();

            if (!contacts.Any())
            {
                throw new PhoneBookManagerException(string.Format("Не найдены контакты [{0}].", name));
            }

            foreach(var contact in contacts)
            {
                contact.IsActual = false;
                this.db.Entry(contact).Property(e => e.IsActual).IsModified = true;
            }

            this.db.SaveChanges();

            return contacts.Count;
        }
    }
}
