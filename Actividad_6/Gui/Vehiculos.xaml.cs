using Actividad_6.Controller;
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
using Actividad_6.Model;

namespace Actividad_6.Gui
{
    /// <summary>
    /// Lógica de interacción para Vehiculos.xaml
    /// </summary>
    public partial class Vehiculos : Window
    {
        ControlVehiculo controlVehiculo = null;
        public Vehiculos()
        {
            InitializeComponent();
            controlVehiculo = new ControlVehiculo();
            cmbMarca.ItemsSource = new string[] { "Selecciona una marca", "Chevrolet", "Audi", "Jeep", "Honda", "Lincoln" };
            cmbMarca.SelectedIndex = 0;
        }

        private void CmbMarca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cmbMarca.SelectedIndex)
            {
                case 1:
                    cmbModelo.ItemsSource = new String[]
                    { "Selecciona un modelo", "Cavalier", "Colorado", "Aveo", "Chevy", "Cheyene" };
                    cmbModelo.SelectedIndex = 0;
                    this.txtCodigo.Text = "1";
                    break;
                case 2:
                    cmbModelo.ItemsSource = new String[]
                    { "Selecciona un modelo", "A4", "A5", "R8", "A11.4", "R91" };
                    cmbModelo.SelectedIndex = 0;
                    this.txtCodigo.Text = "2";
                    break;
                case 3:
                    cmbModelo.ItemsSource = new String[]
                    { "Selecciona un modelo", "Compass Latitude", "Patriot Latitude", "Grand Cherokee", "Grand Cherokee Laredo", "Grand auto" };
                    cmbModelo.SelectedIndex = 0;
                    this.txtCodigo.Text = "3";
                    break;
                case 4:
                    cmbModelo.ItemsSource = new String[]
                    { "Selecciona un modelo", "Accord", "Civic", "Clarity Electric", "Clarity", "Insight"};
                    cmbModelo.SelectedIndex = 0;
                    this.txtCodigo.Text = "4";
                    break;
                case 5:
                    cmbModelo.ItemsSource = new String[]
                    { "Selecciona un modelo", "MKY", "Navigator", "MKZ", "Continental", "MKZ Hybrid" };
                    cmbModelo.SelectedIndex = 0;
                    this.txtCodigo.Text = "5";
                    break;
            }

        }

        private void BtnAddVehiculo_Click(object sender, RoutedEventArgs e)
        {
            Categoria categoria = new Categoria();
            Vehiculo vehiculo = new Vehiculo();
            ControlVehiculo control = new ControlVehiculo();
            categoria.Marca = cmbMarca.SelectedItem.ToString();
            categoria.Modelo = cmbModelo.SelectedItem.ToString();
            vehiculo._Categoria = categoria;
            vehiculo._Categoria.Codigo = Convert.ToInt32(this.txtCodigo.Text);
            vehiculo.Tipo = txtTipo.Text;
            vehiculo.Precio = Int32.Parse(txtPrecio.Text);
            vehiculo.Version = txtVersion.Text;
            vehiculo.NumSerie = txtNumSerie.Text;
            vehiculo.Color = txtColor.Text;
            ControlVehiculo cv = new ControlVehiculo();
            cv.InsertUser(vehiculo);

            txtCodigo.Text = "";
            txtTipo.Text = "";
            txtPrecio.Text = "";
            txtVersion.Text = "";
            txtNumSerie.Text = "";
            txtColor.Text = "";

            //controlVehiculo.AgregarVehiculo(vehiculo);
            //dtgVehiculos.ItemsSource = controlVehiculo.GetAll();
            //dtgVehiculos.Items.Refresh();
        }

        private void BtnFindVehiculo_Click(object sender, RoutedEventArgs e)
        {
            //dtgVehiculos.ItemsSource = null;
            //dtgVehiculos.ItemsSource = controlVehiculo.FindMarca(cmbMarca.SelectedItem.ToString());
        }

        private void BtnFindModeloVehiculo_Click(object sender, RoutedEventArgs e)
        {
            //dtgVehiculos.ItemsSource = null;
            //dtgVehiculos.ItemsSource = controlVehiculo.FindModelo(cmbModelo.SelectedItem.ToString());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
