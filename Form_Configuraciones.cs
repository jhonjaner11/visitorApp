using System;
using System.IO;
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


namespace visitorApp
{
    public partial class Form_Configuraciones : Form
    {

        private bool ExistenDispositivos = false;
        string nombreCam;

        private FilterInfoCollection DispositivosDeVideo;
        public Form_Configuraciones()
        {
            InitializeComponent();
            BuscarDispositivos();
            cboDispositivos.SelectedIndex = cboDispositivos.FindStringExact(Properties.Settings.Default.camara);
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

        private void guardar()
        {
                nombreCam = cboDispositivos.Text;
                Properties.Settings.Default.camara = nombreCam;
                Properties.Settings.Default.Save();
                MessageBox.Show("Configuracion guardada");
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
