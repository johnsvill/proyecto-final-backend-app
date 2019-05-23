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
    public class ClienteModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<Cliente> _Cliente;
        public ObservableCollection<Cliente> Clientes
        {
            get { return this._Cliente; }
            set { this._Cliente = value; }
        }
        public ClienteModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
