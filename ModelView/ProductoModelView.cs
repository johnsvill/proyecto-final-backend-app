using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using AppAlmacenPF.Entities;
using AppAlmacenPF.ModelView;

namespace AppAlmacenPF.ModelView
{
    public class ProductoModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<Producto> _Producto;
        public ObservableCollection<Producto> Productos
        {
            get { return this._Producto; }
            set { this._Producto = value; }
        }
        public ProductoModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
