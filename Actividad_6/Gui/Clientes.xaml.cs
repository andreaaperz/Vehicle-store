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
    public partial class Clientes : Window
    {
        ControlCliente cu = new ControlCliente();
        public Cliente xc = null;
        public Clientes()
        {
            InitializeComponent();
            //MostrarDatos(cc);
        }

        /*public void AsignarValores()
        {
            xc = new Cliente();
            try
            {
                xc.Nombre = txtNombre.Text;
                xc.ApPaterno = txtApPaterno.Text;
                xc.ApMaterno = txtApMaterno.Text;
                xc.NombreUsuario = txtNombreUsuario.Text;
                xc.Contrasenia = pswContrasenia.Password;
                xc.Email = txtEmail.Text;
                xc.NumCuenta = Int32.Parse(txtCodigo.Text);
            }
            catch
            {
                MessageBox.Show("Algun campo está incorrecto");
            }

        }*/

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //AsignarValores();
            //cc.AgregarCliente(xc);
            //dtgClientes.Items.Refresh();
            //txtCodigo.Text = "";
            

            Cliente u = new Cliente();
            u.Nombre = txtNombre.Text;
            u.ApPaterno = txtApPaterno.Text;
            u.ApMaterno = txtApMaterno.Text;
            u.Email = txtEmail.Text;
            u.IdUsuario = Convert.ToInt32(this.txtNombreUsuario.Text);
            cu.InsertUser(u);

            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtNombreUsuario.Text = "";
            //pswContrasenia.Password = "";
            txtEmail.Text = "";
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //dtgClientes.ItemsSource = null;
            //dtgClientes.ItemsSource = cc.FindApPaterno(txtApPaterno.Text);
        }
    }
}
