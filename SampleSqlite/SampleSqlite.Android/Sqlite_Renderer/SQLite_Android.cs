using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SampleSqlite.Droid.Sqlite_Renderer;
using SampleSqlite.Helpers;
using SQLite;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace SampleSqlite.Droid.Sqlite_Renderer
{
    public class SQLite_Android:ISqlite
    {
        public SQLite_Android()
        {

        }

        public SQLiteConnection GetConnection()
        {
            var fileName = "Uday.db3";
            var documentPath = System.Environment.GetFolderPath( System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath,fileName);    
            return  new SQLiteConnection(path); 
        }
    }
}