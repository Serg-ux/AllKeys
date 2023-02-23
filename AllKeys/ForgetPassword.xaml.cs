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
    /// Lógica de interacción para ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Window
    {
        public ForgetPassword()
        {
            InitializeComponent();
            stkContraNew.Visibility = Visibility.Hidden;
            bt_guardar.Visibility = Visibility.Hidden;
            bt_borrar.Visibility = Visibility.Hidden;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
