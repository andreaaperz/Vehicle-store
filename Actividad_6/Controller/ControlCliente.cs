using Actividad_6.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad_6.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Actividad_6.Controller
{
    class ControlCliente
    {
        public ConexionSQLServer csql = null;
        public void InsertUser(Cliente u)
        {
            csql = new ConexionSQLServer();
            SqlCommand cmd = null;
            SqlConnection con = csql.Abrir();
            string query = "INSERT INTO Cliente(Nombre,ApMaterno, ApPaterno, Email, IdUsuario)" +
                "VALUES(@Nombre, @ApMaterno, @ApPaterno, @Email, @IdUsuario)";
            cmd = new SqlCommand(query, con);

            //Estamos especificando el tipo de dato del parametro
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApMaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApPaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int);

            //Asignar valores a los parametros
            cmd.Parameters["@Nombre"].Value = u.Nombre;
            cmd.Parameters["@ApMaterno"].Value = u.ApMaterno;
            cmd.Parameters["@ApPaterno"].Value = u.ApPaterno;
            cmd.Parameters["@Email"].Value = u.Email;
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
