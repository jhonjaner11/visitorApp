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

        private string perfil;
        private string[] user;
        private string id_user;

        //string[] userIn meter en home ce 
        public v_home_ce()
        {
            InitializeComponent();
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Width;

            int Width = screen.Bounds.Height;
            Console.WriteLine("heigth:" + Height + "  width:" + Width);

            this.pnl_v_home_ce.Width = Width;
            this.pnl_v_home_ce.Height = Height;
            //user = userIn;
            //perfil = user[3];
            //id_user = user[6];
            perfil = "admin";
            id_user = "2";
            cargarComponentes(perfil);

        }

        private void AbrirFormHija(object formhija)
        {
            if (this.pnl_contenedor.Controls.Count > 0)
            {
                Console.Write("Paneles a eliminar:");
                Console.WriteLine(this.pnl_contenedor.Controls.Count);
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

        private void btn_reg_visita_Click(object sender, EventArgs e)
        {

            btn_reg_visita.BackColor=Color.Black;
            btn_reg_incidente.BackColor = Color.Transparent;
            btn_exportar.BackColor = Color.Transparent;

            btn_reg_visita.Enabled = false;
            btn_reg_incidente.Enabled = true;
            btn_exportar.Enabled = true;

            AbrirFormHija(new Form_Visita(id_user)) ;

            
        }



        private void btn_reg_incidente_Click(object sender, EventArgs e)
        {
            btn_reg_incidente.BackColor = Color.Black;
            btn_reg_visita.BackColor = Color.Transparent;
            btn_exportar.BackColor = Color.Transparent;

            btn_reg_visita.Enabled = true;
            btn_reg_incidente.Enabled = false;
            btn_exportar.Enabled = true;

            AbrirFormHija(new Form_Incidencia(id_user));

        }

        private void v_home_ce_Load(object sender, EventArgs e)
        {
            btn_reg_visita.PerformClick();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btn_reg_incidente.BackColor = Color.Transparent;
            btn_reg_visita.BackColor = Color.Transparent;
            btn_exportar.BackColor = Color.Black;

            btn_reg_visita.Enabled = true;
            btn_reg_incidente.Enabled = true;
            btn_exportar.Enabled = false;

            AbrirFormHija(new Form_bbdd());


        }



    }
}
