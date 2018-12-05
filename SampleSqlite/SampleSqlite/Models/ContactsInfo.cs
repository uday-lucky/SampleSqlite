using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSqlite.Models
{
    public class ContactsInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}
