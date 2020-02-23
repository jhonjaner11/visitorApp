using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visitorApp
{
    public partial class RegistroNuevo : Form
    {
        private string tipo;
        Database miDB2 = new Database();
        public RegistroNuevo(string tipoF)
        {
            InitializeComponent();
            cbx_cargo.SelectedItem = "Celador";
            tipo = tipoF;
            if (tipo=="usuario")
            {
                pnl_usuario.Visible = true;
                pnl_persona.Visible = false;
            }
            else
            {
                pnl_usuario.Visible = false;
                pnl_persona.Visible = true;
            }

        }

        private void RegistroNuevo_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_usuario_Click(object sender, EventArgs e)
        {
            string login = txt_login_u.Text;
            string contraseña = txt_contraseña_u.Text;
            string cargo = cbx_cargo.Text;
            string nombre = txt_nombre_u.Text;
            string[] arrUsuario = { login, contraseña, cargo, nombre };
            try
            {
                miDB2.InsertUsuario(arrUsuario);
                MessageBox.Show("Usuario almacenado.");
                this.Close();
            }
            catch(Exception ae)
            {
                MessageBox.Show("Usuario almacenado.");
                Console.WriteLine("error: " + ae);
            }
          

        }

        private void btn_nuevo_persona_Click(object sender, EventArgs e)
        {
            string id = txt_id_p.Text;
            string nombre = txt_nombre_p.Text;
            string tipoId = cbx_tipoid_p.Text;
            string telefono = txt_telefono_p.Text;
            string path_foto = "";
            
            if (miDB2.ExistPerson(id))
            {
                MessageBox.Show("Visitante con id: "+id+" ya existe.");
            }
            else
            {
                string[] arrPersona = { id, nombre, tipoId, path_foto, telefono };
                try
                {
                    miDB2.InsertPerson(arrPersona);
                    MessageBox.Show("Visitante con id: " + id + " ya existe.");
                }
                catch (Exception ae)
                {
                    MessageBox.Show("Error creando usuario");
                    Console.WriteLine("error: " + ae);
                }




            }
        }
    }
}
