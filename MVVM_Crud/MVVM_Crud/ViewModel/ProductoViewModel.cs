using MVVM_Crud.Model;
using MVVM_Crud.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Crud.ViewModel
{
    public class ProductoViewModel : BindableObject
    {
        private ObservableCollection<Producto> listado;
        public ObservableCollection<Producto> Listado
        {
            get { return listado; }
            set
            {
                listado = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarCommand { get; set; }
        public ICommand BorrarCommand { get; set; }
        public ProductoViewModel()
        {
            var list = new ObservableCollection<Producto>(App.Database.unitOfWork.productoRepository.ObtenerListado().Result);
            Listado = list;

            AgregarCommand = new Command(OnAgregar);

            BorrarCommand = new Command(OnBorrar);
        }

        private void OnAgregar()
        {
            App.MasterDetail.Navigation.PushAsync(new AgregarProductoPage());
        }

        private void OnBorrar(object obj)
        {
            var producto = obj as Producto;
            App.database.unitOfWork.productoRepository.BorrarItem(producto);
            Listado.Remove(producto);
        }

    }
}
