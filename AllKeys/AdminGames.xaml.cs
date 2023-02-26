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
using Usuarios.Modelo;

namespace AllKeys
{
    /// <summary>
    /// Lógica de interacción para AdminGames.xaml
    /// </summary>
    public partial class AdminGames : Page
    {
        Videojuego videojuego=new Videojuego();
        UnitOfWork bd= new UnitOfWork();
        Boolean nuevo = true;
        public AdminGames()
        {
            InitializeComponent();
            gbFormularioV.DataContext = videojuego;
            dgVideojuegos.ItemsSource=bd.VideojuegosRepository.GetAll();
            dgVideojuegos.SelectedIndex=-1;
        }

        private void dgVideojuegos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgVideojuegos.SelectedIndex != -1)
            {
                videojuego = (Videojuego)dgVideojuegos.SelectedItem;
                gbFormularioV.DataContext = videojuego;
                nuevo = false;
            }
        }
        private void Limpiar()
        {
            videojuego = new Videojuego();
            gbFormularioV.DataContext = videojuego;
            nuevo = true;
        }

        

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            String errores = Validacion.errores(videojuego);
            if (errores.Equals(""))
            {
                if (nuevo)
                {
                    bd.VideojuegosRepository.Añadir(videojuego);
                    bd.Save();
                    dgVideojuegos.ItemsSource = bd.VideojuegosRepository.GetAll();
                }
                else
                {
                    bd.VideojuegosRepository.Update(videojuego);
                    bd.Save();
                }

                Limpiar();
            }
            else
            {
                //LibreriaV7.MostrarSnackbar(sbNotification, errores, letra: "#FFFF0000");
            }
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (dgVideojuegos.SelectedIndex != null)
            {
                bd.VideojuegosRepository.Delete(videojuego);
                bd.Save();
                Limpiar();
                dgVideojuegos.ItemsSource = bd.VideojuegosRepository.GetAll();
            }
        }
    }
}
