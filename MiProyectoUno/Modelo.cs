using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    class Familia
    {
        public int idfamilia { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string parentesco { get; set; }
        public string ocupacion { get; set; }

        public DataTable LlenarFamilia()
        {
            MySqlConnection conexion = new MySqlConnection("server=10.120.3.200;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = conexion;

            conexion.Open();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            instruccion.CommandText = "select * from familia";
            Adaptador.SelectCommand = instruccion;
            DataSet DBAF = new DataSet();
            Adaptador.Fill(DBAF);
            DataTable Tabla = new DataTable();
            Tabla = DBAF.Tables[0];
            conexion.Close();
            return Tabla;
        }
    }
}
