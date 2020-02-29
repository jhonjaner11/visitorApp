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
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.btn_cam = new System.Windows.Forms.Button();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.comboBox_tp_Vh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecha_v = new System.Windows.Forms.TextBox();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.checkBox_vehiculo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ckb_tecnico = new System.Windows.Forms.CheckBox();
            this.pbFotoUser = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).BeginInit();
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
            // txt_placa
            // 
            this.txt_placa.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.Location = new System.Drawing.Point(657, 304);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(148, 35);
            this.txt_placa.TabIndex = 27;
            // 
            // btn_cam
            // 
            this.btn_cam.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_cam.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cam.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_cam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cam.Location = new System.Drawing.Point(657, 218);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(209, 37);
            this.btn_cam.TabIndex = 35;
            this.btn_cam.Text = "tomar foto";
            this.btn_cam.UseVisualStyleBackColor = false;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.Location = new System.Drawing.Point(591, 301);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(60, 43);
            this.lbl_placa.TabIndex = 26;
            this.lbl_placa.Text = "Placa:";
            this.lbl_placa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(280, 218);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(130, 35);
            this.txt_telefono.TabIndex = 32;
            // 
            // comboBox_tp_Vh
            // 
            this.comboBox_tp_Vh.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_tp_Vh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tp_Vh.FormattingEnabled = true;
            this.comboBox_tp_Vh.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.comboBox_tp_Vh.Location = new System.Drawing.Point(416, 304);
            this.comboBox_tp_Vh.Name = "comboBox_tp_Vh";
            this.comboBox_tp_Vh.Size = new System.Drawing.Size(166, 37);
            this.comboBox_tp_Vh.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(158, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 43);
            this.label12.TabIndex = 40;
            this.label12.Text = "Telefono:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(341, 301);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(69, 43);
            this.lbl_tipo.TabIndex = 21;
            this.lbl_tipo.Text = "Tipo:";
            this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_nombre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_nombre, 2);
            this.txt_nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(280, 175);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(303, 35);
            this.txt_nombre.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 43);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nombre:";
            // 
            // txt_apto
            // 
            this.txt_apto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_apto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apto.Location = new System.Drawing.Point(280, 261);
            this.txt_apto.Name = "txt_apto";
            this.txt_apto.Size = new System.Drawing.Size(130, 35);
            this.txt_apto.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 43);
            this.label8.TabIndex = 33;
            this.label8.Text = "Apto:";
            // 
            // txt_fecha_v
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_fecha_v, 2);
            this.txt_fecha_v.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_fecha_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_v.Location = new System.Drawing.Point(280, 46);
            this.txt_fecha_v.Name = "txt_fecha_v";
            this.txt_fecha_v.Size = new System.Drawing.Size(303, 35);
            this.txt_fecha_v.TabIndex = 38;
            // 
            // comboBox_id
            // 
            this.comboBox_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Items.AddRange(new object[] {
            "CC",
            "TI",
            "Pasaporte",
            "Cedula Extranjera"});
            this.comboBox_id.Location = new System.Drawing.Point(280, 89);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(130, 37);
            this.comboBox_id.TabIndex = 30;
            // 
            // txt_id
            // 
            this.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_id, 2);
            this.txt_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(280, 132);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(303, 35);
            this.txt_id.TabIndex = 29;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // checkBox_vehiculo
            // 
            this.checkBox_vehiculo.AutoSize = true;
            this.checkBox_vehiculo.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_vehiculo.Location = new System.Drawing.Point(132, 304);
            this.checkBox_vehiculo.Name = "checkBox_vehiculo";
            this.checkBox_vehiculo.Size = new System.Drawing.Size(125, 37);
            this.checkBox_vehiculo.TabIndex = 28;
            this.checkBox_vehiculo.Text = "Vehiculo";
            this.checkBox_vehiculo.UseVisualStyleBackColor = true;
            this.checkBox_vehiculo.CheckedChanged += new System.EventHandler(this.checkBox_vehiculo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 43);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 43);
            this.label3.TabIndex = 24;
            this.label3.Text = "Identificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 43);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo ID:";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.9419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.66326F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.92254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.293706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.80635F));
            this.tableLayoutPanel1.Controls.Add(this.txt_fecha_v, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbFotoUser, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_apto, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_id, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_telefono, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_id, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombre, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_vehiculo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tipo, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_tp_Vh, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_placa, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_placa, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_cam, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.ckb_tecnico, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.80487F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 387);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // ckb_tecnico
            // 
            this.ckb_tecnico.AutoSize = true;
            this.ckb_tecnico.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckb_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_tecnico.Location = new System.Drawing.Point(132, 347);
            this.ckb_tecnico.Name = "ckb_tecnico";
            this.ckb_tecnico.Size = new System.Drawing.Size(142, 37);
            this.ckb_tecnico.TabIndex = 41;
            this.ckb_tecnico.Text = "¿Es técnico?";
            this.ckb_tecnico.UseVisualStyleBackColor = true;
            // 
            // pbFotoUser
            // 
            this.pbFotoUser.Image = global::visitorApp.Properties.Resources.visitante_icon;
            this.pbFotoUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFotoUser.InitialImage")));
            this.pbFotoUser.Location = new System.Drawing.Point(657, 46);
            this.pbFotoUser.Name = "pbFotoUser";
            this.tableLayoutPanel1.SetRowSpan(this.pbFotoUser, 4);
            this.pbFotoUser.Size = new System.Drawing.Size(209, 154);
            this.pbFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUser.TabIndex = 36;
            this.pbFotoUser.TabStop = false;
            // 
            // Form_Visita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1089, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Visita";
            this.Text = "Form_Visita";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.ComboBox comboBox_tp_Vh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.PictureBox pbFotoUser;
        private System.Windows.Forms.TextBox txt_apto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fecha_v;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.CheckBox checkBox_vehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox ckb_tecnico;
    }
}