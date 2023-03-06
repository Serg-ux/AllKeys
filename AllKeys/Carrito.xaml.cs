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

namespace AllKeys
{
    /// <summary>
    /// Lógica de interacción para Carrito.xaml
    /// </summary>
    public partial class Carrito : Page
    {
        public Carrito()
        {
            InitializeComponent();
            dgCarrito.ItemsSource = Games.juegos_carrito;
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            if (dgCarrito.ItemsSource != null)
            {
                ValidarTarjeta validarTarjeta = new ValidarTarjeta();
                validarTarjeta.Show();
            }
            
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
