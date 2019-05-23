using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppAlmacenPF.Entities;
using AppAlmacenPF.ModelView;

namespace AppAlmacenPF.ModelView
{
    public class CategoriaModelView : INotifyPropertyChanged//INTERFAZ
    {
        private ObservableCollection<Categoria> _Categoria;
        public ObservableCollection<Categoria> Categorias
        {
            get { return this._Categoria; }
            set { this._Categoria = value; }
        }
        public CategoriaModelView()
        {

        }
        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
