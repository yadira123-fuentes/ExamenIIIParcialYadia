using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenIIIParcialYadia.Data;
using System.IO;

namespace ExamenIIIParcialYadia
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        public App()
        {
            InitializeComponent();

            MainPage = MainPage = new NavigationPage(new MainPage());
        }

        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CPagos.db3"));
                }
                return db;
            }

        }

    

    protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
