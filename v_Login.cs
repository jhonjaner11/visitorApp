﻿using System;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
namespace visitorApp
{
    public partial class v_Login : Form
    {
        Database miDB = new Database();
        public v_Login()
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


            Console.WriteLine("us:"+ us);
            if (us != "Errado")
            {
                this.Hide();
                Form frm = new v_home_ce(usuario);


                frm.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("No se encontro el usuario");
            }






        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ateam.com.co");
        }
    }
}