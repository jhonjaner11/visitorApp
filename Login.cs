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

            
            string user = txt_login.Text;
            string pass = txt_contraseña.Text;


            //miDB.OpenConnection();
            string us = miDB.SelectUser(user, pass);
            
            string[] usuario = miDB.GetUsuario(us);
            //sql.Parameters.AddWithValue("@login", us);
            //sql.Parameters.AddWithValue("@pw", pw);
            //Console.WriteLine(usuario);
            //miDB.CloseConnection();


     

            this.Hide();
            Form frm = new v_home_ce(usuario);

   
            frm.ShowDialog();
            this.Show();

           
  



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
