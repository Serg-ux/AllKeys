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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AllKeys
{
    /// <summary>
    /// Lógica de interacción para Perfil.xaml
    /// </summary>
    public partial class Perfil : Page
    {
        Usuario usuario = new Usuario();
        int idUSR= MainWindow.idUS;
        public Perfil()
        {
            InitializeComponent();
            usuario = Principal.bd.UsuariosRepository.BuscarUsId(idUSR);
            gbFormularioUser.DataContext=usuario;
            cbRol.ItemsSource = Principal.bd.RolesRepository.GetAll();
            cbRol.DisplayMemberPath = "RolNombre";
            cbRol.SelectedIndex = usuario.RolId;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtColorFav.Text != "" && txtContra.Text != "" && txtCorreo.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && cbRol.SelectedIndex != -1)
            {

            }
        }
    }
}
