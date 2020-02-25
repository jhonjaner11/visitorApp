namespace visitorApp
{
    partial class v_home_ce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_home_ce));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reg_incidente = new System.Windows.Forms.Button();
            this.btn_reg_visita = new System.Windows.Forms.Button();
            this.pnl_visita = new System.Windows.Forms.Panel();
            this.btn_cam = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pbFotoUser = new System.Windows.Forms.PictureBox();
            this.txt_apto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecha_v = new System.Windows.Forms.TextBox();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pnl_vehiculo = new System.Windows.Forms.Panel();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_tp_Vh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_vehiculo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_incidente = new System.Windows.Forms.Panel();
            this.btn_enviar_incidente = new System.Windows.Forms.Button();
            this.rtxt_desc = new System.Windows.Forms.RichTextBox();
            this.txt_fecha_i = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_v_home_ce = new System.Windows.Forms.Panel();
            this.pnl_bbdd = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.chk_Box_filtro = new System.Windows.Forms.CheckBox();
            this.pnl_filtro = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.time_final = new System.Windows.Forms.DateTimePicker();
            this.time_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_mostrar_incidentes = new System.Windows.Forms.Button();
            this.btn_mostrar_visitas = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_aptos_i = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_visita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).BeginInit();
            this.pnl_vehiculo.SuspendLayout();
            this.pnl_incidente.SuspendLayout();
            this.pnl_v_home_ce.SuspendLayout();
            this.pnl_bbdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.pnl_filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_exportar);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_reg_incidente);
            this.panel1.Controls.Add(this.btn_reg_visita);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 303);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(3, 123);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(62, 55);
            this.btn_exportar.TabIndex = 3;
            this.btn_exportar.Text = "Base de datos";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(4, 266);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(62, 34);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_reg_incidente
            // 
            this.btn_reg_incidente.Location = new System.Drawing.Point(4, 64);
            this.btn_reg_incidente.Name = "btn_reg_incidente";
            this.btn_reg_incidente.Size = new System.Drawing.Size(62, 55);
            this.btn_reg_incidente.TabIndex = 1;
            this.btn_reg_incidente.Text = "Registrar Incidente";
            this.btn_reg_incidente.UseVisualStyleBackColor = true;
            this.btn_reg_incidente.Click += new System.EventHandler(this.btn_reg_incidente_Click);
            // 
            // btn_reg_visita
            // 
            this.btn_reg_visita.Location = new System.Drawing.Point(4, 3);
            this.btn_reg_visita.Name = "btn_reg_visita";
            this.btn_reg_visita.Size = new System.Drawing.Size(62, 55);
            this.btn_reg_visita.TabIndex = 0;
            this.btn_reg_visita.Text = "Registrar Visita";
            this.btn_reg_visita.UseVisualStyleBackColor = true;
            this.btn_reg_visita.Click += new System.EventHandler(this.btn_reg_visita_Click);
            // 
            // pnl_visita
            // 
            this.pnl_visita.AutoSize = true;
            this.pnl_visita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_visita.Controls.Add(this.btn_cam);
            this.pnl_visita.Controls.Add(this.txt_telefono);
            this.pnl_visita.Controls.Add(this.label12);
            this.pnl_visita.Controls.Add(this.txt_nombre);
            this.pnl_visita.Controls.Add(this.label5);
            this.pnl_visita.Controls.Add(this.label1);
            this.pnl_visita.Controls.Add(this.button2);
            this.pnl_visita.Controls.Add(this.pbFotoUser);
            this.pnl_visita.Controls.Add(this.txt_apto);
            this.pnl_visita.Controls.Add(this.label8);
            this.pnl_visita.Controls.Add(this.txt_fecha_v);
            this.pnl_visita.Controls.Add(this.comboBox_id);
            this.pnl_visita.Controls.Add(this.txt_id);
            this.pnl_visita.Controls.Add(this.pnl_vehiculo);
            this.pnl_visita.Controls.Add(this.checkBox_vehiculo);
            this.pnl_visita.Controls.Add(this.label4);
            this.pnl_visita.Controls.Add(this.label3);
            this.pnl_visita.Controls.Add(this.label2);
            this.pnl_visita.Location = new System.Drawing.Point(99, 17);
            this.pnl_visita.Name = "pnl_visita";
            this.pnl_visita.Size = new System.Drawing.Size(562, 393);
            this.pnl_visita.TabIndex = 1;
            this.pnl_visita.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_visita_Paint);
            // 
            // btn_cam
            // 
            this.btn_cam.Location = new System.Drawing.Point(375, 298);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(75, 23);
            this.btn_cam.TabIndex = 22;
            this.btn_cam.Text = "tomar foto";
            this.btn_cam.UseVisualStyleBackColor = true;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(22, 175);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(136, 20);
            this.txt_telefono.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Telefono:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(21, 133);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(245, 20);
            this.txt_nombre.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Visita";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbFotoUser
            // 
            this.pbFotoUser.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoUser.Image")));
            this.pbFotoUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFotoUser.InitialImage")));
            this.pbFotoUser.Location = new System.Drawing.Point(304, 146);
            this.pbFotoUser.Name = "pbFotoUser";
            this.pbFotoUser.Size = new System.Drawing.Size(224, 146);
            this.pbFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUser.TabIndex = 15;
            this.pbFotoUser.TabStop = false;
            this.pbFotoUser.Click += new System.EventHandler(this.pbFotoUser_Click);
            // 
            // txt_apto
            // 
            this.txt_apto.Location = new System.Drawing.Point(21, 230);
            this.txt_apto.Name = "txt_apto";
            this.txt_apto.Size = new System.Drawing.Size(95, 20);
            this.txt_apto.TabIndex = 13;
            this.txt_apto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Apto:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_fecha_v
            // 
            this.txt_fecha_v.Location = new System.Drawing.Point(281, 86);
            this.txt_fecha_v.Name = "txt_fecha_v";
            this.txt_fecha_v.Size = new System.Drawing.Size(140, 20);
            this.txt_fecha_v.TabIndex = 11;
            // 
            // comboBox_id
            // 
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Items.AddRange(new object[] {
            "CC",
            "TI",
            "Pasaporte",
            "Cedula Extranjera"});
            this.comboBox_id.Location = new System.Drawing.Point(192, 86);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(74, 21);
            this.comboBox_id.TabIndex = 10;
            this.comboBox_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_id_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_id.Location = new System.Drawing.Point(21, 86);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(165, 20);
            this.txt_id.TabIndex = 9;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            // 
            // pnl_vehiculo
            // 
            this.pnl_vehiculo.Controls.Add(this.txt_placa);
            this.pnl_vehiculo.Controls.Add(this.label7);
            this.pnl_vehiculo.Controls.Add(this.comboBox_tp_Vh);
            this.pnl_vehiculo.Controls.Add(this.label6);
            this.pnl_vehiculo.Location = new System.Drawing.Point(132, 211);
            this.pnl_vehiculo.Name = "pnl_vehiculo";
            this.pnl_vehiculo.Size = new System.Drawing.Size(159, 63);
            this.pnl_vehiculo.TabIndex = 7;
            this.pnl_vehiculo.Visible = false;
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(74, 23);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(63, 20);
            this.txt_placa.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Placa:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox_tp_Vh
            // 
            this.comboBox_tp_Vh.FormattingEnabled = true;
            this.comboBox_tp_Vh.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.comboBox_tp_Vh.Location = new System.Drawing.Point(0, 22);
            this.comboBox_tp_Vh.Name = "comboBox_tp_Vh";
            this.comboBox_tp_Vh.Size = new System.Drawing.Size(54, 21);
            this.comboBox_tp_Vh.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkBox_vehiculo
            // 
            this.checkBox_vehiculo.AutoSize = true;
            this.checkBox_vehiculo.Location = new System.Drawing.Point(179, 175);
            this.checkBox_vehiculo.Name = "checkBox_vehiculo";
            this.checkBox_vehiculo.Size = new System.Drawing.Size(67, 17);
            this.checkBox_vehiculo.TabIndex = 6;
            this.checkBox_vehiculo.Text = "Vehiculo";
            this.checkBox_vehiculo.UseVisualStyleBackColor = true;
            this.checkBox_vehiculo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificacion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnl_incidente
            // 
            this.pnl_incidente.Controls.Add(this.txt_aptos_i);
            this.pnl_incidente.Controls.Add(this.label17);
            this.pnl_incidente.Controls.Add(this.btn_enviar_incidente);
            this.pnl_incidente.Controls.Add(this.rtxt_desc);
            this.pnl_incidente.Controls.Add(this.txt_fecha_i);
            this.pnl_incidente.Controls.Add(this.label10);
            this.pnl_incidente.Controls.Add(this.label11);
            this.pnl_incidente.Controls.Add(this.label9);
            this.pnl_incidente.Location = new System.Drawing.Point(99, 17);
            this.pnl_incidente.Name = "pnl_incidente";
            this.pnl_incidente.Size = new System.Drawing.Size(638, 390);
            this.pnl_incidente.TabIndex = 2;
            this.pnl_incidente.Visible = false;
            this.pnl_incidente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_indicente_Paint);
            // 
            // btn_enviar_incidente
            // 
            this.btn_enviar_incidente.Location = new System.Drawing.Point(192, 281);
            this.btn_enviar_incidente.Name = "btn_enviar_incidente";
            this.btn_enviar_incidente.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar_incidente.TabIndex = 17;
            this.btn_enviar_incidente.Text = "enviar";
            this.btn_enviar_incidente.UseVisualStyleBackColor = true;
            this.btn_enviar_incidente.Click += new System.EventHandler(this.btn_enviar_incidente_Click);
            // 
            // rtxt_desc
            // 
            this.rtxt_desc.Location = new System.Drawing.Point(28, 132);
            this.rtxt_desc.Name = "rtxt_desc";
            this.rtxt_desc.Size = new System.Drawing.Size(378, 138);
            this.rtxt_desc.TabIndex = 16;
            this.rtxt_desc.Text = "";
            // 
            // txt_fecha_i
            // 
            this.txt_fecha_i.Location = new System.Drawing.Point(195, 84);
            this.txt_fecha_i.Name = "txt_fecha_i";
            this.txt_fecha_i.Size = new System.Drawing.Size(75, 20);
            this.txt_fecha_i.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Descripcion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Registrar Incidente";
            // 
            // pnl_v_home_ce
            // 
            this.pnl_v_home_ce.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_v_home_ce.Controls.Add(this.panel1);
            this.pnl_v_home_ce.Controls.Add(this.pnl_incidente);
            this.pnl_v_home_ce.Controls.Add(this.pnl_bbdd);
            this.pnl_v_home_ce.Controls.Add(this.pnl_visita);
            this.pnl_v_home_ce.Location = new System.Drawing.Point(7, 7);
            this.pnl_v_home_ce.Name = "pnl_v_home_ce";
            this.pnl_v_home_ce.Size = new System.Drawing.Size(753, 429);
            this.pnl_v_home_ce.TabIndex = 3;
            this.pnl_v_home_ce.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_v_home_ce_Paint);
            // 
            // pnl_bbdd
            // 
            this.pnl_bbdd.Controls.Add(this.button4);
            this.pnl_bbdd.Controls.Add(this.button1);
            this.pnl_bbdd.Controls.Add(this.btn_nuevo);
            this.pnl_bbdd.Controls.Add(this.btn_export);
            this.pnl_bbdd.Controls.Add(this.btn_usuarios);
            this.pnl_bbdd.Controls.Add(this.button3);
            this.pnl_bbdd.Controls.Add(this.dt);
            this.pnl_bbdd.Controls.Add(this.chk_Box_filtro);
            this.pnl_bbdd.Controls.Add(this.pnl_filtro);
            this.pnl_bbdd.Controls.Add(this.btn_mostrar_incidentes);
            this.pnl_bbdd.Controls.Add(this.btn_mostrar_visitas);
            this.pnl_bbdd.Controls.Add(this.label14);
            this.pnl_bbdd.Controls.Add(this.label13);
            this.pnl_bbdd.Location = new System.Drawing.Point(99, 17);
            this.pnl_bbdd.Name = "pnl_bbdd";
            this.pnl_bbdd.Size = new System.Drawing.Size(641, 393);
            this.pnl_bbdd.TabIndex = 3;
            this.pnl_bbdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(454, 100);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 16;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(19, 370);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 15;
            this.btn_export.Text = "exportar";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(258, 177);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(77, 34);
            this.btn_usuarios.TabIndex = 14;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Personas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // dt
            // 
            this.dt.AllowUserToOrderColumns = true;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(19, 218);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(587, 150);
            this.dt.TabIndex = 12;
            this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellClick);
            this.dt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // chk_Box_filtro
            // 
            this.chk_Box_filtro.AutoSize = true;
            this.chk_Box_filtro.Location = new System.Drawing.Point(317, 56);
            this.chk_Box_filtro.Name = "chk_Box_filtro";
            this.chk_Box_filtro.Size = new System.Drawing.Size(45, 17);
            this.chk_Box_filtro.TabIndex = 11;
            this.chk_Box_filtro.Text = "filtro";
            this.chk_Box_filtro.UseVisualStyleBackColor = true;
            this.chk_Box_filtro.CheckedChanged += new System.EventHandler(this.chk_Box_filtro_CheckedChanged);
            // 
            // pnl_filtro
            // 
            this.pnl_filtro.Controls.Add(this.label16);
            this.pnl_filtro.Controls.Add(this.label15);
            this.pnl_filtro.Controls.Add(this.time_final);
            this.pnl_filtro.Controls.Add(this.time_inicio);
            this.pnl_filtro.Location = new System.Drawing.Point(19, 101);
            this.pnl_filtro.Name = "pnl_filtro";
            this.pnl_filtro.Size = new System.Drawing.Size(349, 70);
            this.pnl_filtro.TabIndex = 10;
            this.pnl_filtro.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Fecha Final:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Fecha Inicio:";
            // 
            // time_final
            // 
            this.time_final.CustomFormat = "";
            this.time_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_final.Location = new System.Drawing.Point(87, 41);
            this.time_final.Name = "time_final";
            this.time_final.Size = new System.Drawing.Size(91, 20);
            this.time_final.TabIndex = 7;
            // 
            // time_inicio
            // 
            this.time_inicio.CustomFormat = "";
            this.time_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_inicio.Location = new System.Drawing.Point(87, 9);
            this.time_inicio.Name = "time_inicio";
            this.time_inicio.Size = new System.Drawing.Size(146, 20);
            this.time_inicio.TabIndex = 6;
            this.time_inicio.Value = new System.DateTime(2020, 2, 19, 23, 49, 47, 0);
            this.time_inicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_mostrar_incidentes
            // 
            this.btn_mostrar_incidentes.Location = new System.Drawing.Point(92, 177);
            this.btn_mostrar_incidentes.Name = "btn_mostrar_incidentes";
            this.btn_mostrar_incidentes.Size = new System.Drawing.Size(77, 34);
            this.btn_mostrar_incidentes.TabIndex = 5;
            this.btn_mostrar_incidentes.Text = "Incidentes";
            this.btn_mostrar_incidentes.UseVisualStyleBackColor = true;
            this.btn_mostrar_incidentes.Click += new System.EventHandler(this.btn_mostrar_incidencias);
            // 
            // btn_mostrar_visitas
            // 
            this.btn_mostrar_visitas.Location = new System.Drawing.Point(19, 177);
            this.btn_mostrar_visitas.Name = "btn_mostrar_visitas";
            this.btn_mostrar_visitas.Size = new System.Drawing.Size(67, 34);
            this.btn_mostrar_visitas.TabIndex = 4;
            this.btn_mostrar_visitas.Text = "Visitas";
            this.btn_mostrar_visitas.UseVisualStyleBackColor = true;
            this.btn_mostrar_visitas.Click += new System.EventHandler(this.btn_bajar_visitas_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(280, 26);
            this.label14.TabIndex = 3;
            this.label14.Text = "Este modulo permite descargar en formato Excel \r\nlas visitas e incidentes que est" +
    "en registrados en el sistema";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 33);
            this.label13.TabIndex = 2;
            this.label13.Text = "Exportar Datos";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_aptos_i
            // 
            this.txt_aptos_i.Location = new System.Drawing.Point(28, 84);
            this.txt_aptos_i.Name = "txt_aptos_i";
            this.txt_aptos_i.Size = new System.Drawing.Size(140, 20);
            this.txt_aptos_i.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Apartamentos Involucrados:";
            // 
            // v_home_ce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnl_v_home_ce);
            this.Name = "v_home_ce";
            this.Text = "VisitorApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.v_home_ce_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_visita.ResumeLayout(false);
            this.pnl_visita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).EndInit();
            this.pnl_vehiculo.ResumeLayout(false);
            this.pnl_vehiculo.PerformLayout();
            this.pnl_incidente.ResumeLayout(false);
            this.pnl_incidente.PerformLayout();
            this.pnl_v_home_ce.ResumeLayout(false);
            this.pnl_v_home_ce.PerformLayout();
            this.pnl_bbdd.ResumeLayout(false);
            this.pnl_bbdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.pnl_filtro.ResumeLayout(false);
            this.pnl_filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reg_incidente;
        private System.Windows.Forms.Button btn_reg_visita;
        private System.Windows.Forms.Panel pnl_visita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_vehiculo;
        private System.Windows.Forms.Panel pnl_vehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_tp_Vh;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.TextBox txt_apto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fecha_v;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbFotoUser;
        private System.Windows.Forms.Panel pnl_incidente;
        private System.Windows.Forms.Panel pnl_v_home_ce;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_enviar_incidente;
        private System.Windows.Forms.RichTextBox rtxt_desc;
        private System.Windows.Forms.TextBox txt_fecha_i;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_bbdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_mostrar_incidentes;
        private System.Windows.Forms.Button btn_mostrar_visitas;
        private System.Windows.Forms.DateTimePicker time_inicio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker time_final;
        private System.Windows.Forms.CheckBox chk_Box_filtro;
        private System.Windows.Forms.Panel pnl_filtro;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_aptos_i;
        private System.Windows.Forms.Label label17;
    }
}