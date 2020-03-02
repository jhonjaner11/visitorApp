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
            this.pnl_v_home_ce = new System.Windows.Forms.Panel();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.panel_dock = new System.Windows.Forms.Panel();
            this.btn_entrega = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_reg_incidente = new System.Windows.Forms.Button();
            this.btn_reg_visita = new System.Windows.Forms.Button();
            this.pnl_v_home_ce.SuspendLayout();
            this.panel_dock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_v_home_ce
            // 
            this.pnl_v_home_ce.BackColor = System.Drawing.Color.Transparent;
            this.pnl_v_home_ce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_v_home_ce.Controls.Add(this.pnl_contenedor);
            this.pnl_v_home_ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_v_home_ce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_v_home_ce.Location = new System.Drawing.Point(75, 0);
            this.pnl_v_home_ce.Name = "pnl_v_home_ce";
            this.pnl_v_home_ce.Size = new System.Drawing.Size(1243, 748);
            this.pnl_v_home_ce.TabIndex = 3;
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnl_contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_contenedor.Location = new System.Drawing.Point(0, 0);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(1243, 748);
            this.pnl_contenedor.TabIndex = 3;
            // 
            // panel_dock
            // 
            this.panel_dock.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_dock.Controls.Add(this.btn_entrega);
            this.panel_dock.Controls.Add(this.btn_users);
            this.panel_dock.Controls.Add(this.btn_configuracion);
            this.panel_dock.Controls.Add(this.btn_salir);
            this.panel_dock.Controls.Add(this.btn_exportar);
            this.panel_dock.Controls.Add(this.btn_reg_incidente);
            this.panel_dock.Controls.Add(this.btn_reg_visita);
            this.panel_dock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_dock.Location = new System.Drawing.Point(0, 0);
            this.panel_dock.Name = "panel_dock";
            this.panel_dock.Size = new System.Drawing.Size(75, 748);
            this.panel_dock.TabIndex = 4;
            // 
            // btn_entrega
            // 
            this.btn_entrega.AccessibleDescription = "Configuración";
            this.btn_entrega.BackgroundImage = global::visitorApp.Properties.Resources.caja_icon64;
            this.btn_entrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_entrega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_entrega.FlatAppearance.BorderSize = 0;
            this.btn_entrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_entrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrega.Location = new System.Drawing.Point(0, 225);
            this.btn_entrega.Name = "btn_entrega";
            this.btn_entrega.Size = new System.Drawing.Size(75, 75);
            this.btn_entrega.TabIndex = 6;
            this.btn_entrega.UseVisualStyleBackColor = true;
            this.btn_entrega.Click += new System.EventHandler(this.btn_entrega_Click);
            // 
            // btn_users
            // 
            this.btn_users.AccessibleDescription = "Configuración";
            this.btn_users.BackgroundImage = global::visitorApp.Properties.Resources.gestion_user_icon64;
            this.btn_users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_users.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Location = new System.Drawing.Point(0, 527);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(75, 75);
            this.btn_users.TabIndex = 5;
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.BackgroundImage = global::visitorApp.Properties.Resources.configuracion_icon64;
            this.btn_configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_configuracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_configuracion.FlatAppearance.BorderSize = 0;
            this.btn_configuracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Location = new System.Drawing.Point(0, 602);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(75, 71);
            this.btn_configuracion.TabIndex = 4;
            this.btn_configuracion.UseVisualStyleBackColor = true;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::visitorApp.Properties.Resources.salir_icon64;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(0, 673);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 75);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackgroundImage = global::visitorApp.Properties.Resources.base_datos_64;
            this.btn_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Location = new System.Drawing.Point(0, 150);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(75, 75);
            this.btn_exportar.TabIndex = 2;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click_1);
            // 
            // btn_reg_incidente
            // 
            this.btn_reg_incidente.BackColor = System.Drawing.Color.Transparent;
            this.btn_reg_incidente.BackgroundImage = global::visitorApp.Properties.Resources.registro_incidente_icon64;
            this.btn_reg_incidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reg_incidente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_reg_incidente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reg_incidente.FlatAppearance.BorderSize = 0;
            this.btn_reg_incidente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_reg_incidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg_incidente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reg_incidente.Location = new System.Drawing.Point(0, 75);
            this.btn_reg_incidente.Name = "btn_reg_incidente";
            this.btn_reg_incidente.Size = new System.Drawing.Size(75, 75);
            this.btn_reg_incidente.TabIndex = 1;
            this.btn_reg_incidente.UseVisualStyleBackColor = false;
            this.btn_reg_incidente.Click += new System.EventHandler(this.btn_reg_incidente_Click);
            // 
            // btn_reg_visita
            // 
            this.btn_reg_visita.BackgroundImage = global::visitorApp.Properties.Resources.visitante_icon64;
            this.btn_reg_visita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reg_visita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reg_visita.FlatAppearance.BorderSize = 0;
            this.btn_reg_visita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_reg_visita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg_visita.Location = new System.Drawing.Point(0, 0);
            this.btn_reg_visita.Name = "btn_reg_visita";
            this.btn_reg_visita.Size = new System.Drawing.Size(75, 75);
            this.btn_reg_visita.TabIndex = 0;
            this.btn_reg_visita.UseVisualStyleBackColor = true;
            this.btn_reg_visita.Click += new System.EventHandler(this.btn_reg_visita_Click);
            // 
            // v_home_ce
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1318, 748);
            this.Controls.Add(this.pnl_v_home_ce);
            this.Controls.Add(this.panel_dock);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btn_reg_visita;
        private System.Windows.Forms.Button btn_reg_incidente;
        private System.Windows.Forms.Panel pnl_v_home_ce;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Panel panel_dock;
        private System.Windows.Forms.Button btn_entrega;
    }
}