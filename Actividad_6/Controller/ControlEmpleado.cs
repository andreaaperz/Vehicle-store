using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Actividad_6.BD;
using Actividad_6.Model;

namespace Actividad_6.Controller
{
    class ControlEmpleado
    {
        public ConexionSQLServer csql = null;
        public void InsertUser(Empleado u)
        {
            csql = new ConexionSQLServer();
            SqlCommand cmd = null;
            SqlConnection con = csql.Abrir();
            string query = "INSERT INTO Empleado(Nombre,ApMaterno, ApPaterno, IdUsuario)" +
                "VALUES(@Nombre, @ApMaterno, @ApPaterno, @IdUsuario)";
            cmd = new SqlCommand(query, con);

            //Estamos especificando el tipo de dato del parametro
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApMaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApPaterno", SqlDbType.VarChar);
            //cmd.Parameters.Add("@FechaIngreso", SqlDbType.DateTime);
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int);

            //Asignar valores a los parametros
            cmd.Parameters["@Nombre"].Value = u.Nombre;
            cmd.Parameters["@ApMaterno"].Value = u.ApMaterno;
            cmd.Parameters["@ApPaterno"].Value = u.ApPaterno;
            //cmd.Parameters["@FechaIngreso"].Value = u.FechaIngreso;
            cmd.Parameters["@IdUsuario"].Value = u.IdUsuario;

            //EjecutarComando
            int R = cmd.ExecuteNonQuery();
            if (R > 0)
            {
                MessageBox.Show("Insersion exitosa");
            }
            else
                MessageBox.Show("No se logró la insercion");

            csql.Cerrar();
        }
    }
}
