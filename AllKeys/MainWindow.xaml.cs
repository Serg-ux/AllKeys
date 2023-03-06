﻿using AllKeys.Modelo;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Usuario usuario = new Usuario();
        UnitOfWork bd = new UnitOfWork();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistroUsuarios registr=new VentanaRegistroUsuarios();
            registr.Show();
            this.Close();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            if(txtNombre.Text!="" && pb_contra.Password.ToString()!= "")
            {
               
                //comprueba si en la bd existe o no el usuario, si existe lo devolverá
                usuario = bd.UsuariosRepository.ValidarUsuario(txtNombre.Text, pb_contra.Password.ToString());
                if (usuario != null)
                {
                    Principal principal = new Principal();
                    principal.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error Login", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos", "Error Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }
    }
}
