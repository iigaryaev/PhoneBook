using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Linq;
using System.Collections.Generic;

namespace ModelTests
{
    [TestClass]
    public class PhoneBookManagerTests
    {
        private PhoneBookDb db;
        private PhoneBookManager manager;

        private IList<Contact> testContacts = new List<Contact>();

        private readonly string testContactName;

        private readonly string testPhoneFirst;

        public PhoneBookManagerTests()
        {
            this.testContactName = "testContact_" + Guid.NewGuid().ToString();
            this.testPhoneFirst = Guid.NewGuid().ToString().Substring(0, 20);
            
        }

        [TestMethod]
        public void AddContact()
        {
            var contact = this.testContacts.First();

            Assert.AreEqual(1, this.testContacts.Count());
            Assert.AreEqual(testContactName, contact.Name);
            Assert.AreEqual(testPhoneFirst, contact.Phone);
            Assert.IsTrue(contact.IsActual);
        }

        [TestMethod]
        public void UpdateContact()
        {
            var newTestPhone = "112211232";
            var newTestName = "testContact_" + Guid.NewGuid().ToString();

            var contact = this.testContacts.First();
            contact.Phone = newTestPhone;
            contact.Name = newTestName;
            contact = this.manager.Update(contact); 

            Assert.IsTrue(this.db.Contacts.Any(e => e.Name == this.testContactName && e.Phone == this.testPhoneFirst && !e.IsActual));
            Assert.AreEqual(newTestPhone, contact.Phone);
            Assert.AreEqual(newTestName, contact.Name);
            Assert.IsTrue(contact.IsActual);
        }

        [TestMethod]
        public void DeleteContact()
        {
            var contact = this.testContacts.First();
            this.manager.Delete(contact);

            Assert.IsTrue(this.db.Contacts.Any(e => e.Id == contact.Id && !e.IsActual));
        }

        [TestMethod]
        public void DeleteAllContactPhones()
        {
            var newTestPhone = "112211232";
            var contact = this.manager.AddIfNotExists(this.testContactName, newTestPhone);
            this.testContacts.Add(contact);
            this.manager.DeleteAllContactPhones(this.testContactName);

            Assert.IsFalse(this.db.Contacts.Any(e => e.Name == this.testContactName && e.IsActual));
            Assert.IsTrue(this.db.Contacts.Any(e => e.Name == this.testContactName && !e.IsActual));
        }

        [TestInitialize]
        public void PrepareData()
        {
            this.db = new PhoneBookDb();
            this.manager = new PhoneBookManager(db);
            var contact = this.manager.AddIfNotExists(this.testContactName, this.testPhoneFirst);
            this.testContacts.Add(contact);
        }

        [TestCleanup]
        public void TestClean()
        {
            this.db.Contacts.RemoveRange(this.testContacts);
            this.db.SaveChanges();
        }
    }
}
