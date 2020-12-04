using Android.Graphics;
using MVVM_Crud.Model;
using MVVM_Crud.View;
using MVVM_Crud.View.VProducto;
//using Plugin.FilePicker;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Crud.ViewModel
{
    public class EditarProductoViewModel : INotifyPropertyChanged
    {
        #region Properties
        public event PropertyChangedEventHandler PropertyChanged;
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Imagen { get; set; }
        public string ImagenPath { get; set; }

        private ImageSource imagenSource;
        public ImageSource ImagenByte
        {
            get { return imagenSource; }
            set
            {
                if (imagenSource != value)
                {
                    imagenSource = value;
                    if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs("ImagenByte")); }
                }
            }
        }
        #endregion
        public ICommand GuardarCommand { get; set; }
        public ICommand FileCommand { get; set; }

        public Producto ProductoEdit { get; set; }
        public EditarProductoViewModel(Producto producto)
        {
            Nombre = producto.Nombre;
            Precio = producto.Precio;
            ImagenPath = producto.ImagenFile;
            ImagenByte = producto.ImagenFile;
            ProductoEdit = producto;
            GuardarCommand = new Command(OnGuardar);
            FileCommand = new Command(OnFile);
        }

        public void OnGuardar()
        {
            var productoEditado = Producto(ProductoEdit);
            App.database.unitOfWork.productoRepository.EditarItem(productoEditado);
            App.MasterDetail.Navigation.PushAsync(new IndexProductoPage());
        }

        public Producto Producto(Producto producto) => new Producto
        {
            Id = producto.Id,
            Nombre = Nombre,
            Precio = Precio,
            Imagen = Imagen,
            ImagenFile = ImagenPath
        };

        private async void OnFile()
        {
            if (!CrossMedia.Current.IsPickPhotoSupported) return;
            MediaFile file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.Medium
            });
            if (file == null) return;
            ImagenPath = file.Path;
            ImagenByte = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
        }
    }
}
