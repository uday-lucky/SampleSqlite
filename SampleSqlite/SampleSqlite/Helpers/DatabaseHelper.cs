using SampleSqlite.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SampleSqlite.Helpers
{
    public class DatabaseHelper
    {
        static  SQLiteConnection sqliteConnection;
        public DatabaseHelper()
        {
            sqliteConnection = DependencyService.Get<ISqlite>().GetConnection();
            sqliteConnection.CreateTable<ContactsInfo>();
        }

        public ObservableCollection<ContactsInfo> GetAllContactsData()
        {
            return new ObservableCollection<ContactsInfo>( (from data in sqliteConnection.Table<ContactsInfo>()
                    select data).ToList());
        }

        public void InsertContact(ContactsInfo contact)
        {
            sqliteConnection.Insert(contact);
        }
        public ContactsInfo GetContactData(int id)
        {
            return sqliteConnection.Table<ContactsInfo>().FirstOrDefault(t => t.Id == id);
        }
    }
}
