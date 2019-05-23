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
    public class TelefonoProveedorModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<TelefonoProveedor> _TelefonoProveedor;
        public ObservableCollection<TelefonoProveedor> TelefonoProveedores
        {
            get { return this._TelefonoProveedor; }
            set { this._TelefonoProveedor = value; }
        }
        public TelefonoProveedorModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
