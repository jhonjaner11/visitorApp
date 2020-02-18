using System;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
namespace visitorApp
{
    public partial class Login : Form
    {
        Database miDB = new Database();
        public Login()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string us = txt_login.Text;
            string pw = txt_contraseña.Text;


            //miDB.OpenConnection();
            string usuario = miDB.SelectUser(us, pw);
            //sql.Parameters.AddWithValue("@login", us);
            //sql.Parameters.AddWithValue("@pw", pw);
            Console.WriteLine(usuario);
            //miDB.CloseConnection();
            Console.WriteLine("ddbb close autocompletarNombreProd");

            if (usuario == "admin")
            {
                this.Hide();
                Form frm = new v_home_ce();
                frm.ShowDialog();
                this.Show();


            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
