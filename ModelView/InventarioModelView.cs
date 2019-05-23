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
    public class InventarioModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<Inventario> _Inventario;
        public ObservableCollection<Inventario> Inventarios
        {
            get { return this._Inventario; }
            set { this._Inventario = value; }
        }
        public InventarioModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
