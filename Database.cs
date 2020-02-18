using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace visitorApp
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source= visitorApp.sqlite3");
            if(!File.Exists("./visitorApp.sqlite3"))
            {
                
                SQLiteConnection.CreateFile("visitorApp.sqlite3");
                System.Console.WriteLine("cReado");
            }
            else
            {
                System.Console.WriteLine("ya fue creado");
            }
            
       
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        public string SelectUser(string us, string pw)
        {
            string usuario="";

            string query = "Select * from  usuario where login='" + us + "' and contraseña='" + pw + "'";
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    usuario = reader["Cargo"].ToString();
                }
                else
                {
                    usuario = "Errado";
                }

                //Console.WriteLine(reader["login"].ToString());
                reader.Close();
            }
            catch
            {
                usuario = "Errado";
            }
            
            return usuario;
        }

        public Boolean InsertVisita(string [] a)
        {
            Boolean respuesta;
            string id = a[0];
            string tp_id = a[1];
            string nombre = a[2];
            string apto = a[3]; 
            string vehiculo = a[4]; 
            string placa = a[5]; 
            string fecha = a[6]; 
            string path_foto = a[7];

            string query = "insert into visita (identificacion, tp_id, nombre, apto, vh, placa, fecha, path_foto) values  ('";
            string query2 = id+"','"+tp_id+"','"+nombre+ "','"+apto+ "','"+vehiculo+ "','";
            string query3 = placa + "','" + fecha + "','" + path_foto + "')";
            query = query + query2 + query3;
            try
            {
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch{
                respuesta = false;
            }

            return respuesta;
        }
    }
}
