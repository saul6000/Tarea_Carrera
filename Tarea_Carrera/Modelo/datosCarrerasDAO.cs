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
        private static string cadenaConexion = "Server=JOHNDAY;database=TI2020;user id=sa; password=123456;";
        public static int creacion(datosCarrera datosCarrera)
        {
          
            //1 Configurar la  conexion de datos con una fuente de datos 
            // string cadenaConexion = "Server=JOHNDAY;database=TI2020;user id=sa; password=123456;";
            //definir un objeto tipo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);
            //2 Definir la opercion a realizar en el motor BDD
            //Escribir sentecia SQL
            string sql = "insert into DatosCarrera(codCarrera,nombreCarrera,tituloOtorga,duracion," + "Facultad) values(@codigo,@carrera,@otorga,@duracion,@facultad)";
            // definir un comando para ejecutar esa sentencia sql (operacion a realizar)
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text; //valor por defecto 
            comando.Parameters.AddWithValue("@codigo", datosCarrera.Codigo);
            comando.Parameters.AddWithValue("@carrera", datosCarrera.Carrera);
            comando.Parameters.AddWithValue("@otorga", datosCarrera.otorga);
            comando.Parameters.AddWithValue("@duracion", datosCarrera.duracion);
            comando.Parameters.AddWithValue("@facultad", datosCarrera.facultad);


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
            string sql = "select  codCarrera [Codigo de carrera],nombreCarrera[Nombre de Carrera],tituloOtorga[Titulo que otorga],duracion Duracion," + "Facultad,fechaCreacion[Fecha de creacion] " + "from DatosCarrera " +
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
            string sql = "select codCarrera " + "from DatosCarrera " + "where codCarrera=@codigo";
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
        public static int btbdelete(string codigo)

        {
            SqlConnection conn = new SqlConnection(cadenaConexion);


            string sql = "delete from DatosCarrera  where codCarrera=@codigo";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@codigo", codigo);
            conn.Open();
            int x = comando.ExecuteNonQuery();
            conn.Close();
            return x;

        }
        public static datosCarrera getcarrera(String scedula)
        {

            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "select codCarrera,nombreCarrera,tituloOtorga,duracion,Facultad " +
                "from DatosCarrera " +
                "where codCarrera=@codigo " +
                "order by codCarrera,nombreCarrera";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@codigo", scedula);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            datosCarrera carrera = new datosCarrera();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {

                    carrera.Codigo = fila["codCarrera"].ToString();
                    carrera.Carrera = fila["nombreCarrera"].ToString();
                    carrera.otorga = fila["tituloOtorga"].ToString();
                    carrera.duracion = int.Parse(fila["duracion"].ToString());
                    carrera.facultad = fila["Facultad"].ToString();

                    break; //abandonar bucle


                }
            }
            return carrera;
        }
        public static int update(datosCarrera datosCarrera)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);


            string sql = " UPDATE DatosCarrera SET nombreCarrera=@carrera, tituloOtorga=@otorga, duracion=@duracion,Facultad=@Facultad WHERE codCarrera=@Codigo";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@Codigo", datosCarrera.Codigo);
            comando.Parameters.AddWithValue("@carrera", datosCarrera.Carrera);
            comando.Parameters.AddWithValue("@otorga", datosCarrera.otorga);
            comando.Parameters.AddWithValue("@duracion", datosCarrera.duracion);
            comando.Parameters.AddWithValue("@Facultad", datosCarrera.facultad);

            conn.Open();
            int x = comando.ExecuteNonQuery();
            conn.Close();
            return x;
        }
    }
}
