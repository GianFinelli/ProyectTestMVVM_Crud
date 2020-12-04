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

namespace MVVM_Crud.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarProductoPage : ContentPage
    {
        public AgregarProductoPage()
        {
            InitializeComponent();
            BindingContext = new AgregarProductoViewModel();
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    if (!CrossMedia.Current.IsPickPhotoSupported)
        //    {
        //        //await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
        //        return;
        //    }

        //    var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
        //    {
        //        PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

        //    });

        //    if (file == null)
        //        return;

        //    imagenSB.Source = ImageSource.FromStream(() =>
        //    {
        //        var stream = file.GetStream();
        //        return stream;
        //    });

        //}
    }
}