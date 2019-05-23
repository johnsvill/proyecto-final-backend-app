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
    public class TipoEmpaqueModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<TipoEmpaque> _TipoEmpaque;
        public ObservableCollection<TipoEmpaque> TipoEmpaques
        {
            get { return this._TipoEmpaque; }
            set { this._TipoEmpaque = value; }

        }
        public TipoEmpaqueModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
