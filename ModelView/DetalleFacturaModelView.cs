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
    public class DetalleFacturaModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<DetalleFactura> _DetalleFactura;
        public ObservableCollection<DetalleFactura> DetalleFacturas
        {
            get { return this._DetalleFactura; }
            set { this._DetalleFactura = value; }
        }
        public DetalleFacturaModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
