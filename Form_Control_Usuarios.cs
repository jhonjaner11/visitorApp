using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace visitorApp
{
    public partial class Form_Control_Usuarios : Form
    {
        Database miDB = new Database();
        string tipo = "usuario";
        
        string foto_perfil = "iconos/visitante-icon.png";
        string path;
        string id_user;

        public Form_Control_Usuarios()
        {
            InitializeComponent();
            MostrarTabla(tipo);
            restringir();
        }

        private void restringir()
        {
            txt_cargo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_contraseña.Enabled = false;
            txt_cedula.Enabled = false;
            txt_telefono.Enabled = false ;
        }


        //pnl bbdd
        public void MostrarTabla(string tipo)
        {
            btn_modificar.Enabled = false;
            string time_ini;
            string time_fin;
            string[] arrfecha;
            arrfecha = new string[2] { "", "" };

            //Console.WriteLine("hey: " + arrfecha[0] + arrfecha[1]);
            DataTable table = new DataTable();
      
            dt.DataSource = (miDB.LlenarTabla(table, tipo, arrfecha));
            //dt.CurrentRow.Selected = false;
        }

        private void llenar_usuario(string id)
        {
            
            string[] res = miDB.GetUsuario(id);

            if (res[0]!="Errado")
            {
                txt_cargo.Text = res[3];
                txt_nombre.Text = res[1];
                txt_contraseña.Text = res[2];
                txt_cedula.Text = res[6];
                txt_telefono.Text = res[4];
                path = res[5];
                id_user = res[0];
            }

            poner_imagen(path);
            
        }

        private void poner_imagen(string s)
        {
            try
            {
                Image file;
                file = Image.FromFile(s);
                pb.Image = file;
                //btnIniciar.Enabled = false;
            }
            catch
            {
                Console.WriteLine("No hay registros con ese ID");
                pb.Image = Image.FromFile(foto_perfil);
                //btnIniciar.Enabled = true;
            }
        }
        private void dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
            btn_modificar.Enabled = true;
            id_user = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
            llenar_usuario(id_user);

        }

        private void limpiarCaja()
        {
            txt_cargo.Text = "";
            txt_nombre.Text = "";
            txt_contraseña.Text = "";
            txt_cedula.Text = "";
            txt_telefono.Text = "";
            path = "";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_modificar.Enabled = false;
            limpiarCaja();
            
            poner_imagen(path);
            liberarCaja();
            id_user = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string[] arrUsuario = { id_user, txt_contraseña.Text, txt_cargo.Text, txt_nombre.Text, txt_telefono.Text, path , txt_cedula.Text };
            if (btn_modificar.Enabled==true)
            {
                
                try
                {
                    miDB.UpdateUsuario(arrUsuario);
                    MessageBox.Show("Usuario almacenado.");
                    this.Close();
                }
                catch (Exception ae)
                {
                    MessageBox.Show("Usuario almacenado.");
                    Console.WriteLine("error: " + ae);
                }
            }
            else
            {
                try
                {
                    string[] arrUsuario2 = { txt_cedula.Text ,txt_contraseña.Text, txt_cargo.Text, txt_nombre.Text, txt_telefono.Text, path };
                    miDB.InsertUsuario(arrUsuario2);
                    MessageBox.Show("Usuario almacenado.");
                    this.Close();
                }
                catch (Exception ae)
                {
                    MessageBox.Show("Usuario almacenado.");
                    Console.WriteLine("error: " + ae);
                }
            }
            MostrarTabla(tipo);


        }

        private void liberarCaja()
        {
            txt_cargo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_contraseña.Enabled = true;
            txt_cedula.Enabled = true;
            txt_telefono.Enabled = true;
            btn_tomarfoto.Enabled = true;
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {

            liberarCaja();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
 
            if (miDB.DeleteRegistro(id_user, tipo))
            {
                dt.Rows.Remove(dt.CurrentRow);
            }
            else
            {
                MessageBox.Show("No se pudo borrar. ");
            }
        }

        private void btn_tomarfoto_Click(object sender, EventArgs e)
        {
            //this.Hide();
            pb.Image = Image.FromFile(foto_perfil);
            string id = txt_cedula.Text;
            string lugar = "usuarios";
            Form frm = new Form_Tomar_Foto(id,lugar);
            frm.ShowDialog();
            path = "usuarios/" + id + ".png";
            if (File.Exists(path))
            {
                pb.Image = Image.FromFile(path);
            }
            else
            {
                pb.Image = Image.FromFile(foto_perfil);
            }
        }

        //pnl bbdd




    }
}
