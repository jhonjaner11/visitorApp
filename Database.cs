using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

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
            OpenConnection();
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
            CloseConnection();
            return usuario;
        }

        public bool ExistPerson(string id)
        {
            string query = "select * from persona where id=" + id;
            bool res = false;
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    id = reader["id"].ToString();
                    Console.WriteLine(id);
                    res = true;
                }
                else
                {
                    res = false;
                }

                //Console.WriteLine(reader["login"].ToString());
                reader.Close();
            }
            catch
            {
                res = false;
            }
            CloseConnection();
            return res;
        }

        public void InserTPerson(string []a)
        {
            string id=a[0];
            string nombre = a[1];
            string tipo_id = a[2];
            string path_foto = a[3];
            string telefono = a[4];
            string query = "insert into persona (id, nombre, tipo_id, path_foto, telefono) values ('";
            string query2 = id + "','" + nombre + "','" + tipo_id + "','" + path_foto + "','" + telefono + "')";
            query = query + query2;

            OpenConnection();
            try
            {
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                
            }
            catch
            {
                
            }
            CloseConnection();

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
            string telefono = a[8];
            string query = "";
          

            if (ExistPerson(id)){
                string queryV = "insert into visita (identificacion, fecha, apto, vh, placa) values  ('";
                string query2V = id + "','" +fecha + "','" + apto + "','" + vehiculo + "','" + placa + "')";
                query = queryV + query2V;
            }
            else
            {
                string[] arrPersona = { id, nombre, tp_id, path_foto, telefono };
                InserTPerson(arrPersona);

                string queryB = "insert into visita (identificacion, fecha, apto, vh, placa) values  ('";
                string query2B = id + "','" + fecha + "','" + apto + "','" + vehiculo + "','" + placa + "')";
                query = queryB + query2B;
            }


            try
            {

                OpenConnection();
                Console.WriteLine(query);
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                respuesta = true;
                CloseConnection();
            }
            catch(Exception e){
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        public bool InsertIncidente(string[] a)
        {
            bool res;
            string fecha = a[0];
            string desc = a[1];

            string query = "insert into incidente (fecha, descripcion ) values  ('"+fecha+"','"+desc+"')";
            try
            {
                OpenConnection();
                Console.WriteLine(query);
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                res = true;
                CloseConnection();
            }
            catch(Exception e)
            {
                Console.WriteLine("error: " + e);
                res = false;
            }


            return res;
        }

        public List<string> GetPersonas()
        {
            string query = "SELECT id as ID FROM persona";
            


            List<string> li = new List<string>();

       

           
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(reader["ID"].ToString());
                }
                reader.Close();

                //Console.WriteLine(reader["login"].ToString());
               
            }
            catch
            {
                
            }
            CloseConnection();

    
            return li;
        }

        
        public string[] GetOnlyPersona(string id)
        {
            string[] res = new string[5];
            string query = "Select * from persona where id="+id+"";
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    res[0] = reader["nombre"].ToString();
                    res[1] = reader["tipo_id"].ToString();
                    res[2] = reader["telefono"].ToString();
                    res[3] = reader["path_foto"].ToString();
                }
                else
                {
                    //usuario = "Errado";
                }

                //Console.WriteLine(reader["login"].ToString());
                reader.Close();
            }
            catch
            {
                //usuario = "Errado";
            }
            CloseConnection();


            return res;
        }

        public System.Data.DataTable LlenarTabla(System.Data.DataTable table, string tipo, string[] fecha) 
        {
            string query;
            string queryTime;
            if (tipo=="visita")
            {
                 query = "select p.nombre, v.identificacion, v.fecha, v.apto, v.vh, v.placa from visita v inner join persona p on v.identificacion = p.id ";
            }
            else if (tipo == "incidente")
            {
                 query = "select * from incidente ";
            }
            else if (tipo == "persona")
            {
                query = "select * from persona ";
            }
            else if (tipo == "usuario")
            {
                query = "select * from usuario ";
            }
            else
            {
                query = "select null";
            }
            
            if (fecha[0]!="")
            {
                //where(fecha >= '18/02/2020' AND fecha < '20/02/2020')
                queryTime = "where(fecha >= '"+ fecha[0] + "' AND fecha <= '"+ fecha[1] + "'+'+1 day') ";
            }
            else
            {
                queryTime = "";
            }
           
            SQLiteCommand comand = new SQLiteCommand(query+queryTime, myConnection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = (comand);
            //DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
            //DataGrid.DataSource = table;
        }

    }
}
