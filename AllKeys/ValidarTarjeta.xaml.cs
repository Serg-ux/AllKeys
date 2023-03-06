using AllKeys.Modelo;
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

namespace AllKeys
{
    /// <summary>
    /// Lógica de interacción para ValidarTarjeta.xaml
    /// </summary>
    public partial class ValidarTarjeta : Window
    {
        UsuarioRegistrado usuarioRegistrado= new UsuarioRegistrado();
        public ValidarTarjeta()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            if (txtApellidos.Text != "" || txtCV.Text != "" || txtnombre.Text != "" || txtTarjeta.Text != "")
            {
                CompraRealizada compraRealizada = new CompraRealizada();
                compraRealizada.Show();
                this.Close();
            }
            else MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
