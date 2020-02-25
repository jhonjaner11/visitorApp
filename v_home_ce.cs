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

        private string foto_perfil = "img/perfil.png";
        private string path_foto = "";
        public string tipo = "";

        public string id_eliminar="";

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
            autoLlenarId(txt_id);
            //BuscarDispositivos();
            btn_cam.Enabled = false;
            btn_nuevo.Enabled = false ;

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
        public void autoLlenarId(TextBox cajaTexto)
        {
            foreach (string color in miDB.GetPersonas())
            {
                Console.WriteLine(color);
                cajaTexto.AutoCompleteCustomSource.Add(color);
            }

        }

        public void autoLlenarPersona(string id, TextBox cjNombre, ComboBox cjTipoId, TextBox cjTelefono, PictureBox PathFoto)
        {
            string path;
            string[] res = miDB.GetOnlyPersona(id);
            Console.WriteLine(res);
            cjNombre.Text = res[0];
            cjTipoId.Text = res[1];
            cjTelefono.Text = res[2];
            //cjPathFoto.Text = res[3];
            Console.WriteLine("res: "+res[3]);
            pbFotoUser.Image = Image.FromFile(foto_perfil);
            if (res[3] != "")
            {
                try
                {
                    Image file;
                    file = Image.FromFile(res[3]);
                    pbFotoUser.Image = file;
                    //btnIniciar.Enabled = false;
                }
                catch
                {
                    Console.WriteLine("No hay registros con ese ID");
                    pbFotoUser.Image = Image.FromFile(foto_perfil);
                    //btnIniciar.Enabled = true;
                }

            }
            else
            {
                pbFotoUser.Image = Image.FromFile(foto_perfil);
                //btnIniciar.Enabled = true;
            }

            
        }

        public void MostrarTabla(string tipo)
        {
            string time_ini;
            string time_fin;
            string[] arrfecha;
            if (chk_Box_filtro.Checked)
            {
                time_ini = time_inicio.Value.Date.ToString();
                time_fin = time_final.Value.Date.ToString();
                arrfecha = new string[2] { time_ini, time_fin };
            }
            else
            {
                arrfecha = new string[2] { "", "" };
            }
            Console.WriteLine("hey: " + arrfecha[0] + arrfecha[1]);
            DataTable table = new DataTable();
            //string tipo = "visita";
            dt.DataSource = (miDB.LlenarTabla(table, tipo, arrfecha));
        }

        private void CopiarGrilla()
        {
            dt.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dt.MultiSelect = true;
            dt.SelectAll();
            DataObject dataObj = dt.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            dt.MultiSelect = false;
            dt.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
        }


        private void ExportarAExcel()
        {
            this.CopiarGrilla();

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object valor = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(valor);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            MessageBox.Show("Exportación finalizada");
        }


        private void limpiar_pnl_visita()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_apto.Text = "";
            comboBox_tp_Vh.Text = "";
            txt_placa.Text = "";
            txt_telefono.Text= "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_vehiculo.Checked)
            {
                //pnl_vehiculo.Visible = true;
                lbl_placa.Visible = true;
                lbl_tipo.Visible = true;
                comboBox_tp_Vh.Visible = true;
                txt_placa.Visible = true;
            }
            else
            {
                lbl_placa.Visible = false;
                lbl_tipo.Visible = false;
                comboBox_tp_Vh.Visible = false;
                txt_placa.Visible = false;
            }
        }


        private void txt_numero_TextChanged(object sender, EventArgs e)
        {
            
            autoLlenarPersona(txt_id.Text, txt_nombre, comboBox_id, txt_telefono, pbFotoUser);
            if (txt_id.Text != "")
            {
                btn_cam.Enabled = true;
            }
            else
            {
                btn_cam.Enabled = false;
            }
              
           
        }

        
        private void pnl_visita_Paint(object sender, PaintEventArgs e)
        {
            txt_fecha_v.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            comboBox_id.SelectedIndex = 0;
        }

        
       

        private void pnl_indicente_Paint(object sender, PaintEventArgs e)
        {
            txt_fecha_i.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btn_reg_visita_Click(object sender, EventArgs e)
        {
            pnl_visita.Visible = true;
            
            btn_reg_visita.BackColor=Color.DodgerBlue;
            btn_reg_incidente.BackColor = Color.Transparent;
            pnl_incidente.Visible = false;
            pnl_bbdd.Visible = false;
            
        }

        /* private void apagar_cam()
        {
            TerminarFuenteDeVideo();
            btnIniciar.Text = "Detener";
            inicio_cam();
        } */

        private void btn_reg_incidente_Click(object sender, EventArgs e)
        {
            pnl_visita.Visible = false;
            pnl_bbdd.Visible = false;
            btn_reg_incidente.BackColor = Color.DodgerBlue;
            btn_reg_visita.BackColor = Color.Transparent;
            pnl_incidente.Visible = true;
       
        }

        private void v_home_ce_Load(object sender, EventArgs e)
        {
            btn_reg_visita.PerformClick();

        }
        
        //verifica si el id, el nombre, o el apto estan en blanco
        //si alguno esta en blanco, devolvera false. 
        public bool verificar()
        {
            bool res=true;

            if (txt_id.Text=="")
            {
                res = false;
            }
            if (txt_nombre.Text == "")
            {
                res = false;
            }
            if (txt_apto.Text == "")
            {
                res = false;
            }
            

            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (verificar())
            {
                string id = txt_id.Text;
                string tp_id = comboBox_id.Text;
                string nombre = txt_nombre.Text;
                string apto = txt_apto.Text;
                string vh = comboBox_tp_Vh.Text;
                string placa = txt_placa.Text;
                string fecha = txt_fecha_v.Text;
                Console.WriteLine(id_user);

                
                string telefono = txt_telefono.Text;
                string[] arrVisita = { id, tp_id, nombre, apto, vh, placa, fecha, path_foto, telefono , id_user};
              
                Console.WriteLine("entra insert visita");
                Boolean resultado = miDB.InsertVisita(arrVisita);

                Console.WriteLine(resultado);
       
                Console.WriteLine("ddbb close insert visita");
                limpiar_pnl_visita();
                MessageBox.Show("Visita registrada");
            }
            else
            {
                MessageBox.Show("Faltan Datos por llenar");
            }
           


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_incidente_Click(object sender, EventArgs e)
        {
            string fecha = txt_fecha_i.Text;
            string desc = rtxt_desc.Text;
            string aptos = txt_aptos_i.Text;
            string[] arrIncidente = { fecha, desc , aptos, id_user};
         
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            pnl_visita.Visible = false;
            pnl_incidente.Visible = false;
            pnl_bbdd.Visible = true;
            
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

        private void btn_mostrar_incidencias(object sender, EventArgs e)
        {
            chk_Box_filtro.Visible = true;
            tipo = "incidente";
            MostrarTabla(tipo);
            btn_nuevo.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_bajar_visitas_Click(object sender, EventArgs e)
        {
            tipo = "visita";
            MostrarTabla(tipo);
            btn_nuevo.Enabled = false;
        }

        private void chk_Box_filtro_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_Box_filtro.Checked)
            {
                
                lbl_f_final.Visible = true;
                lbl_f_inicio.Visible = true;
                time_inicio.Visible = true;
                time_final.Visible = true;

            }
            else
            {
                lbl_f_final.Visible = false;
                lbl_f_inicio.Visible = false;
                time_inicio.Visible = false;
                time_final.Visible = false;
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
 
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            tipo = "persona";
            chk_Box_filtro.Checked = false;
            chk_Box_filtro.Visible = false;
            MostrarTabla(tipo);
            btn_nuevo.Enabled = true;
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            tipo = "usuario";
            chk_Box_filtro.Checked = false;
            chk_Box_filtro.Visible=false;
            MostrarTabla(tipo);
            btn_nuevo.Enabled = true;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
        }

        public void ImagePoner(string id)
        {
            string path = "bodega/";
            pbFotoUser.Image = Image.FromFile(path + id + ".png");
            
        }
        private void btn_cam_Click(object sender, EventArgs e)
        {

            //this.Hide();
            pbFotoUser.Image = Image.FromFile(foto_perfil);
            string id = txt_id.Text;
            Form frm = new Foto(id);
            frm.ShowDialog();
            path_foto = "bodega/" + id + ".png";
            
             pbFotoUser.Image = Image.FromFile(path_foto);
            //this.Show();

            //string id = txt_id.Text;
            //string path = "bodega/";
            //pbFotoUser.Image.Save(path+id+".png",ImageFormat.Jpeg);

            //inicio_cam();

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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Form frm_Nuevo = new RegistroNuevo(tipo);
            frm_Nuevo.ShowDialog();
            MostrarTabla(tipo);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("el login: "+id_eliminar);
            Console.WriteLine("el tipo: " + tipo);
            if(miDB.DeleteRegistro(id_eliminar, tipo))
            {
                dt.Rows.Remove(dt.CurrentRow);
            }
            else
            {
                MessageBox.Show("No se pudo borrar. ");
            }
            
            
        }

        
        private void dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipo=="usuario")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Console.WriteLine("cell:"+id_eliminar);
            }
            else if (tipo == "persona")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Console.WriteLine("cell:" + id_eliminar);
            }
            if (tipo == "incidente")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Console.WriteLine("cell:" + id_eliminar);
            }
            if (tipo == "visita")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Console.WriteLine("cell:" + id_eliminar);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form frm_Nuevo = new RegistroModificar(tipo, id_eliminar);
            frm_Nuevo.ShowDialog();
            MostrarTabla(tipo);
        }
    }
}
