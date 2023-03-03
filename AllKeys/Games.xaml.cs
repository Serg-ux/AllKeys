using AllKeys.Modelo;
using ExamenVentas.DAL;
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
    /// Lógica de interacción para Games.xaml
    /// </summary>
    public partial class Games : Page
    {
        Videojuego videojuego = new Videojuego();
        
        public Games()
        {
            InitializeComponent();
            dgVideojuegos.ItemsSource = Principal.bd.VideojuegosRepository.GetAll();
            dgVideojuegos.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            List<Videojuego> videojuegos = Principal.bd.VideojuegosRepository.
            FiltroLibros(txtBusquedaUs.Text);
            dgVideojuegos.ItemsSource = videojuegos;
        }
    }
}
