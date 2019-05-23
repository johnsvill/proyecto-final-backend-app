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
    class DetalleCompraModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<DetalleCompra> _DetalleCompra;
        public ObservableCollection<DetalleCompra> DetalleCompras
        {
            get { return this._DetalleCompra; }
            set { this._DetalleCompra = value; }
        }
        public DetalleCompraModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
