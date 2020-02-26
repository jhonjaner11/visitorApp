namespace visitorApp
{
    partial class Form_Incidencia
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
            this.txt_aptos_i = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_enviar_incidente = new System.Windows.Forms.Button();
            this.rtxt_desc = new System.Windows.Forms.RichTextBox();
            this.txt_fecha_i = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_aptos_i
            // 
            this.txt_aptos_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aptos_i.Location = new System.Drawing.Point(71, 140);
            this.txt_aptos_i.Name = "txt_aptos_i";
            this.txt_aptos_i.Size = new System.Drawing.Size(346, 35);
            this.txt_aptos_i.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(66, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 25);
            this.label17.TabIndex = 26;
            this.label17.Text = "Apartamentos Involucrados:";
            // 
            // btn_enviar_incidente
            // 
            this.btn_enviar_incidente.Location = new System.Drawing.Point(423, 389);
            this.btn_enviar_incidente.Name = "btn_enviar_incidente";
            this.btn_enviar_incidente.Size = new System.Drawing.Size(193, 52);
            this.btn_enviar_incidente.TabIndex = 25;
            this.btn_enviar_incidente.Text = "enviar";
            this.btn_enviar_incidente.UseVisualStyleBackColor = true;
            // 
            // rtxt_desc
            // 
            this.rtxt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_desc.Location = new System.Drawing.Point(93, 288);
            this.rtxt_desc.Name = "rtxt_desc";
            this.rtxt_desc.Size = new System.Drawing.Size(819, 95);
            this.rtxt_desc.TabIndex = 24;
            this.rtxt_desc.Text = "";
            // 
            // txt_fecha_i
            // 
            this.txt_fecha_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_i.Location = new System.Drawing.Point(591, 140);
            this.txt_fecha_i.Name = "txt_fecha_i";
            this.txt_fecha_i.Size = new System.Drawing.Size(283, 35);
            this.txt_fecha_i.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(586, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Descripcion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(446, 55);
            this.label9.TabIndex = 20;
            this.label9.Text = "Registrar Incidente";
            // 
            // Form_Incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 490);
            this.Controls.Add(this.txt_aptos_i);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_enviar_incidente);
            this.Controls.Add(this.rtxt_desc);
            this.Controls.Add(this.txt_fecha_i);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Incidencia";
            this.Text = "Form_Incidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_aptos_i;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_enviar_incidente;
        private System.Windows.Forms.RichTextBox rtxt_desc;
        private System.Windows.Forms.TextBox txt_fecha_i;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}