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
using AppAlmacenPF.Entities;
using AppAlmacenPF.ModelView;
using AppAlmacenPF.View;


namespace AppAlmacenPF.View
{
    /// <summary>
    /// Lógica de interacción para TelefonoClienteView.xaml
    /// </summary>
    public partial class TelefonoClienteView : Window
    {
        public TelefonoClienteView()
        {
            InitializeComponent();
            this.DataContext = new TelefonoClienteModelView();
        }
    }
}
