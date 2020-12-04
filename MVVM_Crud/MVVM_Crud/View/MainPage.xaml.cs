using MVVM_Crud.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM_Crud.View
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.Master = new MasterPage();
            this.Detail = new NavigationPage(new DetailPage());

            App.MasterDetail = this;
        }
    }
}
