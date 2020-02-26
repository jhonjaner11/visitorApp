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
            myConnection = new SQLiteConnection("Data Source=bd/visitorApp.sqlite3");
           
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
                    usuario = reader["id"].ToString();
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

        public bool ExistInVisita(string id)
        {
            string query = "select * from visita where persona='"+id+"'";
            bool res = false;
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    id = reader["id"].ToString();
                    Console.WriteLine("si existe: "+id);
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

        public void InsertPerson(string []a)
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
            string id_user = a[9];
            string query = "";
          

            if (ExistPerson(id)){
                string queryV = "insert into visita (persona, fecha, apto, vh, placa, usuario) values  ('";
                string query2V = id + "','" +fecha + "','" + apto + "','" + vehiculo + "','" + placa + "'," + id_user + ")";
                query = queryV + query2V;
            }
            else
            {
                string[] arrPersona = { id, nombre, tp_id, path_foto, telefono };
                InsertPerson(arrPersona);

                string queryB = "insert into visita (persona, fecha, apto, vh, placa, usuario) values  ('";
                string query2B = id + "','" + fecha + "','" + apto + "','" + vehiculo + "','" + placa + "',"+id_user+")";
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
            string aptos = a[2];
            string usuario = a[3];

            string query = "insert into incidente (fecha, descripcion , apto, usuario) values  ('"+fecha+"','"+desc+"','"+aptos+"',"+usuario+")";
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

        public bool InsertUsuario(string[] a)
        {
            bool res;
            string login = a[0];
            string contraseña= a[1];
            string cargo = a[2];
            string nombre = a[3]; 

            string query = "insert into usuario (login, contraseña, cargo, nombre ) values  ('";
            string query2 = login+"','"+contraseña+ "','"+cargo+"','"+nombre+"')";
            query = query + query2;
            try
            {
                OpenConnection();
                Console.WriteLine(query);
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                res = true;
                CloseConnection();
            }
            catch (Exception e)
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

        public string[] GetIncidente(string id)
        {
            string[] res = new string[3];
            string query = "Select * from incidente where id=" + id + "";
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    res[0] = reader["id"].ToString();
                    res[1] = reader["fecha"].ToString();
                    res[2] = reader["descripcion"].ToString();
                    
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

        public string[] GetUsuario(string id)
        {
            string[] res = new string[7];
            string query = "Select * from usuario where id=" + id + "";
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    res[0] = reader["login"].ToString();
                    res[1] = reader["nombre"].ToString();
                    res[2] = reader["contraseña"].ToString();
                    res[3] = reader["cargo"].ToString();
                    res[4] = reader["telefono"].ToString();
                    res[5] = reader["path_foto"].ToString();
                    res[6] = reader["id"].ToString();
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

        public string[] GetVisita(string id)
        {
            string[] res = new string[6];
            string query = "Select * from visita where id=" + id + "";
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    res[0] = reader["persona"].ToString();
                    res[1] = reader["fecha"].ToString();
                    res[2] = reader["apto"].ToString();
                    res[3] = reader["vh"].ToString();
                    res[4] = reader["placa"].ToString();
                    res[5] = reader["usuario"].ToString();
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
                query = "select v.id, p.nombre as 'Nombre Visitante', v.persona, v.fecha, v.apto, v.vh, v.placa, u.nombre as usuario  ";
                query = query + "from visita v left join persona p on v.persona = p.id ";
                query = query + "left join usuario u on v.usuario = u.id ";
            }
            else if (tipo == "incidente")
            {
                 query = "select i.id, i.fecha, i.descripcion, i.apto, u.nombre ";

                query = query + "from incidente i ";
                query = query + "left join usuario u on i.usuario = u.id";

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
            adapter.Fill(table);
            return table;

        }

        public bool DeleteRegistro(string id, string tipo)
        {
            bool res=false;
            string query = "delete from " + tipo;
            string queryWhere;
            if (tipo=="usuario")
            {
                queryWhere = " where id='" + id + "'";
            }
            else if (tipo == "incidente")
            {
                queryWhere = " where id='" + id + "'";
            }
            else if (tipo == "visita")
            {
                queryWhere = " where id='" + id + "'";
            }
            else 
            {

                queryWhere = " where id='" + id + "'";
            }
            query = query + queryWhere;
            //DELETE FROM table_name WHERE condition;
            Console.WriteLine(query);

            OpenConnection();
            try
            {
                if (tipo=="persona")
                {
                    Console.Write("entro a persona!");
                    if (!ExistInVisita(id))
                    {
                        Console.Write("no existe en visita");
                        OpenConnection();
                        SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                        comando.ExecuteNonQuery();
                        CloseConnection();
                        res = true;
                    }
                    else
                    {
                        Console.Write("existe en visita");
                        res = false;
                    }
                   
                }
                else 
                {
                    OpenConnection();
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    CloseConnection();
                    res = true;
                }
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                res = false;
            }
            CloseConnection();

            return res;
        }

        public bool UpdateUsuario(string[] a)
        {

            bool res;

            
            string login = a[0];
            string contraseña = a[1];
            string nombre = a[2];
            string cargo = a[3];
            string id = a[4];

            string query = "update usuario set ";
            query = query+ " login='" +login+"',";
            query = query+ "contraseña='" +contraseña+"',";
            query = query+ "cargo='" +cargo+"',";
            query = query+"nombre='" +nombre+"' ";
            query = query+" where id=" +id;
            Console.WriteLine(query);


            try
            {
                OpenConnection();
                Console.WriteLine(query);
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                res = true;
                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                res = false;
            }


            return res;
        }

        public bool UpdateIncidente(string[] a)
        {

            bool res;


            string id = a[0];
            string descripcion = a[1];


            string query = "update incidente set ";
            query = query + " descripcion='" + descripcion + "'";

            query = query + " where id=" + id;
            Console.WriteLine(query);


            try
            {
                OpenConnection();
                Console.WriteLine(query);
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                res = true;
                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                res = false;
            }


            return res;
        }

        public bool UpdatePersona(string[] a)
        {

            bool res;


            string nombre = a[0];
            string tipoID = a[1];
            string telefono = a[2];
            string id = a[3];

            string query = "update persona set ";
            query = query + " nombre='" + nombre + "',";
            query = query + "tipo_id='" + tipoID + "',";
            query = query + "telefono='" + telefono + "' ";
            query = query + " where id=" + id;
            Console.WriteLine(query);


            try
            {
                OpenConnection();
                Console.WriteLine(query);
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                res = true;
                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                res = false;
            }


            return res;
        }

        public bool UpdateVisita(string[] a)
        {

            bool res;


            string id_visitante = a[0];
            string apto = a[1];
            string vh = a[2];
            string placa = a[3];
            string id = a[4];

            string query = "update visita set ";
            query = query + " persona='" + id_visitante + "',";
            query = query + "apto='" + apto + "',";
            query = query + "vh='" + vh + "',";
            query = query + "placa='" + placa + "' ";
            query = query + " where id=" + id;
            


            try
            {
                OpenConnection();
                Console.WriteLine(query);
                SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                comando.ExecuteNonQuery();
                res = true;
                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                res = false;
            }


            return res;
        }


        
    }
}
