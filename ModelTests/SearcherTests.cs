using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Linq;

namespace ModelTests
{
    /// <summary>
    /// Summary description for SearcherTests
    /// </summary>
    [TestClass]
    public class SearcherTests
    {
        private PhoneBookDb db;
        private Searcher searcherByName;
        private Searcher searcherByPhone;

        private Contact testContact;

        private readonly string testContactName;

        private readonly string testPhone = "000-222-123-000";

        public SearcherTests()
        {
            this.testContactName = "testContact_" + Guid.NewGuid().ToString();

            this.db = new PhoneBookDb();
            this.searcherByName = new Searcher(this.db);
        }

        [TestMethod]
        public void NameContains()
        {
            var phones = this.searcherByName.Contains(this.testContactName.Substring(10, 15)).ToList();

            Assert.AreNotEqual(0, phones.Count());
        }

        [TestMethod]
        public void NameNotContains()
        {
            var phones = this.searcherByName.Contains(Guid.NewGuid().ToString()).ToList();

            Assert.AreEqual(0, phones.Count());
        }

        [TestInitialize]
        public void PrepareData()
        {
            this.testContact = new Contact(testContactName, this.testPhone);
            this.db.Contacts.Add(testContact);
            this.db.SaveChanges();
        }

        [TestCleanup]
        public void TestClean()
        {
            this.db.Entry(this.testContact).State = System.Data.Entity.EntityState.Deleted;
            this.db.SaveChanges();
        }
    }
}
