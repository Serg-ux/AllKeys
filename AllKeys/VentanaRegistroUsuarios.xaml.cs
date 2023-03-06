
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
using System.Windows.Shapes;
using Usuarios.Modelo;

namespace AllKeys
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistroUsuarios.xaml
    /// </summary>
    public partial class VentanaRegistroUsuarios : Window
    {
        Usuario usuario = new Usuario();
        UnitOfWork bd = new UnitOfWork();
        public VentanaRegistroUsuarios()
        {
            InitializeComponent();
            gbFormulario.DataContext=usuario;

            cbRol.ItemsSource = bd.RolesRepository.GetAll();
            cbRol.DisplayMemberPath = "RolNombre";
            cbRol.SelectedValuePath = "RolId";
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Limpiar()
        {
            usuario = new Usuario();
            gbFormulario.DataContext = usuario;
        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtColorFav.Text != "" && txtContra.Text != "" && txtContra.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && cbRol.SelectedIndex != -1)
            {
                String errores = Validacion.errores(usuario);
                if (errores.Equals(""))
                {
                    bd.UsuariosRepository.Añadir(usuario);
                    bd.Save();
                    Limpiar();
                    MessageBox.Show("Se creo el usuario correctamente", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Errores en los datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else MessageBox.Show("Faltan Datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            usuario = new Usuario();
            gbFormulario.DataContext = usuario;
        }
    }
}
