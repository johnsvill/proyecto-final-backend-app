﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AppAlmacenPF.DataContext;
using AppAlmacenPF.View;
using AppAlmacenPF.ModelView;
using AppAlmacenPF.Entities;

namespace AppAlmacenPF.View
{
    /// <summary>
    /// Lógica de interacción para TipoEmpaqueView.xaml
    /// </summary>
    public partial class TipoEmpaqueView : Window
    {
        public TipoEmpaqueView()
        {
            InitializeComponent();
            this.DataContext = new TipoEmpaqueView();//Para enlazar el archivo del mismo nombre sin la extensión .cs (Modelo de datos"C#" con la ventana "WPF")
        }
    }
}
