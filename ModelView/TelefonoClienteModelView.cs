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
    public class TelefonoClienteModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<TelefonoCliente> _TelefonoCliente;
        public ObservableCollection<TelefonoCliente> TelefonoClientes
        {
            get { return this._TelefonoCliente; }
            set { this._TelefonoCliente = value; }
        }
        public TelefonoClienteModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
