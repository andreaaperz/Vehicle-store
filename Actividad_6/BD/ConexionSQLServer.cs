using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Actividad_6.BD
{
    class ConexionSQLServer
    {
        public SqlConnection Conexion { set; get; }
        public SqlConnection Abrir()
        {
            string connectionString =
                "DATA SOURCE = DESKTOP-RTHNFEK\\SQLEXPRESS;" +
                //"INITIAL CATALOG = JugueteriaMahuiltia;" +
                "INITIAL CATALOG = Autos1;" +
                "INTEGRATED SECURITY = YES;";
            try
            {
                Conexion = new SqlConnection(connectionString);
                Conexion.Open();
                MessageBox.Show("Conexion exitosa");
                return Conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
        }
        public void Cerrar()
        {
            Conexion.Close();
        }
    }
}
