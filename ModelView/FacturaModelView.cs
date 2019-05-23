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
    public class FacturaModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<Factura> _Factura;
        public ObservableCollection<Factura> Facturas
        {
            get { return this._Factura; }
            set { this._Factura = value; }
        }
        public FacturaModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
