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
        private bool ExistenDispositivos = false;

        private FilterInfoCollection DispositivosDeVideo;

        private VideoCaptureDevice FuenteDeVideo = null;


        public v_home_ce()
        {
            InitializeComponent();
            autoLlenarId(txt_id);
            BuscarDispositivos();

        }

        public void autoLlenarId(TextBox cajaTexto)
        {


            foreach (string color in miDB.GetPersonas())
            {
                Console.WriteLine(color);
                cajaTexto.AutoCompleteCustomSource.Add(color);
            }

        }

        public void autoLlenarPersona(string id, TextBox cjNombre, ComboBox cjTipoId, TextBox cjTelefono, PictureBox cjPathFoto)
        {

            string[] res = miDB.GetOnlyPersona(id);
            Console.WriteLine(res);
            cjNombre.Text = res[0];
            cjTipoId.Text = res[1];
            cjTelefono.Text = res[2];
            //cjPathFoto.Text = res[3];

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


        public void CargarDispositivos(FilterInfoCollection Dispositivos)

        {
            for (int i = 0; i < Dispositivos.Count; i++)

                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString());
            //cboDispositivos es nuestro combobox

            cboDispositivos.Text = cboDispositivos.Items[0].ToString();

        }
        public void BuscarDispositivos()

        {

            DispositivosDeVideo =
            new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (DispositivosDeVideo.Count == 0)

                ExistenDispositivos = false;
            else

            {

                ExistenDispositivos = true;

                CargarDispositivos(DispositivosDeVideo);

            }

        }
        public void TerminarFuenteDeVideo()

        {
            if (!(FuenteDeVideo == null))

                if (FuenteDeVideo.IsRunning)

                {

                    FuenteDeVideo.SignalToStop();

                    FuenteDeVideo = null;

                }

        }
        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)

        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();

            pbFotoUser.Image = Imagen;
            //pbFotoUser es nuestro pictureBox

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
            autoLlenarPersona(txt_id.Text, txt_nombre, comboBox_id, txt_telefono, pbFotoUser);
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

            if (btnIniciar.Text == "Iniciar")

            {
                if (ExistenDispositivos)

                {

                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);

                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);

                    FuenteDeVideo.Start();

                    btnIniciar.Text = "Detener";

                    cboDispositivos.Enabled = false;

                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();

                }
                else

                    MessageBox.Show("Error: No se encuentra dispositivo.");

            }
            else

            {
                if (FuenteDeVideo.IsRunning)

                {

                    TerminarFuenteDeVideo();

                    btnIniciar.Text = "Iniciar";

                    cboDispositivos.Enabled = true;

                }

            }
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
            pnl_bbdd.Visible = false;
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
            string id = txt_id.Text;
            string tp_id = comboBox_id.Text;
            string nombre = txt_nombre.Text;
            string apto = txt_apto.Text;
            string vh = comboBox_tp_Vh.Text;
            string placa = txt_placa.Text;
            string fecha = txt_fecha_v.Text;
            string path_foto = "/path";
            string telefono = txt_telefono.Text;

            string[] arrVisita = { id, tp_id, nombre, apto, vh, placa, fecha, path_foto, telefono };
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

        private void btn_enviar_incidente_Click(object sender, EventArgs e)
        {
            string fecha = txt_fecha_i.Text;
            string desc = rtxt_desc.Text;
            string[] arrIncidente = { fecha, desc };
            Boolean resultado = miDB.InsertIncidente(arrIncidente);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

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
            string tipo = "incidente";
            MostrarTabla(tipo);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_bajar_visitas_Click(object sender, EventArgs e)
        {
            string tipo = "visita";
            MostrarTabla(tipo);
        }

        private void chk_Box_filtro_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_Box_filtro.Checked)
            {
                pnl_filtro.Visible = true;
            }
            else
            {
                pnl_filtro.Visible = false;
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
            string tipo = "persona";
            chk_Box_filtro.Checked = false;
            chk_Box_filtro.Visible = false;
            MostrarTabla(tipo);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            string tipo = "usuario";
            chk_Box_filtro.Checked = false;
            chk_Box_filtro.Visible=false;
            MostrarTabla(tipo);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
        }

        private void btn_cam_Click(object sender, EventArgs e)
        {
            string nombre = txt_id.Text;
            string path = "bodega/";
            pbFotoUser.Image.Save(path+nombre+".png",ImageFormat.Jpeg);

        }
    }
}
