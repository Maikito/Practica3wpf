using Practica3wpf.Models;
using Practica3wpf.Utilitarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practica3wpf.ViewModels
{
    public class ProductoViewModel : ViewModelBase
    {
        #region Propiedades
        private string _Resultado;
        private string Resultado
        {
            get { return _Resultado; }
            set
            {
                _Resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        private string _Nombres;
        public string Nombres
        {
            get { return _Nombres; }
            set
            {
                _Nombres = value;
                OnPropertyChanged(nameof(Nombres));
            }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }


        private decimal _Precio;
        public decimal Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        public ObservableCollection<Producto> Productos { get; }

        #endregion



        #region Comando
        public ICommand GuardarProductoCommand { get; }

        public ProductoViewModel()
        {
            GuardarProductoCommand = new RelayCommand(GuardarProducto);
        }
        private void GuardarProducto()
        {
            Resultado = string.Concat(Nombres, " ", Descripcion, " ", Precio.ToString());
            Productos.Add(new Producto
            {
                Nombres = this.Nombres,
                Descripcion = this.Descripcion,
                Precio = Convert.ToInt32(this.Precio),
            });
        }
        #endregion
    }
}
