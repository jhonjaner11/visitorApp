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

namespace visitorApp
{
    public partial class Form_Visita : Form
    {
        Database miDB = new Database();

        private string foto_perfil = "img/perfil.png";
        private string path_foto = "";
        private string id_user;
        public Form_Visita(string usuario)
        {
            InitializeComponent();
            autoLlenarId(txt_id);
            txt_fecha_v.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            comboBox_id.SelectedIndex = 0;
            id_user = usuario;
            btn_cam.Enabled = false;
            txt_placa.Visible = false;
            comboBox_tp_Vh.Visible = false;
            lbl_placa.Visible = false;
            lbl_tipo.Visible = false;
            
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
          
            string[] res = miDB.GetOnlyPersona(id);
            Console.WriteLine(res);
            cjNombre.Text = res[0];
            cjTipoId.Text = res[1];
            cjTelefono.Text = res[2];
            //cjPathFoto.Text = res[3];
            Console.WriteLine("res: " + res[3]);
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

        private void limpiar_pnl_visita()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_apto.Text = "";
            comboBox_tp_Vh.Text = "";
            txt_placa.Text = "";
            txt_telefono.Text = "";
        }




        //verifica si el id, el nombre, o el apto estan en blanco
        //si alguno esta en blanco, devolvera false. 
        public bool verificar()
        {
            bool res = true;

            if (txt_id.Text == "")
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

        //boton de enviar registro
        private void button2_Click(object sender, EventArgs e)
        {




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
            Form frm = new Form_Tomar_Foto(id);
            frm.ShowDialog();
            path_foto = "bodega/" + id + ".png";
            if (File.Exists(path_foto))
            {
                pbFotoUser.Image = Image.FromFile(path_foto);
            }
            else
            {
                pbFotoUser.Image = Image.FromFile(foto_perfil);
            }
            

            
            //this.Show();

            //string id = txt_id.Text;
            //string path = "bodega/";
            //pbFotoUser.Image.Save(path+id+".png",ImageFormat.Jpeg);

            //inicio_cam();

        }




        private void txt_id_TextChanged(object sender, EventArgs e)
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



        private void button1_Click(object sender, EventArgs e)
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
                //Console.WriteLine(id_user);


                string telefono = txt_telefono.Text;
                string[] arrVisita = { id, tp_id, nombre, apto, vh, placa, fecha, path_foto, telefono, id_user };

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

        private void checkBox_vehiculo_CheckedChanged(object sender, EventArgs e)
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
    }
}
