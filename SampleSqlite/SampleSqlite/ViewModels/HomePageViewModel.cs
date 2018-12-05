using SampleSqlite.Helpers;
using SampleSqlite.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleSqlite.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ContactsInfo> _cd;
        public ObservableCollection<ContactsInfo> cd
        {
            get => _cd;
            set
            {
                _cd = value;
                NotifyPropertyChanged("cd");
            }
        }
        private string _name = "";
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }


        public string _age = "";
        public string Age
        {
            get => _age;
            set
            {
                _age = value;
                NotifyPropertyChanged("Age");
            }
        }

        public string _gender = "";
        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                NotifyPropertyChanged("Gender");
            }
        }
        public ICommand submitcontact { get; set; }
        public ICommand GetData { get; set; }
        ContactRepository _contactrepository;
        public HomePageViewModel()
        {
            cd = new ObservableCollection<ContactsInfo>();

            if (cd.Count>0)
            {
                cd.Add(new ContactsInfo { Name = "UDay", Age = "23", Gender = "MAle" });
              //  cd =new ObservableCollection<ContactsInfo> ( _contactrepository.GetAllContactsData());
            }
            GetData = new Command(getData);
            _contactrepository = new ContactRepository();
            submitcontact = new Command(SubmitData);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void getData()
        {
             cd = _contactrepository.GetAllContactsData();
            
            
            //cd.Add(new ContactsInfo { Name="UDay", Age="23",Gender="MAle"});
        }
        public void SubmitData()
        {
            ContactsInfo ct = new ContactsInfo();
            ct.Name = Name;
            ct.Age = Age;
            ct.Gender = Gender;
            _contactrepository.InsertContact(ct);
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
