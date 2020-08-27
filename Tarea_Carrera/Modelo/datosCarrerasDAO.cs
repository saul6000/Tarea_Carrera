using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea_Carrera.Modelo
{
    class datosCarrerasDAO
    {
        private static string cadenaConexion = "Server=JOHNDAY;database=MendozaSaulP3;user id=sa; password=123456;";
        public static int creacion(datosCarrera datosCarrera)
        {
          
            //1 Configurar la  conexion de datos con una fuente de datos 
            // string cadenaConexion = "Server=JOHNDAY;database=TI2020;user id=sa; password=123456;";
            //definir un objeto tipo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);
            //2 Definir la opercion a realizar en el motor BDD
            //Escribir sentecia SQL
            string sql = "insert into Mendoza_Docentes(codDocente,apellidos,nombres,codDependencia," + "fechaIngreso) values(@codigo,@apellidos,@nombres,@Dependencia,@ingreso)";
            // definir un comando para ejecutar esa sentencia sql (operacion a realizar)
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text; //valor por defecto 
            comando.Parameters.AddWithValue("@codigo", datosCarrera.Docente);
            comando.Parameters.AddWithValue("@apellidos", datosCarrera.apellidos);
            comando.Parameters.AddWithValue("@nombres", datosCarrera.nombres);
            comando.Parameters.AddWithValue("@dependencia", datosCarrera.codDependencia);
            comando.Parameters.AddWithValue("@ingreso", datosCarrera.fechaIngreso);


            //3 Se habre la conexion y se ejecuta el comando 
            conn.Open();

            int x = comando.ExecuteNonQuery();
            //4 cerra la conexion 
            conn.Close();

            return x;
        }
        public static DataTable getAll()
        {

            //1. definir y configurar conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);
            //2. Definir y Cinfigurar la operacion a realizar en el motor de BDD 
            //escribir sentencia sql
            string sql = "select  codDocente[Codigo de carrera],apellidos + nombres [Nombre del docente],codDependencia[Dependencia],fechaIngreso)"  + "from Mendoza_Docentes " +
                "order by codCarrera,nombreCarrera";
            //2.1 Definir un adptador de datos: es un puente que permite pasa los datos de muestra , hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            //3 recuperamos los datos 
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }
        public static Boolean existecodigo(string codigo)
        {

            //1. definir y configurar conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);
            //2. Definir y Cinfigurar la operacion a realizar en el motor de BDD 
            //escribir sentencia sql
            string sql = "select codDocente " + "from Mendoza_Docentes " + "where codDocente=@codigo";
            //2.1 Definir un adptador de datos: es un puente que permite pasa los datos de muestra , hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@codigo", codigo);
            //3 recuperamos los datos 
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Boolean existe = false;
            if (dt.Rows.Count > 0)
                existe = true;
            return existe;

        }
    }
}
