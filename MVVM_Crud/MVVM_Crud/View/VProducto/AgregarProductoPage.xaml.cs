using MVVM_Crud.ViewModel;
using Plugin.Media;
//using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Crud.View.VProducto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarProductoPage : ContentPage
    {
        public AgregarProductoPage()
        {
            InitializeComponent();
            BindingContext = new AgregarProductoViewModel();
        }
    }
}