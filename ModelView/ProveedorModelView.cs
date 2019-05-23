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
    public class ProveedorModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<Proveedor> _Proveedor;
        public ObservableCollection<Proveedor> Proveedores
        {
            get { return this._Proveedor; }
            set { this._Proveedor = value; }
        }
        public ProveedorModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
