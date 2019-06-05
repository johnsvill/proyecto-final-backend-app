using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using AppAlmacenPF.Entities;
using AppAlmacenPF.ModelView;
using System.Windows.Input;

namespace AppAlmacenPF.ModelView
{
    public class TelefonoClienteModelView : INotifyPropertyChanged, ICommand//INTERFAZ
    {
        //Enlace a la base de datos
        private AppAlmacenPFDataContext db = new AppAlmacenPFDataContext();

        private bool _IsReadOnlyCodigoTelefono = true;
        private bool _IsReadOnlyNumero = true;
        private bool _IsReadOnlyDescripcion = true;
        private bool _IsReadOnlyNit = true;
        private string _CodigoTelefono;
        private string _Numero;
        private string _Descripcion;
        private string _Nit;

        public string CodigoTelefono
        {
            get
            {
                return this._CodigoTelefono;
            }
            set
            {
                this._CodigoTelefono = value;
                ChangedNotify("CodigoTelefono");
            }
        }
        public string Numero
        {
            get
            {
                return this._Numero;
            }
            set
            {
                this._Numero = value;
                ChangedNotify("Numero");
            }
        }
        public string Descripcion
        {
            get
            {
                return this._Descripcion;
            }
            set
            {
                this._Descripcion = value;
                ChangedNotify("Descripcion");
            }
        }
        public string Nit
        {
            get
            {
                return this._Nit;
            }
            set
            {
                this._Nit = value;
                ChangedNotify("Nit");
            }
        }
        private TelefonoClienteModelView _Instancia;
        public TelefonoClienteModelView Instancia
        {
            get
            {
                return this._Instancia;
            }
            set
            {
                this._Instancia = value;
                ChangedNotify("Instancia");
            }
        }
        private ObservableCollection<TelefonoCliente> _TelefonoCliente;
        public ObservableCollection<TelefonoCliente> TelefonoClientes
        {
            get
            {
                if(this._TelefonoCliente == null)
                {
                    this._TelefonoCliente = new ObservableCollection<TelefonoCliente>();
                    foreach(TelefonoCliente elemento in db.TelefonoClientes.ToList())
                    {
                        this._TelefonoCliente.Add(elemento);
                    }
                }
                return this._TelefonoCliente;
            }
            set { this._TelefonoCliente = value; }
        }
        public TelefonoClienteModelView()
        {
            this.Titulo = "";
            this.Instancia = this;
        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        //Interfaz ICommand
        public void ChangedNotify(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
            /*throw new NotImplementedException();*/
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
