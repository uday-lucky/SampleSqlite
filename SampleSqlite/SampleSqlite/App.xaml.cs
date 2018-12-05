using SampleSqlite.Helpers;
using SampleSqlite.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SampleSqlite
{
    public partial class App : Application
    {
        DatabaseHelper dbhelper;
        public App()
        {
            InitializeComponent();
           
        }

        protected override void OnStart()
        {
            dbhelper = new DatabaseHelper();
           var Countdb=  dbhelper.GetAllContactsData();
            if (Countdb.Count>0)
            {
                MainPage = new HomePage();
            }
            else
            {
                MainPage = new MainPage();
            }
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            dbhelper = new DatabaseHelper();
            var Countdb = dbhelper.GetAllContactsData();
            if (Countdb.Count > 0)
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new HomePage();
              
            }
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            dbhelper = new DatabaseHelper();
            var Countdb = dbhelper.GetAllContactsData();
            if (Countdb.Count > 0)
            {
                MainPage = new HomePage();
            }
            else
            {
                MainPage = new MainPage();

            }
            // Handle when your app resumes
        }
    }
}
