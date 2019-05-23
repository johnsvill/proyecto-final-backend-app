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
    public class EmailProveedorModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<EmailProveedor> _EmailProveedor;
        public ObservableCollection<EmailProveedor> EmailProveedores
        {
            get { return this._EmailProveedor; }
            set { this._EmailProveedor = value; }
        }
        public EmailProveedorModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
