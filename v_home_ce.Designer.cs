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
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pnl_v_home_ce = new System.Windows.Forms.Panel();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.btn_reg_incidente = new System.Windows.Forms.Button();
            this.btn_reg_visita = new System.Windows.Forms.Button();
            this.panel_dock = new System.Windows.Forms.Panel();
            this.pnl_v_home_ce.SuspendLayout();
            this.panel_dock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(3, 202);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(95, 96);
            this.btn_exportar.TabIndex = 2;
            this.btn_exportar.Text = "Base de datos";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_salir.Location = new System.Drawing.Point(0, 596);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(101, 34);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnl_v_home_ce
            // 
            this.pnl_v_home_ce.BackColor = System.Drawing.Color.Transparent;
            this.pnl_v_home_ce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_v_home_ce.Controls.Add(this.pnl_contenedor);
            this.pnl_v_home_ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_v_home_ce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_v_home_ce.Location = new System.Drawing.Point(101, 0);
            this.pnl_v_home_ce.Name = "pnl_v_home_ce";
            this.pnl_v_home_ce.Size = new System.Drawing.Size(1063, 630);
            this.pnl_v_home_ce.TabIndex = 3;

            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Location = new System.Drawing.Point(15, 12);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(1026, 606);
            this.pnl_contenedor.TabIndex = 3;
            // 
            // btn_reg_incidente
            // 
            this.btn_reg_incidente.BackgroundImage = global::visitorApp.Properties.Resources.registro_incidente_icon128;
            this.btn_reg_incidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reg_incidente.FlatAppearance.BorderSize = 0;
            this.btn_reg_incidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg_incidente.Location = new System.Drawing.Point(3, 110);
            this.btn_reg_incidente.Name = "btn_reg_incidente";
            this.btn_reg_incidente.Size = new System.Drawing.Size(95, 86);
            this.btn_reg_incidente.TabIndex = 1;
            this.btn_reg_incidente.UseVisualStyleBackColor = true;
            this.btn_reg_incidente.Click += new System.EventHandler(this.btn_reg_incidente_Click);
            // 
            // btn_reg_visita
            // 
            this.btn_reg_visita.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_reg_visita.BackgroundImage = global::visitorApp.Properties.Resources.visitante_icon128;
            this.btn_reg_visita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reg_visita.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_reg_visita.FlatAppearance.BorderSize = 0;
            this.btn_reg_visita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_reg_visita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg_visita.Location = new System.Drawing.Point(3, 3);
            this.btn_reg_visita.Name = "btn_reg_visita";
            this.btn_reg_visita.Size = new System.Drawing.Size(95, 101);
            this.btn_reg_visita.TabIndex = 0;
            this.btn_reg_visita.UseVisualStyleBackColor = false;
            this.btn_reg_visita.Click += new System.EventHandler(this.btn_reg_visita_Click);
            // 
            // panel_dock
            // 
            this.panel_dock.Controls.Add(this.btn_salir);
            this.panel_dock.Controls.Add(this.btn_exportar);
            this.panel_dock.Controls.Add(this.btn_reg_visita);
            this.panel_dock.Controls.Add(this.btn_reg_incidente);
            this.panel_dock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_dock.Location = new System.Drawing.Point(0, 0);
            this.panel_dock.Name = "panel_dock";
            this.panel_dock.Size = new System.Drawing.Size(101, 630);
            this.panel_dock.TabIndex = 4;
            // 
            // v_home_ce
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::visitorApp.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 630);
            this.Controls.Add(this.pnl_v_home_ce);
            this.Controls.Add(this.panel_dock);
            this.Name = "v_home_ce";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "VisitorApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.v_home_ce_Load);
            this.pnl_v_home_ce.ResumeLayout(false);
            this.panel_dock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reg_incidente;
        private System.Windows.Forms.Button btn_reg_visita;
        private System.Windows.Forms.Panel pnl_v_home_ce;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Panel panel_dock;
        private System.Windows.Forms.Panel pnl_contenedor;
    }
}