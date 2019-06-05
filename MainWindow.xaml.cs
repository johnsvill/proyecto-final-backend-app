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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AppAlmacenPF.View;
using AppAlmacenPF.Entities;
using AppAlmacenPF.DataContext;
using AppAlmacenPF.ModelView;

namespace AppAlmacenPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new ProductoView().Show();//Para que compile en modo gráfico
            new CategoriaView().Show();
            new InventarioView().Show();
            new TipoEmpaqueView().Show();
            new DetalleCompraView().Show();
            new DetalleFacturaView().Show();
            new EmailProveedorView().Show();
            new CompraView().Show();
            new FacturaView().Show();            
            new ProveedorView().Show();
            new ClienteView().Show();
            new TelefonoProveedorView().Show();
            new EmailClienteView().Show();
            new TelefonoClienteView().Show();
        }
    }
}
