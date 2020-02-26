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

using  System.Drawing.Imaging;

using  AForge.Video;

using AForge.Video.DirectShow;

namespace visitorApp
{
    public partial class v_home_ce : Form
    {

        Database miDB = new Database();

        //private string foto_perfil = "img/perfil.png";
        //private string path_foto = "";
        //public string tipo = "";

        //public string id_eliminar="";

        private string perfil;
        private string[] user;
        private string id_user;

        public v_home_ce(string[] userIn)
        {
            InitializeComponent();
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Width;

            int Width = screen.Bounds.Height;
            Console.WriteLine("heigth:" + Height + "  width:" + Width);

            this.pnl_v_home_ce.Width = Width;
            this.pnl_v_home_ce.Height = Height;
            user = userIn;
            perfil = user[3];
            id_user = user[6];
            cargarComponentes(perfil);
            //autoLlenarId(txt_id);
            //BuscarDispositivos();
            //btn_cam.Enabled = false;
           // btn_nuevo.Enabled = false ;

        }

        private void AbrirFormHija(object formhija)
        {
            if (this.pnl_contenedor.Controls.Count > 0)
            {
                this.pnl_contenedor.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_contenedor.Controls.Add(fh);
            this.pnl_contenedor.Tag = fh;
            fh.Show();
        }

        public void cargarComponentes(string perfil)
        {
            if (perfil == "admin")
            {
                btn_exportar.Visible = true;
            }
            else
            {
                btn_exportar.Visible = false;
            }
        }
       




        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

 
        private void pnl_indicente_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_reg_visita_Click(object sender, EventArgs e)
        {
            //pnl_visita.Visible = true;
            
            btn_reg_visita.BackColor=Color.DodgerBlue;
            btn_reg_incidente.BackColor = Color.Transparent;

            AbrirFormHija(new Form_Visita(id_user)) ;
            //pnl_incidente.Visible = false;
            //pnl_bbdd.Visible = false;
            
        }



        private void btn_reg_incidente_Click(object sender, EventArgs e)
        {
            //pnl_visita.Visible = false;
            //pnl_bbdd.Visible = false;
            btn_reg_incidente.BackColor = Color.DodgerBlue;
            btn_reg_visita.BackColor = Color.Transparent;
            AbrirFormHija(new Form_Incidencia(id_user));
            //pnl_incidente.Visible = true;

        }

        private void v_home_ce_Load(object sender, EventArgs e)
        {
            btn_reg_visita.PerformClick();

        }
        


       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Form_bbdd());
            //pnl_visita.Visible = false;
                                                        //pnl_incidente.Visible = false;
                                                        //pnl_bbdd.Visible = true;

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
 
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 



        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_v_home_ce_Paint(object sender, PaintEventArgs e)
        {
  
            
        }

        private void pbFotoUser_Click(object sender, EventArgs e)
        {

        }


        


    }
}
