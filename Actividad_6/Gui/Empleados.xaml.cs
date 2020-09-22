using Actividad_6.Controller;
using Actividad_6.Model;
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

namespace Actividad_6.Gui
{
    /// <summary>
    /// Lógica de interacción para Empleados.xaml
    /// </summary>
    public partial class Empleados : Window
    {
        public Empleado xe = null;
        public Empleados()
        {
            InitializeComponent();
            //MostrarDatos(ce);
        }
        
        /*public void MostrarDatos(ControlEmpleado controllerEmpleado)
        {
            dtgEmpleados.ItemsSource = controllerEmpleado.GetAll();
        }*/
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Empleado u = new Empleado();
            u.Nombre = txtNombre.Text;
            u.ApPaterno = txtApPaterno.Text;
            u.ApMaterno = txtApMaterno.Text;
            u.IdUsuario = Convert.ToInt32(txtUsuario.Text);
            //u.FechaIngreso = dtmFechaIngreso.
            ControlEmpleado ce = new ControlEmpleado();
            ce.InsertUser(u);

            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtNombre.Text = "";
            dtmFechaIngreso.Text = "";
        }
        private void btnEmpleadoCerrar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //dtgEmpleados.ItemsSource = null;
            //dtgEmpleados.ItemsSource = ce.FindApPaterno(txtApPaterno.Text);
        }

    }
}
