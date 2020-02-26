namespace visitorApp
{
    partial class RegistroNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_usuario = new System.Windows.Forms.Panel();
            this.btn_nuevo_usuario = new System.Windows.Forms.Button();
            this.cbx_cargo = new System.Windows.Forms.ComboBox();
            this.txt_contraseña_u = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_u = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_login_u = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_persona = new System.Windows.Forms.Panel();
            this.btn_nuevo_persona = new System.Windows.Forms.Button();
            this.cbx_tipoid_p = new System.Windows.Forms.ComboBox();
            this.txt_telefono_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre_p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id_p = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.pnl_usuario.SuspendLayout();
            this.pnl_persona.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_usuario
            // 
            this.pnl_usuario.Controls.Add(this.pnl_persona);
            this.pnl_usuario.Controls.Add(this.btn_nuevo_usuario);
            this.pnl_usuario.Controls.Add(this.cbx_cargo);
            this.pnl_usuario.Controls.Add(this.txt_contraseña_u);
            this.pnl_usuario.Controls.Add(this.label5);
            this.pnl_usuario.Controls.Add(this.label4);
            this.pnl_usuario.Controls.Add(this.txt_nombre_u);
            this.pnl_usuario.Controls.Add(this.label3);
            this.pnl_usuario.Controls.Add(this.txt_login_u);
            this.pnl_usuario.Controls.Add(this.label2);
            this.pnl_usuario.Controls.Add(this.label1);
            this.pnl_usuario.Location = new System.Drawing.Point(41, 40);
            this.pnl_usuario.Name = "pnl_usuario";
            this.pnl_usuario.Size = new System.Drawing.Size(307, 220);
            this.pnl_usuario.TabIndex = 0;
            this.pnl_usuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_nuevo_usuario
            // 
            this.btn_nuevo_usuario.Location = new System.Drawing.Point(118, 164);
            this.btn_nuevo_usuario.Name = "btn_nuevo_usuario";
            this.btn_nuevo_usuario.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo_usuario.TabIndex = 12;
            this.btn_nuevo_usuario.Text = "Crear";
            this.btn_nuevo_usuario.UseVisualStyleBackColor = true;
            this.btn_nuevo_usuario.Click += new System.EventHandler(this.btn_nuevo_usuario_Click);
            // 
            // cbx_cargo
            // 
            this.cbx_cargo.FormattingEnabled = true;
            this.cbx_cargo.Items.AddRange(new object[] {
            "Celador",
            "Admin"});
            this.cbx_cargo.Location = new System.Drawing.Point(178, 68);
            this.cbx_cargo.Name = "cbx_cargo";
            this.cbx_cargo.Size = new System.Drawing.Size(100, 21);
            this.cbx_cargo.TabIndex = 11;
            // 
            // txt_contraseña_u
            // 
            this.txt_contraseña_u.Location = new System.Drawing.Point(178, 123);
            this.txt_contraseña_u.Name = "txt_contraseña_u";
            this.txt_contraseña_u.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña_u.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cargo:";
            // 
            // txt_nombre_u
            // 
            this.txt_nombre_u.Location = new System.Drawing.Point(37, 123);
            this.txt_nombre_u.Name = "txt_nombre_u";
            this.txt_nombre_u.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_u.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txt_login_u
            // 
            this.txt_login_u.Location = new System.Drawing.Point(37, 68);
            this.txt_login_u.Name = "txt_login_u";
            this.txt_login_u.Size = new System.Drawing.Size(100, 20);
            this.txt_login_u.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Usuario";
            // 
            // pnl_persona
            // 
            this.pnl_persona.Controls.Add(this.btn_nuevo_persona);
            this.pnl_persona.Controls.Add(this.cbx_tipoid_p);
            this.pnl_persona.Controls.Add(this.txt_telefono_p);
            this.pnl_persona.Controls.Add(this.label6);
            this.pnl_persona.Controls.Add(this.label7);
            this.pnl_persona.Controls.Add(this.txt_nombre_p);
            this.pnl_persona.Controls.Add(this.label8);
            this.pnl_persona.Controls.Add(this.txt_id_p);
            this.pnl_persona.Controls.Add(this.label9);
            this.pnl_persona.Controls.Add(this.label10);
            this.pnl_persona.Location = new System.Drawing.Point(0, 0);
            this.pnl_persona.Name = "pnl_persona";
            this.pnl_persona.Size = new System.Drawing.Size(307, 220);
            this.pnl_persona.TabIndex = 1;
            // 
            // btn_nuevo_persona
            // 
            this.btn_nuevo_persona.Location = new System.Drawing.Point(126, 164);
            this.btn_nuevo_persona.Name = "btn_nuevo_persona";
            this.btn_nuevo_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo_persona.TabIndex = 12;
            this.btn_nuevo_persona.Text = "Crear";
            this.btn_nuevo_persona.UseVisualStyleBackColor = true;
            this.btn_nuevo_persona.Click += new System.EventHandler(this.btn_nuevo_persona_Click);
            // 
            // cbx_tipoid_p
            // 
            this.cbx_tipoid_p.FormattingEnabled = true;
            this.cbx_tipoid_p.Items.AddRange(new object[] {
            "CC",
            "TI",
            "Pasaporte"});
            this.cbx_tipoid_p.Location = new System.Drawing.Point(178, 68);
            this.cbx_tipoid_p.Name = "cbx_tipoid_p";
            this.cbx_tipoid_p.Size = new System.Drawing.Size(100, 21);
            this.cbx_tipoid_p.TabIndex = 11;
            // 
            // txt_telefono_p
            // 
            this.txt_telefono_p.Location = new System.Drawing.Point(178, 123);
            this.txt_telefono_p.Name = "txt_telefono_p";
            this.txt_telefono_p.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono_p.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tipo ID:";
            // 
            // txt_nombre_p
            // 
            this.txt_nombre_p.Location = new System.Drawing.Point(37, 123);
            this.txt_nombre_p.Name = "txt_nombre_p";
            this.txt_nombre_p.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_p.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre:";
            // 
            // txt_id_p
            // 
            this.txt_id_p.Location = new System.Drawing.Point(37, 68);
            this.txt_id_p.Name = "txt_id_p";
            this.txt_id_p.Size = new System.Drawing.Size(100, 20);
            this.txt_id_p.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Identificacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nueva Persona";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cerrar.Location = new System.Drawing.Point(359, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 32);
            this.btn_Cerrar.TabIndex = 8;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            // 
            // RegistroNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.pnl_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroNuevo";
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.RegistroNuevo_Load);
            this.pnl_usuario.ResumeLayout(false);
            this.pnl_usuario.PerformLayout();
            this.pnl_persona.ResumeLayout(false);
            this.pnl_persona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_usuario;
        private System.Windows.Forms.TextBox txt_contraseña_u;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre_u;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_login_u;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_cargo;
        private System.Windows.Forms.Button btn_nuevo_usuario;
        private System.Windows.Forms.Panel pnl_persona;
        private System.Windows.Forms.Button btn_nuevo_persona;
        private System.Windows.Forms.ComboBox cbx_tipoid_p;
        private System.Windows.Forms.TextBox txt_telefono_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id_p;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}