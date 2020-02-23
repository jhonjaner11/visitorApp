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
    public partial class RegistroModificar : Form
    {
        string tipo;
        string id;
        Database miDB3 = new Database();
        public RegistroModificar(string tipoB , string idB)
        {
            InitializeComponent();
            tipo = tipoB;
            id = idB;
            Console.WriteLine("id: " + id);
            if (tipo == "usuario")
            {
                activarUsuario(id);

            }
            else if (tipo=="persona"){

                activarPersona(id);
               

            }
            else if (tipo == "incidente")
            {
                activarIncidente(id);
                
            }
            else 
            {
                activarVisita(id);
                
            }

        }

        private void activarVisita(string id)
        {
            txt_visita_id.Text = id;
            
            //txt_visita.Enabled = false;

            pnl_incidente.Visible = false;
            pnl_persona.Visible = false;
            pnl_visita.Visible = true;
            pnl_usuario.Visible = false;


            string[] res = miDB3.GetVisita(id);

            txt_visita_identificacion.Text = res[0];
            txt_visita_fecha.Text = res[1];
            txt_visita_apto.Text = res[2];
            cbx_visita_vh.Text = res[3];
            txt_visita_placa.Text = res[4];

            txt_visita_fecha.Enabled = false;



        }
        private void activarPersona(string id)
        {

            txt_id_p.Text = id;
            txt_id_p.Enabled = false;

            pnl_incidente.Visible = false;
            pnl_persona.Visible = true;
            pnl_visita.Visible = false;
            pnl_usuario.Visible = false;


            string[] res = miDB3.GetOnlyPersona(id);

            txt_nombre_p.Text = res[0];
            cbx_tipoid_p.Text = res[1];
            txt_telefono_p.Text = res[2];
            

        }
        private void activarUsuario(string id)
        {

            txt_id_u.Text = id;
            txt_id_u.Enabled = false;

            pnl_incidente.Visible = false;
            pnl_persona.Visible = false;
            pnl_visita.Visible = false;
            pnl_usuario.Visible = true;
            

            string[] res = miDB3.GetUsuario(id);

            txt_login_u.Text = res[0];
            txt_nombre_u.Text = res[1];
            txt_contraseña_u.Text = res[2];
            cbx_cargo.Text = res[3];


            

        }
        private void activarIncidente(string id)
        {
            txt_id_incidente.Text = id;

            pnl_incidente.Visible = true;
            pnl_persona.Visible = false;
            pnl_visita.Visible = false;
            pnl_usuario.Visible = false;


            string[] res = miDB3.GetIncidente(id);
            txt_fecha_incidente.Text = res[1];
            rtxt_descripcion.Text = res[2];

            txt_fecha_incidente.Enabled = false;
            txt_id_incidente.Enabled = false;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroModificar_Load(object sender, EventArgs e)
        {

        }

        private void btn_modificar_usuario_Click(object sender, EventArgs e)
        {
            string login = txt_login_u.Text;
            string contraseña = txt_contraseña_u.Text;
            string nombre = txt_nombre_u.Text;
            string cargo = cbx_cargo.Text;
            string id = txt_id_u.Text;

            string[] arr = { login, contraseña, nombre, cargo, id };
  
            try
            {
                if (miDB3.UpdateUsuario(arr))
                {
                    MessageBox.Show("Usuario Modificado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar");
                }
               
               
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: "+ae);
                Console.WriteLine("error: " + ae);
            }


        }

        private void btn_modificar_persona_Click(object sender, EventArgs e)
        {
            string id = txt_id_p.Text;
            string nombre = txt_nombre_p.Text;
            string tipo_id = cbx_tipoid_p.Text;
            string telefono = txt_telefono_p.Text;
            

            string[] arr = { nombre, tipo_id, telefono, id };


            try
            {
                if (miDB3.UpdatePersona(arr))
                {
                    MessageBox.Show("Persona Modificado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar");
                }


            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae);
                Console.WriteLine("error: " + ae);
            }
        }

        private void pnl_visita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_modificar_visita_Click(object sender, EventArgs e)
        {
            string id_visitante = txt_visita_identificacion.Text;
            string apto = txt_visita_apto.Text;
            string vh = cbx_visita_vh.Text;
            string placa = txt_visita_placa.Text;
            string id = txt_visita_id.Text;

            Console.WriteLine("id visita: " + id);



            string[] arr = {id_visitante,apto,vh,placa,id };


            try
            {
                if (miDB3.UpdateVisita(arr))
                {
                    MessageBox.Show("Visita Modificada.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar");
                }


            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae);
                Console.WriteLine("error: " + ae);
            }
        }

        private void btn_modificar_incidente_Click(object sender, EventArgs e)
        {
            string id= txt_id_incidente.Text;
            string desc = rtxt_descripcion.Text;

            string[] arr = { id, desc};


            try
            {
                if (miDB3.UpdateIncidente(arr))
                {
                    MessageBox.Show("Incidente Modificado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar");
                }


            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae);
                Console.WriteLine("error: " + ae);
            }
        }
    }
}
