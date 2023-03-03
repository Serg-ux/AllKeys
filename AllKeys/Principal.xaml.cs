﻿using ExamenVentas.DAL;
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
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        private Games game = new Games();
        private Perfil perfill = new Perfil();
        private Carrito caritoo = new Carrito();
        public static UnitOfWork bd = new UnitOfWork();

        public Principal()
        {
            InitializeComponent();
        }
        
        private void Juegosbt_Click(object sender, RoutedEventArgs e)
        {
            Games game = new Games(dg);
            frame.Content = game;

        }

        private void perfil_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = perfill;
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Salir?",
                   "Logout",
                   MessageBoxButton.YesNo,
                   MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void carrito_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = caritoo;
        }

        private void btadminGame_Click(object sender, RoutedEventArgs e)
        {
            AdminGame adminGame =new AdminGame();
            adminGame.Show();
            
        }

        private void btadminUser_Click(object sender, RoutedEventArgs e)
        {
            AdminUser adminUser =new AdminUser();
            adminUser.Show();
           
        }
    }
}
