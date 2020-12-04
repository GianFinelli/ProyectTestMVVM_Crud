using MVVM_Crud.View;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Crud
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetail { get; set; }
        public static MVVM_Crud.Database.Database database;
        public static MVVM_Crud.Database.Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new MVVM_Crud.Database.Database(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MVVMCrud.db"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            NavigationPage.SetHasNavigationBar(this, false);
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
