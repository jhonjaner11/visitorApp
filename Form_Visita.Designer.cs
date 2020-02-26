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
            this.button2 = new System.Windows.Forms.Button();
            this.txt_apto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecha_v = new System.Windows.Forms.TextBox();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.checkBox_vehiculo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFotoUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 73);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registrar Visita";
            // 
            // txt_placa
            // 
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.Location = new System.Drawing.Point(425, 482);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(88, 31);
            this.txt_placa.TabIndex = 27;
            // 
            // btn_cam
            // 
            this.btn_cam.Location = new System.Drawing.Point(744, 372);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(75, 23);
            this.btn_cam.TabIndex = 35;
            this.btn_cam.Text = "tomar foto";
            this.btn_cam.UseVisualStyleBackColor = true;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.Location = new System.Drawing.Point(420, 439);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(85, 29);
            this.lbl_placa.TabIndex = 26;
            this.lbl_placa.Text = "Placa:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(30, 372);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(235, 31);
            this.txt_telefono.TabIndex = 32;
            // 
            // comboBox_tp_Vh
            // 
            this.comboBox_tp_Vh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tp_Vh.FormattingEnabled = true;
            this.comboBox_tp_Vh.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.comboBox_tp_Vh.Location = new System.Drawing.Point(278, 482);
            this.comboBox_tp_Vh.Name = "comboBox_tp_Vh";
            this.comboBox_tp_Vh.Size = new System.Drawing.Size(111, 33);
            this.comboBox_tp_Vh.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 29);
            this.label12.TabIndex = 40;
            this.label12.Text = "Telefono:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(273, 439);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(74, 29);
            this.lbl_tipo.TabIndex = 21;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(30, 270);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(442, 31);
            this.txt_nombre.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 63);
            this.button2.TabIndex = 37;
            this.button2.Text = "enviar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_apto
            // 
            this.txt_apto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apto.Location = new System.Drawing.Point(30, 489);
            this.txt_apto.Name = "txt_apto";
            this.txt_apto.Size = new System.Drawing.Size(95, 31);
            this.txt_apto.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Apto:";
            // 
            // txt_fecha_v
            // 
            this.txt_fecha_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_v.Location = new System.Drawing.Point(607, 51);
            this.txt_fecha_v.Name = "txt_fecha_v";
            this.txt_fecha_v.Size = new System.Drawing.Size(300, 31);
            this.txt_fecha_v.TabIndex = 38;
            // 
            // comboBox_id
            // 
            this.comboBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Items.AddRange(new object[] {
            "CC",
            "TI",
            "Pasaporte",
            "Cedula Extranjera"});
            this.comboBox_id.Location = new System.Drawing.Point(363, 167);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(74, 33);
            this.comboBox_id.TabIndex = 30;
            // 
            // txt_id
            // 
            this.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(30, 170);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(217, 31);
            this.txt_id.TabIndex = 29;
            // 
            // checkBox_vehiculo
            // 
            this.checkBox_vehiculo.AutoSize = true;
            this.checkBox_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_vehiculo.Location = new System.Drawing.Point(338, 372);
            this.checkBox_vehiculo.Name = "checkBox_vehiculo";
            this.checkBox_vehiculo.Size = new System.Drawing.Size(133, 33);
            this.checkBox_vehiculo.TabIndex = 28;
            this.checkBox_vehiculo.Text = "Vehiculo";
            this.checkBox_vehiculo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Identificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo ID:";
            // 
            // pbFotoUser
            // 
            this.pbFotoUser.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoUser.Image")));
            this.pbFotoUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFotoUser.InitialImage")));
            this.pbFotoUser.Location = new System.Drawing.Point(587, 110);
            this.pbFotoUser.Name = "pbFotoUser";
            this.pbFotoUser.Size = new System.Drawing.Size(349, 232);
            this.pbFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUser.TabIndex = 36;
            this.pbFotoUser.TabStop = false;
            // 
            // Form_Visita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.btn_cam);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.comboBox_tp_Vh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbFotoUser);
            this.Controls.Add(this.txt_apto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_fecha_v);
            this.Controls.Add(this.comboBox_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.checkBox_vehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Visita";
            this.Text = "Form_Visita";
            this.Load += new System.EventHandler(this.Form_Visita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button2;
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
    }
}