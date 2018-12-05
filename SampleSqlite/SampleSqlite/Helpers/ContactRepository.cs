using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SampleSqlite.Models;

namespace SampleSqlite.Helpers
{
    public class ContactRepository : IContactRepository
    {
        DatabaseHelper _databasehelper;
        public ContactRepository()
        {
            _databasehelper = new DatabaseHelper();
        }
        public ObservableCollection<ContactsInfo> GetAllContactsData()
        {
           return _databasehelper.GetAllContactsData();
        }

        public ContactsInfo GetContactData(int contactID)
        {
            return _databasehelper.GetContactData(contactID);
        }

        public void InsertContact(ContactsInfo contact)
        {
             _databasehelper.InsertContact(contact);
        }
    }
}
