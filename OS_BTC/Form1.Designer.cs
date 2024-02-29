namespace OS_BTC
{
    partial class Form1
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
            this.panel_BarraTareas = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_abr_explorador = new FontAwesome.Sharp.IconButton();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.panel_WinMenu = new System.Windows.Forms.Panel();
            this.btn_abr_multimedia = new FontAwesome.Sharp.IconButton();
            this.btn_abr_nota = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel_BarraTareas.SuspendLayout();
            this.panel_desktop.SuspendLayout();
            this.panel_WinMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_BarraTareas
            // 
            this.panel_BarraTareas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_BarraTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BarraTareas.Controls.Add(this.btn_Home);
            this.panel_BarraTareas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_BarraTareas.Location = new System.Drawing.Point(0, 593);
            this.panel_BarraTareas.Margin = new System.Windows.Forms.Padding(2);
            this.panel_BarraTareas.Name = "panel_BarraTareas";
            this.panel_BarraTareas.Size = new System.Drawing.Size(1010, 48);
            this.panel_BarraTareas.TabIndex = 10;
            this.panel_BarraTareas.Click += new System.EventHandler(this.cerrar_menu);
            // 
            // btn_Home
            // 
            this.btn_Home.BackgroundImage = global::OS_BTC.Properties.Resources.windows_11;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(37, 46);
            this.btn_Home.TabIndex = 10;
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_abr_explorador
            // 
            this.btn_abr_explorador.BackColor = System.Drawing.Color.Transparent;
            this.btn_abr_explorador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_abr_explorador.FlatAppearance.BorderSize = 0;
            this.btn_abr_explorador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_abr_explorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abr_explorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abr_explorador.ForeColor = System.Drawing.Color.White;
            this.btn_abr_explorador.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btn_abr_explorador.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_abr_explorador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_abr_explorador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abr_explorador.Location = new System.Drawing.Point(0, 0);
            this.btn_abr_explorador.Name = "btn_abr_explorador";
            this.btn_abr_explorador.Size = new System.Drawing.Size(301, 62);
            this.btn_abr_explorador.TabIndex = 1;
            this.btn_abr_explorador.Text = "Explorador";
            this.btn_abr_explorador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abr_explorador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abr_explorador.UseVisualStyleBackColor = false;
            this.btn_abr_explorador.Click += new System.EventHandler(this.Abrir_Explorador);
            // 
            // panel_desktop
            // 
            this.panel_desktop.BackColor = System.Drawing.Color.Transparent;
            this.panel_desktop.Controls.Add(this.panel_WinMenu);
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.Location = new System.Drawing.Point(0, 0);
            this.panel_desktop.Margin = new System.Windows.Forms.Padding(2);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(1010, 641);
            this.panel_desktop.TabIndex = 21;
            this.panel_desktop.Click += new System.EventHandler(this.cerrar_menu);
            // 
            // panel_WinMenu
            // 
            this.panel_WinMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_WinMenu.Controls.Add(this.btn_abr_multimedia);
            this.panel_WinMenu.Controls.Add(this.btn_abr_nota);
            this.panel_WinMenu.Controls.Add(this.btn_Exit);
            this.panel_WinMenu.Controls.Add(this.btn_abr_explorador);
            this.panel_WinMenu.Location = new System.Drawing.Point(9, 185);
            this.panel_WinMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_WinMenu.Name = "panel_WinMenu";
            this.panel_WinMenu.Size = new System.Drawing.Size(301, 404);
            this.panel_WinMenu.TabIndex = 21;
            // 
            // btn_abr_multimedia
            // 
            this.btn_abr_multimedia.BackColor = System.Drawing.Color.Transparent;
            this.btn_abr_multimedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_abr_multimedia.FlatAppearance.BorderSize = 0;
            this.btn_abr_multimedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_abr_multimedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abr_multimedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abr_multimedia.ForeColor = System.Drawing.Color.White;
            this.btn_abr_multimedia.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btn_abr_multimedia.IconColor = System.Drawing.Color.Crimson;
            this.btn_abr_multimedia.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_abr_multimedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abr_multimedia.Location = new System.Drawing.Point(0, 124);
            this.btn_abr_multimedia.Name = "btn_abr_multimedia";
            this.btn_abr_multimedia.Size = new System.Drawing.Size(301, 62);
            this.btn_abr_multimedia.TabIndex = 4;
            this.btn_abr_multimedia.Text = " Multimedia";
            this.btn_abr_multimedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abr_multimedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abr_multimedia.UseVisualStyleBackColor = false;
            this.btn_abr_multimedia.Click += new System.EventHandler(this.btn_abr_multimedia_Click);
            // 
            // btn_abr_nota
            // 
            this.btn_abr_nota.BackColor = System.Drawing.Color.Transparent;
            this.btn_abr_nota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_abr_nota.FlatAppearance.BorderSize = 0;
            this.btn_abr_nota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_abr_nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abr_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abr_nota.ForeColor = System.Drawing.Color.White;
            this.btn_abr_nota.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btn_abr_nota.IconColor = System.Drawing.Color.White;
            this.btn_abr_nota.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_abr_nota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abr_nota.Location = new System.Drawing.Point(0, 62);
            this.btn_abr_nota.Name = "btn_abr_nota";
            this.btn_abr_nota.Size = new System.Drawing.Size(301, 62);
            this.btn_abr_nota.TabIndex = 3;
            this.btn_abr_nota.Text = "Bloc de Nota";
            this.btn_abr_nota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abr_nota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abr_nota.UseVisualStyleBackColor = false;
            this.btn_abr_nota.Click += new System.EventHandler(this.btn_abr_nota_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 32;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Exit.Location = new System.Drawing.Point(203, 367);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(95, 35);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Apagar";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OS_BTC.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 641);
            this.Controls.Add(this.panel_BarraTareas);
            this.Controls.Add(this.panel_desktop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_BarraTareas.ResumeLayout(false);
            this.panel_desktop.ResumeLayout(false);
            this.panel_WinMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_BarraTareas;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel_WinMenu;
        private FontAwesome.Sharp.IconButton btn_abr_explorador;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconButton btn_abr_nota;
        public System.Windows.Forms.Panel panel_desktop;
        private FontAwesome.Sharp.IconButton btn_abr_multimedia;
    }
}

