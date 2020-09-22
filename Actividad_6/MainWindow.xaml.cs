using Actividad_6.BD;
using Actividad_6.Gui;
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

namespace Actividad_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Empleados em = new Empleados();
            this.Close();
            em.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Vehiculos vehiculos = new Vehiculos();
            this.Close();
            vehiculos.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Clientes vistaClientes = new Clientes();
            this.Close();
            vistaClientes.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ConexionSQLServer csql = new ConexionSQLServer();
            csql.Abrir();
        }
    }
}
