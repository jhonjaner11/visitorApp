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
    public partial class Form_Incidencia : Form
    {

        Database miDB = new Database();
        private string id_user;
        public Form_Incidencia(string usuario)
        {
            InitializeComponent();
            id_user = usuario;
            txt_fecha_i.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        private void btn_enviar_incidente_Click(object sender, EventArgs e)
        {
            string fecha = txt_fecha_i.Text;
            string desc = rtxt_desc.Text;
            string aptos = txt_aptos_i.Text;
            string[] arrIncidente = { fecha, desc, aptos, id_user };

            if (miDB.InsertIncidente(arrIncidente))
            {
                rtxt_desc.Text = "";
                txt_aptos_i.Text = "";
                MessageBox.Show("Incidente Registrado");

            }
            else
            {
                MessageBox.Show("Error registrando incidente");
            }


        }


    }
}
