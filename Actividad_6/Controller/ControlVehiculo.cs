using System;
using System.Collections;
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
    class ControlVehiculo
    {
        public ConexionSQLServer csql = null;
        public void InsertUser(Vehiculo u)
        {
            csql = new ConexionSQLServer();
            SqlCommand cmd = null;
            SqlConnection con = csql.Abrir();
            string query = "INSERT INTO Vehiculo(NumSerie,Precio, Version_, Color, Tipo, CodigoCat)" +
                "VALUES(@NumSerie,@Precio, @Version_, @Color, @Tipo, @CodigoCat)";
            cmd = new SqlCommand(query, con);

            //Estamos especificando el tipo de dato del parametro
            cmd.Parameters.Add("@NumSerie", SqlDbType.VarChar);
            cmd.Parameters.Add("@Precio", SqlDbType.VarChar);
            cmd.Parameters.Add("@Version_", SqlDbType.VarChar);
            cmd.Parameters.Add("@Color", SqlDbType.VarChar);
            cmd.Parameters.Add("@Tipo", SqlDbType.VarChar);
            cmd.Parameters.Add("@CodigoCat", SqlDbType.Int);

            //Asignar valores a los parametros
            cmd.Parameters["@NumSerie"].Value = u.NumSerie;
            cmd.Parameters["@Precio"].Value = u.Precio;
            cmd.Parameters["@Version_"].Value = u.Version;
            cmd.Parameters["@Color"].Value = u.Color;
            cmd.Parameters["@Tipo"].Value = u.Tipo;
            cmd.Parameters["@CodigoCat"].Value = u._Categoria.Codigo;

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

        internal IEnumerable FindMarca(string v)
        {
            throw new NotImplementedException();
        }
    }
    }
