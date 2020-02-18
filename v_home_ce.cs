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
    public partial class v_home_ce : Form
    {

        Database miDB = new Database();
        public v_home_ce()
        {
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_vehiculo.Checked)
            {
                pnl_vehiculo.Visible = true;
            }
            else
            {
                pnl_vehiculo.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pnl_visita_Paint(object sender, PaintEventArgs e)
        {
            txt_fecha_v.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_indicente_Paint(object sender, PaintEventArgs e)
        {
            txt_fecha_i.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btn_reg_visita_Click(object sender, EventArgs e)
        {
            pnl_visita.Visible = true;
            pnl_incidente.Visible = false;
        }

        private void btn_reg_incidente_Click(object sender, EventArgs e)
        {
            pnl_visita.Visible = false;
            pnl_incidente.Visible = true;
        }

        private void v_home_ce_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txt_numero.Text;
            string tp_id = comboBox_id.Text;
            string nombre = txt_nombre.Text;
            string apto = txt_apto.Text;
            string vh = comboBox_tp_Vh.Text;
            string placa = txt_placa.Text;
            string fecha = txt_fecha_v.Text;
            string path_foto = "/path";

            string[] arrVisita = {id, tp_id, nombre, apto, vh,placa, fecha, path_foto};
            miDB.OpenConnection();
            Console.WriteLine("entrea");
            Boolean resultado = miDB.InsertVisita(arrVisita);

            Console.WriteLine(resultado);
            miDB.CloseConnection();
            Console.WriteLine("ddbb close insert visita");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
