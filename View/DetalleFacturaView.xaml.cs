using System;
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
using AppAlmacenPF.ModelView;
using AppAlmacenPF.DataContext;

namespace AppAlmacenPF.View
{
    /// <summary>
    /// Lógica de interacción para DetalleFactura.xaml
    /// </summary>
    public partial class DetalleFacturaView : Window
    {
        public DetalleFacturaView()
        {
            InitializeComponent();
            this.DataContext = new DetalleFacturaModelView();//Para enlazar el archivo del mismo nombre sin la extensión .cs (Modelo de datos"C#" con la ventana "WPF")
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
