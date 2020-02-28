namespace visitorApp
{
    partial class RegistroModificar
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
            this.pnl_persona = new System.Windows.Forms.Panel();
            this.btn_modificar_persona = new System.Windows.Forms.Button();
            this.cbx_tipoid_p = new System.Windows.Forms.ComboBox();
            this.txt_telefono_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre_p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id_p = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_usuario = new System.Windows.Forms.Panel();
            this.txt_id_u = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_modificar_usuario = new System.Windows.Forms.Button();
            this.cbx_cargo = new System.Windows.Forms.ComboBox();
            this.txt_contraseña_u = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_u = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_login_u = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_incidente = new System.Windows.Forms.Panel();
            this.btn_modificar_incidente = new System.Windows.Forms.Button();
            this.rtxt_descripcion = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fecha_incidente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id_incidente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnl_visita = new System.Windows.Forms.Panel();
            this.txt_visita_id = new System.Windows.Forms.TextBox();
            this.btn_modificar_visita = new System.Windows.Forms.Button();
            this.txt_visita_placa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_visita_vh = new System.Windows.Forms.ComboBox();
            this.txt_visita_fecha = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_visita_apto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_visita_identificacion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.pnl_persona.SuspendLayout();
            this.pnl_usuario.SuspendLayout();
            this.pnl_incidente.SuspendLayout();
            this.pnl_visita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_persona
            // 
            this.pnl_persona.Controls.Add(this.btn_modificar_persona);
            this.pnl_persona.Controls.Add(this.cbx_tipoid_p);
            this.pnl_persona.Controls.Add(this.txt_telefono_p);
            this.pnl_persona.Controls.Add(this.label6);
            this.pnl_persona.Controls.Add(this.label7);
            this.pnl_persona.Controls.Add(this.txt_nombre_p);
            this.pnl_persona.Controls.Add(this.label8);
            this.pnl_persona.Controls.Add(this.txt_id_p);
            this.pnl_persona.Controls.Add(this.label9);
            this.pnl_persona.Controls.Add(this.label10);
            this.pnl_persona.Location = new System.Drawing.Point(12, 12);
            this.pnl_persona.Name = "pnl_persona";
            this.pnl_persona.Size = new System.Drawing.Size(349, 262);
            this.pnl_persona.TabIndex = 3;
            // 
            // btn_modificar_persona
            // 
            this.btn_modificar_persona.Location = new System.Drawing.Point(126, 164);
            this.btn_modificar_persona.Name = "btn_modificar_persona";
            this.btn_modificar_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_persona.TabIndex = 12;
            this.btn_modificar_persona.Text = "Modificar";
            this.btn_modificar_persona.UseVisualStyleBackColor = true;
            this.btn_modificar_persona.Click += new System.EventHandler(this.btn_modificar_persona_Click);
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
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Modificar Persona";
            // 
            // pnl_usuario
            // 
            this.pnl_usuario.Controls.Add(this.txt_id_u);
            this.pnl_usuario.Controls.Add(this.label21);
            this.pnl_usuario.Controls.Add(this.btn_modificar_usuario);
            this.pnl_usuario.Controls.Add(this.cbx_cargo);
            this.pnl_usuario.Controls.Add(this.txt_contraseña_u);
            this.pnl_usuario.Controls.Add(this.label5);
            this.pnl_usuario.Controls.Add(this.label4);
            this.pnl_usuario.Controls.Add(this.txt_nombre_u);
            this.pnl_usuario.Controls.Add(this.label3);
            this.pnl_usuario.Controls.Add(this.txt_login_u);
            this.pnl_usuario.Controls.Add(this.label2);
            this.pnl_usuario.Controls.Add(this.label1);
            this.pnl_usuario.Location = new System.Drawing.Point(12, 12);
            this.pnl_usuario.Name = "pnl_usuario";
            this.pnl_usuario.Size = new System.Drawing.Size(349, 263);
            this.pnl_usuario.TabIndex = 2;
            // 
            // txt_id_u
            // 
            this.txt_id_u.Location = new System.Drawing.Point(212, 24);
            this.txt_id_u.Name = "txt_id_u";
            this.txt_id_u.Size = new System.Drawing.Size(100, 20);
            this.txt_id_u.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(200, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Id:";
            // 
            // btn_modificar_usuario
            // 
            this.btn_modificar_usuario.Location = new System.Drawing.Point(134, 176);
            this.btn_modificar_usuario.Name = "btn_modificar_usuario";
            this.btn_modificar_usuario.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_usuario.TabIndex = 12;
            this.btn_modificar_usuario.Text = "Modificar";
            this.btn_modificar_usuario.UseVisualStyleBackColor = true;
            this.btn_modificar_usuario.Click += new System.EventHandler(this.btn_modificar_usuario_Click);
            // 
            // cbx_cargo
            // 
            this.cbx_cargo.FormattingEnabled = true;
            this.cbx_cargo.Items.AddRange(new object[] {
            "Celador",
            "Admin"});
            this.cbx_cargo.Location = new System.Drawing.Point(194, 80);
            this.cbx_cargo.Name = "cbx_cargo";
            this.cbx_cargo.Size = new System.Drawing.Size(100, 21);
            this.cbx_cargo.TabIndex = 11;
            // 
            // txt_contraseña_u
            // 
            this.txt_contraseña_u.Location = new System.Drawing.Point(194, 135);
            this.txt_contraseña_u.Name = "txt_contraseña_u";
            this.txt_contraseña_u.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña_u.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cargo:";
            // 
            // txt_nombre_u
            // 
            this.txt_nombre_u.Location = new System.Drawing.Point(53, 135);
            this.txt_nombre_u.Name = "txt_nombre_u";
            this.txt_nombre_u.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_u.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txt_login_u
            // 
            this.txt_login_u.Location = new System.Drawing.Point(53, 80);
            this.txt_login_u.Name = "txt_login_u";
            this.txt_login_u.Size = new System.Drawing.Size(100, 20);
            this.txt_login_u.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Usuario";
            // 
            // pnl_incidente
            // 
            this.pnl_incidente.Controls.Add(this.btn_modificar_incidente);
            this.pnl_incidente.Controls.Add(this.rtxt_descripcion);
            this.pnl_incidente.Controls.Add(this.label11);
            this.pnl_incidente.Controls.Add(this.txt_fecha_incidente);
            this.pnl_incidente.Controls.Add(this.label13);
            this.pnl_incidente.Controls.Add(this.txt_id_incidente);
            this.pnl_incidente.Controls.Add(this.label14);
            this.pnl_incidente.Controls.Add(this.label15);
            this.pnl_incidente.Location = new System.Drawing.Point(12, 12);
            this.pnl_incidente.Name = "pnl_incidente";
            this.pnl_incidente.Size = new System.Drawing.Size(349, 262);
            this.pnl_incidente.TabIndex = 5;
            // 
            // btn_modificar_incidente
            // 
            this.btn_modificar_incidente.Location = new System.Drawing.Point(126, 164);
            this.btn_modificar_incidente.Name = "btn_modificar_incidente";
            this.btn_modificar_incidente.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_incidente.TabIndex = 14;
            this.btn_modificar_incidente.Text = "Modificar";
            this.btn_modificar_incidente.UseVisualStyleBackColor = true;
            this.btn_modificar_incidente.Click += new System.EventHandler(this.btn_modificar_incidente_Click);
            // 
            // rtxt_descripcion
            // 
            this.rtxt_descripcion.Location = new System.Drawing.Point(35, 107);
            this.rtxt_descripcion.Name = "rtxt_descripcion";
            this.rtxt_descripcion.Size = new System.Drawing.Size(230, 46);
            this.rtxt_descripcion.TabIndex = 13;
            this.rtxt_descripcion.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Descripcion:";
            // 
            // txt_fecha_incidente
            // 
            this.txt_fecha_incidente.Location = new System.Drawing.Point(192, 27);
            this.txt_fecha_incidente.Name = "txt_fecha_incidente";
            this.txt_fecha_incidente.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_incidente.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Fecha:";
            // 
            // txt_id_incidente
            // 
            this.txt_id_incidente.Location = new System.Drawing.Point(28, 68);
            this.txt_id_incidente.Name = "txt_id_incidente";
            this.txt_id_incidente.Size = new System.Drawing.Size(100, 20);
            this.txt_id_incidente.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Modificar incidente";
            // 
            // pnl_visita
            // 
            this.pnl_visita.Controls.Add(this.txt_visita_id);
            this.pnl_visita.Controls.Add(this.btn_modificar_visita);
            this.pnl_visita.Controls.Add(this.txt_visita_placa);
            this.pnl_visita.Controls.Add(this.label12);
            this.pnl_visita.Controls.Add(this.cbx_visita_vh);
            this.pnl_visita.Controls.Add(this.txt_visita_fecha);
            this.pnl_visita.Controls.Add(this.label16);
            this.pnl_visita.Controls.Add(this.label17);
            this.pnl_visita.Controls.Add(this.txt_visita_apto);
            this.pnl_visita.Controls.Add(this.label18);
            this.pnl_visita.Controls.Add(this.txt_visita_identificacion);
            this.pnl_visita.Controls.Add(this.label19);
            this.pnl_visita.Controls.Add(this.label20);
            this.pnl_visita.Location = new System.Drawing.Point(12, 12);
            this.pnl_visita.Name = "pnl_visita";
            this.pnl_visita.Size = new System.Drawing.Size(349, 262);
            this.pnl_visita.TabIndex = 4;
            this.pnl_visita.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_visita_Paint);
            // 
            // txt_visita_id
            // 
            this.txt_visita_id.Location = new System.Drawing.Point(91, 32);
            this.txt_visita_id.Name = "txt_visita_id";
            this.txt_visita_id.Size = new System.Drawing.Size(46, 20);
            this.txt_visita_id.TabIndex = 17;
            this.txt_visita_id.Visible = false;
            // 
            // btn_modificar_visita
            // 
            this.btn_modificar_visita.Location = new System.Drawing.Point(155, 203);
            this.btn_modificar_visita.Name = "btn_modificar_visita";
            this.btn_modificar_visita.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_visita.TabIndex = 15;
            this.btn_modificar_visita.Text = "Modificar";
            this.btn_modificar_visita.UseVisualStyleBackColor = true;
            this.btn_modificar_visita.Click += new System.EventHandler(this.btn_modificar_visita_Click);
            // 
            // txt_visita_placa
            // 
            this.txt_visita_placa.Location = new System.Drawing.Point(197, 165);
            this.txt_visita_placa.Name = "txt_visita_placa";
            this.txt_visita_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_visita_placa.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Placa:";
            // 
            // cbx_visita_vh
            // 
            this.cbx_visita_vh.FormattingEnabled = true;
            this.cbx_visita_vh.Items.AddRange(new object[] {
            "Celador",
            "Admin"});
            this.cbx_visita_vh.Location = new System.Drawing.Point(54, 164);
            this.cbx_visita_vh.Name = "cbx_visita_vh";
            this.cbx_visita_vh.Size = new System.Drawing.Size(100, 21);
            this.cbx_visita_vh.TabIndex = 11;
            // 
            // txt_visita_fecha
            // 
            this.txt_visita_fecha.Location = new System.Drawing.Point(187, 27);
            this.txt_visita_fecha.Name = "txt_visita_fecha";
            this.txt_visita_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_visita_fecha.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Vehiculo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(175, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Fecha:";
            // 
            // txt_visita_apto
            // 
            this.txt_visita_apto.Location = new System.Drawing.Point(197, 110);
            this.txt_visita_apto.Name = "txt_visita_apto";
            this.txt_visita_apto.Size = new System.Drawing.Size(61, 20);
            this.txt_visita_apto.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(185, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Apto:";
            // 
            // txt_visita_identificacion
            // 
            this.txt_visita_identificacion.Location = new System.Drawing.Point(54, 110);
            this.txt_visita_identificacion.Name = "txt_visita_identificacion";
            this.txt_visita_identificacion.Size = new System.Drawing.Size(100, 20);
            this.txt_visita_identificacion.TabIndex = 2;
            this.txt_visita_identificacion.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Identificacion Visitante:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Modificar Visita";
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
            this.btn_Cerrar.Location = new System.Drawing.Point(367, 1);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 32);
            this.btn_Cerrar.TabIndex = 8;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // RegistroModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(395, 287);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.pnl_visita);
            this.Controls.Add(this.pnl_incidente);
            this.Controls.Add(this.pnl_persona);
            this.Controls.Add(this.pnl_usuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.RegistroModificar_Load);
            this.pnl_persona.ResumeLayout(false);
            this.pnl_persona.PerformLayout();
            this.pnl_usuario.ResumeLayout(false);
            this.pnl_usuario.PerformLayout();
            this.pnl_incidente.ResumeLayout(false);
            this.pnl_incidente.PerformLayout();
            this.pnl_visita.ResumeLayout(false);
            this.pnl_visita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_persona;
        private System.Windows.Forms.Button btn_modificar_persona;
        private System.Windows.Forms.ComboBox cbx_tipoid_p;
        private System.Windows.Forms.TextBox txt_telefono_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id_p;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl_usuario;
        private System.Windows.Forms.Button btn_modificar_usuario;
        private System.Windows.Forms.ComboBox cbx_cargo;
        private System.Windows.Forms.TextBox txt_contraseña_u;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre_u;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_login_u;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_incidente;
        private System.Windows.Forms.RichTextBox rtxt_descripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_fecha_incidente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_id_incidente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnl_visita;
        private System.Windows.Forms.ComboBox cbx_visita_vh;
        private System.Windows.Forms.TextBox txt_visita_fecha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_visita_apto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_visita_identificacion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_visita_placa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_modificar_incidente;
        private System.Windows.Forms.Button btn_modificar_visita;
        private System.Windows.Forms.TextBox txt_id_u;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_visita_id;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}