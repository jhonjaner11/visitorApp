using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

using System.IO;

using System.Drawing.Imaging;

namespace visitorApp
{
    public partial class Form_Tomar_Foto : Form
    {
        private string id;
        private bool ExistenDispositivos = false;

        private FilterInfoCollection DispositivosDeVideo;

        private VideoCaptureDevice FuenteDeVideo = null;

        private string path;
        private string foto ="";
        public Form_Tomar_Foto(string ids, string lugar)
        {
            InitializeComponent();
            id = ids;
            BuscarDispositivos();
            inicio_cam();
            path = lugar+"/";
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)

        {
            for (int i = 0; i < Dispositivos.Count; i++)

                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString());
            //cboDispositivos es nuestro combobox

            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
            Console.WriteLine(Properties.Settings.Default.camara);
           

            cboDispositivos.SelectedIndex = cboDispositivos.FindStringExact(Properties.Settings.Default.camara);

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
            //pbFotoUser.
            pbFoto.Image = Imagen;
            //pbFotoUser es nuestro pictureBox

        }
        
        private void inicio_cam()
        {
            Limpiar_Foto();
            if (btnIniciar.Text == "Iniciar")
                
            {
                btn_cam.Enabled = true;
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    //FuenteDeVideo = new VideoCaptureDevice(Properties.Settings.Default.camara.MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnIniciar.Text = "Detener";
                    cboDispositivos.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error: No se encuentra dispositivo.");
                }
                    
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    btnIniciar.Text = "Iniciar";
                    cboDispositivos.Enabled = true;
                    btn_cam.Enabled = false;
                }
            }
        }

        public string Obtener_path()
        {
            string res;
           
            res = path + id + ".png";
            return res;
        }

        private void Limpiar_Foto()
        {
            foto = path + id + ".png";
            if (File.Exists(foto))
            {
                Console.WriteLine("eliminando");
                try
                {
                    File.Delete(foto);
                    Console.WriteLine("eliminado");

                }
                catch (Exception er)
                {
                    Console.WriteLine(er);
                }
               
                
            }
        }
        private void Foto_Load(object sender, EventArgs e)
        {
            Console.WriteLine("id: " + id);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            Limpiar_Foto();
            inicio_cam();
        }

        public void btn_cam_Click(object sender, EventArgs e)
        {
            Limpiar_Foto();
            try
            {
                

                pbFoto.Image.Save(foto, ImageFormat.Png);
                Console.WriteLine("metiendo foto:" + foto);
                pbFoto.Image = Image.FromFile(foto);
                //TerminarFuenteDeVideo();
                inicio_cam();
                Console.WriteLine("metida foto");
                MessageBox.Show("Foto correctamente almacenada.");
                this.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show("La fotografia ya se encuentra  almacenada.");
                Console.WriteLine("error: " + ae);
                inicio_cam();
                this.Close();

            }



        }

        private void pbFotoUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            inicio_cam();
            this.Close();
        }
    }
}
