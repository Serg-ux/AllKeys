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
    /// Lógica de interacción para AdminUser.xaml
    /// </summary>
    public partial class AdminUser : Window
    {
        Usuario usuario = new Usuario();
        UnitOfWork bd = new UnitOfWork();
        Boolean nuevo = true;
        public AdminUser()
        {
            InitializeComponent();
            gbFormularioC.DataContext = usuario;
            dgUsuarios.ItemsSource = bd.UsuariosRepository.UsuariosCompletos();
            dgUsuarios.SelectedIndex = -1;

            //problemas combobox
            cbRol.ItemsSource=bd.RolesRepository.GetAll();
            cbRol.DisplayMemberPath = "RolNombre";
            cbRol.SelectedValue = "RolId";
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgUsuarios.SelectedIndex != -1)
            {
                usuario = (Usuario)dgUsuarios.SelectedItem;
                gbFormularioC.DataContext=usuario;
                nuevo=false;
            }
        }
        private void Limpiar()
        {
            usuario = new Usuario();
            gbFormularioC.DataContext = usuario;
            nuevo=true;
        }

        private void btnGuardar_Click_1(object sender, RoutedEventArgs e)
        {
            String errores = Validacion.errores(usuario);
            if (errores.Equals(""))
            {
                if (nuevo)
                {
                    bd.UsuariosRepository.Añadir(usuario);
                    bd.Save();
                }
                else
                {
                    bd.UsuariosRepository.Update(usuario);
                    bd.Save();
                }
                Limpiar();
                dgUsuarios.ItemsSource = bd.UsuariosRepository.UsuariosCompletos();
            }
        }

        private void btnBorrar_Click_1(object sender, RoutedEventArgs e)
        {
            if (dgUsuarios.SelectedIndex != -1)
            {
                bd.UsuariosRepository.Delete(usuario);
                bd.Save();
                Limpiar();
                dgUsuarios.ItemsSource = bd.UsuariosRepository.UsuariosCompletos();
            }
        }
    }
}
