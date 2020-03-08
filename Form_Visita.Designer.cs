namespace visitorApp
{
    partial class Form_Visita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Visita));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.pbFotoUser = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_vehiculo = new System.Windows.Forms.CheckBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.btn_cam = new System.Windows.Forms.Button();
            this.ckb_tecnico = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fecha_v = new System.Windows.Forms.TextBox();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_torre = new System.Windows.Forms.TextBox();
            this.txt_apto = new System.Windows.Forms.TextBox();
            this.comboBox_tp_Vh = new System.Windows.Forms.ComboBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1089, 88);
            this.label1.TabIndex = 20;
            this.label1.Text = "REGISTRAR INGRESO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(0, 475);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(1089, 57);
            this.btn_enviar.TabIndex = 41;
            this.btn_enviar.Text = "Registrar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbFotoUser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbFotoUser, 3);
            this.pbFotoUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFotoUser.Image = global::visitorApp.Properties.Resources.visitante_icon;
            this.pbFotoUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFotoUser.InitialImage")));
            this.pbFotoUser.Location = new System.Drawing.Point(491, 53);
            this.pbFotoUser.Name = "pbFotoUser";
            this.tableLayoutPanel1.SetRowSpan(this.pbFotoUser, 5);
            this.pbFotoUser.Size = new System.Drawing.Size(225, 169);
            this.pbFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUser.TabIndex = 57;
            this.pbFotoUser.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 35);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 35);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tipo ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 35);
            this.label8.TabIndex = 54;
            this.label8.Text = "Torre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 35);
            this.label3.TabIndex = 45;
            this.label3.Text = "Identificacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 35);
            this.label5.TabIndex = 59;
            this.label5.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(77, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 35);
            this.label12.TabIndex = 60;
            this.label12.Text = "Telefono:";
            // 
            // checkBox_vehiculo
            // 
            this.checkBox_vehiculo.AutoSize = true;
            this.checkBox_vehiculo.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_vehiculo.Location = new System.Drawing.Point(68, 263);
            this.checkBox_vehiculo.Name = "checkBox_vehiculo";
            this.checkBox_vehiculo.Size = new System.Drawing.Size(137, 29);
            this.checkBox_vehiculo.TabIndex = 49;
            this.checkBox_vehiculo.Text = "Vehiculo";
            this.checkBox_vehiculo.UseVisualStyleBackColor = true;
            this.checkBox_vehiculo.CheckedChanged += new System.EventHandler(this.checkBox_vehiculo_CheckedChanged);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(211, 260);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(75, 31);
            this.lbl_tipo.TabIndex = 42;
            this.lbl_tipo.Text = "Tipo:";
            this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.Location = new System.Drawing.Point(391, 260);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(90, 31);
            this.lbl_placa.TabIndex = 47;
            this.lbl_placa.Text = "Placa:";
            this.lbl_placa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_cam
            // 
            this.btn_cam.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_cam.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_cam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cam.Location = new System.Drawing.Point(570, 228);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(73, 29);
            this.btn_cam.TabIndex = 56;
            this.btn_cam.Text = "tomar foto";
            this.btn_cam.UseVisualStyleBackColor = false;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // ckb_tecnico
            // 
            this.ckb_tecnico.AutoSize = true;
            this.ckb_tecnico.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckb_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_tecnico.Location = new System.Drawing.Point(16, 298);
            this.ckb_tecnico.Name = "ckb_tecnico";
            this.ckb_tecnico.Size = new System.Drawing.Size(189, 29);
            this.ckb_tecnico.TabIndex = 61;
            this.ckb_tecnico.Text = "¿Es técnico?";
            this.ckb_tecnico.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.10009F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.897153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.631772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.182736F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.254362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.254362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.703398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.61157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.29779F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_placa, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tipo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_vehiculo, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ckb_tecnico, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_fecha_v, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_id, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_id, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombre, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_telefono, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_torre, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_apto, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_tp_Vh, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_placa, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.pbFotoUser, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_cam, 5, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 387);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 35);
            this.label6.TabIndex = 62;
            this.label6.Text = "Apto:";
            // 
            // txt_fecha_v
            // 
            this.txt_fecha_v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_fecha_v, 3);
            this.txt_fecha_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_v.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fecha_v.Location = new System.Drawing.Point(211, 53);
            this.txt_fecha_v.Name = "txt_fecha_v";
            this.txt_fecha_v.Size = new System.Drawing.Size(237, 31);
            this.txt_fecha_v.TabIndex = 64;
            // 
            // comboBox_id
            // 
            this.comboBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.comboBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Items.AddRange(new object[] {
            "CC",
            "TI",
            "Ps"});
            this.comboBox_id.Location = new System.Drawing.Point(211, 88);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(75, 33);
            this.comboBox_id.TabIndex = 65;
            // 
            // txt_id
            // 
            this.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_id, 3);
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_id.Location = new System.Drawing.Point(211, 123);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(237, 31);
            this.txt_id.TabIndex = 66;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_nombre, 3);
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombre.Location = new System.Drawing.Point(211, 158);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(237, 31);
            this.txt_nombre.TabIndex = 67;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_telefono, 3);
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_telefono.Location = new System.Drawing.Point(211, 193);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(152, 31);
            this.txt_telefono.TabIndex = 68;
            // 
            // txt_torre
            // 
            this.txt_torre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txt_torre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_torre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_torre.Location = new System.Drawing.Point(211, 228);
            this.txt_torre.Name = "txt_torre";
            this.txt_torre.Size = new System.Drawing.Size(75, 31);
            this.txt_torre.TabIndex = 69;
            // 
            // txt_apto
            // 
            this.txt_apto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txt_apto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apto.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_apto.Location = new System.Drawing.Point(391, 228);
            this.txt_apto.Name = "txt_apto";
            this.txt_apto.Size = new System.Drawing.Size(79, 31);
            this.txt_apto.TabIndex = 70;
            // 
            // comboBox_tp_Vh
            // 
            this.comboBox_tp_Vh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.comboBox_tp_Vh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tp_Vh.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_tp_Vh.FormattingEnabled = true;
            this.comboBox_tp_Vh.Location = new System.Drawing.Point(297, 263);
            this.comboBox_tp_Vh.Name = "comboBox_tp_Vh";
            this.comboBox_tp_Vh.Size = new System.Drawing.Size(71, 33);
            this.comboBox_tp_Vh.TabIndex = 71;
            // 
            // txt_placa
            // 
            this.txt_placa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_placa.Location = new System.Drawing.Point(491, 263);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(73, 31);
            this.txt_placa.TabIndex = 72;
            // 
            // Form_Visita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1089, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Visita";
            this.Text = "Form_Visita";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.PictureBox pbFotoUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox_vehiculo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.CheckBox ckb_tecnico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fecha_v;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_torre;
        private System.Windows.Forms.TextBox txt_apto;
        private System.Windows.Forms.ComboBox comboBox_tp_Vh;
        private System.Windows.Forms.TextBox txt_placa;
    }
}