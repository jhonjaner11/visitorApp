namespace visitorApp
{
    partial class Form_bbdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_f_final = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_f_inicio = new System.Windows.Forms.Label();
            this.time_final = new System.Windows.Forms.DateTimePicker();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.time_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.chk_Box_filtro = new System.Windows.Forms.CheckBox();
            this.btn_mostrar_incidentes = new System.Windows.Forms.Button();
            this.btn_mostrar_visitas = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_f_final
            // 
            this.lbl_f_final.AutoSize = true;
            this.lbl_f_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_final.Location = new System.Drawing.Point(736, 86);
            this.lbl_f_final.Name = "lbl_f_final";
            this.lbl_f_final.Size = new System.Drawing.Size(143, 25);
            this.lbl_f_final.TabIndex = 26;
            this.lbl_f_final.Text = "Fecha Final:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(804, 301);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(90, 63);
            this.btn_modificar.TabIndex = 33;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbl_f_inicio
            // 
            this.lbl_f_inicio.AutoSize = true;
            this.lbl_f_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_inicio.Location = new System.Drawing.Point(565, 86);
            this.lbl_f_inicio.Name = "lbl_f_inicio";
            this.lbl_f_inicio.Size = new System.Drawing.Size(147, 25);
            this.lbl_f_inicio.TabIndex = 25;
            this.lbl_f_inicio.Text = "Fecha Inicio:";
            // 
            // time_final
            // 
            this.time_final.CustomFormat = "";
            this.time_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_final.Location = new System.Drawing.Point(741, 114);
            this.time_final.Name = "time_final";
            this.time_final.Size = new System.Drawing.Size(153, 31);
            this.time_final.TabIndex = 24;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(804, 370);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 63);
            this.btn_eliminar.TabIndex = 32;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // time_inicio
            // 
            this.time_inicio.CustomFormat = "";
            this.time_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_inicio.Location = new System.Drawing.Point(564, 114);
            this.time_inicio.Name = "time_inicio";
            this.time_inicio.Size = new System.Drawing.Size(148, 31);
            this.time_inicio.TabIndex = 23;
            this.time_inicio.Value = new System.DateTime(2020, 2, 19, 23, 49, 47, 0);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(789, 232);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(90, 63);
            this.btn_nuevo.TabIndex = 31;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(285, 170);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(85, 48);
            this.btn_usuarios.TabIndex = 30;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 48);
            this.button3.TabIndex = 29;
            this.button3.Text = "Personas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToOrderColumns = true;
            this.dt.AllowUserToResizeRows = false;
            this.dt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.CausesValidation = false;
            this.dt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dt.Location = new System.Drawing.Point(21, 232);
            this.dt.MultiSelect = false;
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.ShowEditingIcon = false;
            this.dt.Size = new System.Drawing.Size(668, 179);
            this.dt.TabIndex = 28;
            this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellClick);
            // 
            // chk_Box_filtro
            // 
            this.chk_Box_filtro.AutoSize = true;
            this.chk_Box_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Box_filtro.Location = new System.Drawing.Point(691, 56);
            this.chk_Box_filtro.Name = "chk_Box_filtro";
            this.chk_Box_filtro.Size = new System.Drawing.Size(64, 24);
            this.chk_Box_filtro.TabIndex = 27;
            this.chk_Box_filtro.Text = "filtro";
            this.chk_Box_filtro.UseVisualStyleBackColor = true;
            this.chk_Box_filtro.CheckedChanged += new System.EventHandler(this.chk_Box_filtro_CheckedChanged_1);
            // 
            // btn_mostrar_incidentes
            // 
            this.btn_mostrar_incidentes.Location = new System.Drawing.Point(103, 170);
            this.btn_mostrar_incidentes.Name = "btn_mostrar_incidentes";
            this.btn_mostrar_incidentes.Size = new System.Drawing.Size(85, 48);
            this.btn_mostrar_incidentes.TabIndex = 22;
            this.btn_mostrar_incidentes.Text = "Incidentes";
            this.btn_mostrar_incidentes.UseVisualStyleBackColor = true;
            this.btn_mostrar_incidentes.Click += new System.EventHandler(this.btn_mostrar_incidentes_Click);
            // 
            // btn_mostrar_visitas
            // 
            this.btn_mostrar_visitas.Location = new System.Drawing.Point(21, 171);
            this.btn_mostrar_visitas.Name = "btn_mostrar_visitas";
            this.btn_mostrar_visitas.Size = new System.Drawing.Size(75, 48);
            this.btn_mostrar_visitas.TabIndex = 21;
            this.btn_mostrar_visitas.Text = "Visitas";
            this.btn_mostrar_visitas.UseVisualStyleBackColor = true;
            this.btn_mostrar_visitas.Click += new System.EventHandler(this.btn_mostrar_visitas_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(420, 40);
            this.label14.TabIndex = 20;
            this.label14.Text = "Este modulo permite descargar en formato Excel \r\nlas visitas e incidentes que est" +
    "en registrados en el sistema";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(474, 73);
            this.label13.TabIndex = 19;
            this.label13.Text = "Exportar Datos";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(396, 434);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 34;
            this.btn_export.Text = "Exportar";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(950, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_bbdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1031, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lbl_f_final);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_f_inicio);
            this.Controls.Add(this.time_final);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.time_inicio);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_usuarios);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.chk_Box_filtro);
            this.Controls.Add(this.btn_mostrar_incidentes);
            this.Controls.Add(this.btn_mostrar_visitas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_bbdd";
            this.Text = "Form_bbdd";
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_f_final;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_f_inicio;
        private System.Windows.Forms.DateTimePicker time_final;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DateTimePicker time_inicio;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.CheckBox chk_Box_filtro;
        private System.Windows.Forms.Button btn_mostrar_incidentes;
        private System.Windows.Forms.Button btn_mostrar_visitas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button button1;
    }
}