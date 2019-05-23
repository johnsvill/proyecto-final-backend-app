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
    public class CompraModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<Compra> _Compra;
        public ObservableCollection<Compra> Compras
        {
            get { return this._Compra; }
            set { this._Compra = value; }
        }
        public CompraModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
