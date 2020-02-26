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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_f_final = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_f_inicio = new System.Windows.Forms.Label();
            this.time_final = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(919, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 63);
            this.button4.TabIndex = 33;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 63);
            this.button1.TabIndex = 32;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
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
            this.btn_nuevo.Location = new System.Drawing.Point(919, 184);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(90, 63);
            this.btn_nuevo.TabIndex = 31;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(285, 170);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(85, 48);
            this.btn_usuarios.TabIndex = 30;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 48);
            this.button3.TabIndex = 29;
            this.button3.Text = "Personas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dt
            // 
            this.dt.AllowUserToOrderColumns = true;
            this.dt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt.Location = new System.Drawing.Point(21, 232);
            this.dt.MultiSelect = false;
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.ShowEditingIcon = false;
            this.dt.Size = new System.Drawing.Size(873, 179);
            this.dt.TabIndex = 28;
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
            // 
            // btn_mostrar_incidentes
            // 
            this.btn_mostrar_incidentes.Location = new System.Drawing.Point(103, 170);
            this.btn_mostrar_incidentes.Name = "btn_mostrar_incidentes";
            this.btn_mostrar_incidentes.Size = new System.Drawing.Size(85, 48);
            this.btn_mostrar_incidentes.TabIndex = 22;
            this.btn_mostrar_incidentes.Text = "Incidentes";
            this.btn_mostrar_incidentes.UseVisualStyleBackColor = true;
            // 
            // btn_mostrar_visitas
            // 
            this.btn_mostrar_visitas.Location = new System.Drawing.Point(21, 171);
            this.btn_mostrar_visitas.Name = "btn_mostrar_visitas";
            this.btn_mostrar_visitas.Size = new System.Drawing.Size(75, 48);
            this.btn_mostrar_visitas.TabIndex = 21;
            this.btn_mostrar_visitas.Text = "Visitas";
            this.btn_mostrar_visitas.UseVisualStyleBackColor = true;
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
            // Form_bbdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 443);
            this.Controls.Add(this.lbl_f_final);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbl_f_inicio);
            this.Controls.Add(this.time_final);
            this.Controls.Add(this.button1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_bbdd";
            this.Text = "Form_bbdd";
            this.Load += new System.EventHandler(this.Form_bbdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_f_final;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_f_inicio;
        private System.Windows.Forms.DateTimePicker time_final;
        private System.Windows.Forms.Button button1;
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
    }
}