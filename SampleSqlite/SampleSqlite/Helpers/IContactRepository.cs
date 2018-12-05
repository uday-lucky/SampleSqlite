using SampleSqlite.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SampleSqlite.Helpers
{
    interface IContactRepository
    {
        ObservableCollection<ContactsInfo> GetAllContactsData();

        //Get Specific Contact data  
        ContactsInfo GetContactData(int contactID);

        // Delete all Contacts Data  
       // void DeleteAllContacts();

        // Delete Specific Contact  
      //  void DeleteContact(int contactID);

        // Insert new Contact to DB   
        void InsertContact(ContactsInfo contact);

        // Update Contact Data  
      //  void UpdateContact(ContactsInfo contact);
    }
}
