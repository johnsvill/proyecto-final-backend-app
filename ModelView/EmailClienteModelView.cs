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
    public class EmailClienteModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<EmailCliente> _EmailCliente;
        public ObservableCollection<EmailCliente> EmailClientes
        {
            get { return this._EmailCliente; }
            set { this._EmailCliente = value; }
        }
        public EmailClienteModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
