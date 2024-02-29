namespace OS_BTC
{
    partial class Multimedia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multimedia));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("cancion");
            this.lblDuracionTotal = new System.Windows.Forms.Label();
            this.lblPosicionActual = new System.Windows.Forms.Label();
            this.btn_play = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_mute = new FontAwesome.Sharp.IconButton();
            this.trackBarPosicion = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.name_music = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dir_music = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.adelante = new FontAwesome.Sharp.IconButton();
            this.atras = new FontAwesome.Sharp.IconButton();
            this.txt_volumen = new System.Windows.Forms.Label();
            this.vol_bar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewCanciones = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosicion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vol_bar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDuracionTotal
            // 
            this.lblDuracionTotal.AutoSize = true;
            this.lblDuracionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionTotal.Location = new System.Drawing.Point(667, 42);
            this.lblDuracionTotal.Name = "lblDuracionTotal";
            this.lblDuracionTotal.Size = new System.Drawing.Size(71, 20);
            this.lblDuracionTotal.TabIndex = 0;
            this.lblDuracionTotal.Text = "00:00:00";
            // 
            // lblPosicionActual
            // 
            this.lblPosicionActual.AutoSize = true;
            this.lblPosicionActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblPosicionActual.Location = new System.Drawing.Point(17, 41);
            this.lblPosicionActual.Name = "lblPosicionActual";
            this.lblPosicionActual.Size = new System.Drawing.Size(71, 20);
            this.lblPosicionActual.TabIndex = 1;
            this.lblPosicionActual.Text = "00:00:00";
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_play.CausesValidation = false;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_play.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.btn_play.IconColor = System.Drawing.Color.Crimson;
            this.btn_play.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_play.IconSize = 64;
            this.btn_play.Location = new System.Drawing.Point(345, 41);
            this.btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(69, 60);
            this.btn_play.TabIndex = 2;
            this.btn_play.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton2.CausesValidation = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            this.iconButton2.IconColor = System.Drawing.Color.Crimson;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(448, 57);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(39, 38);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btn_mute
            // 
            this.btn_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_mute.CausesValidation = false;
            this.btn_mute.FlatAppearance.BorderSize = 0;
            this.btn_mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_mute.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
            this.btn_mute.IconColor = System.Drawing.Color.Crimson;
            this.btn_mute.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_mute.IconSize = 40;
            this.btn_mute.Location = new System.Drawing.Point(45, 68);
            this.btn_mute.Margin = new System.Windows.Forms.Padding(0);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(40, 30);
            this.btn_mute.TabIndex = 4;
            this.btn_mute.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_mute.UseVisualStyleBackColor = true;
            this.btn_mute.Click += new System.EventHandler(this.btn_mute_click);
            // 
            // trackBarPosicion
            // 
            this.trackBarPosicion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.trackBarPosicion.Location = new System.Drawing.Point(9, 17);
            this.trackBarPosicion.Maximum = 100;
            this.trackBarPosicion.Name = "trackBarPosicion";
            this.trackBarPosicion.Size = new System.Drawing.Size(740, 45);
            this.trackBarPosicion.TabIndex = 5;
            this.trackBarPosicion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPosicion.Scroll += new System.EventHandler(this.trackBarPosicion_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // name_music
            // 
            this.name_music.AutoSize = true;
            this.name_music.BackColor = System.Drawing.Color.Transparent;
            this.name_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_music.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_music.ForeColor = System.Drawing.Color.White;
            this.name_music.Location = new System.Drawing.Point(70, 107);
            this.name_music.MaximumSize = new System.Drawing.Size(500, 100);
            this.name_music.Name = "name_music";
            this.name_music.Size = new System.Drawing.Size(334, 32);
            this.name_music.TabIndex = 7;
            this.name_music.Text = "........................................";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(73, 191);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 18);
            this.label.TabIndex = 8;
            this.label.Text = "Ruta :";
            // 
            // dir_music
            // 
            this.dir_music.AutoSize = true;
            this.dir_music.BackColor = System.Drawing.Color.Transparent;
            this.dir_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dir_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir_music.ForeColor = System.Drawing.Color.White;
            this.dir_music.Location = new System.Drawing.Point(119, 191);
            this.dir_music.MaximumSize = new System.Drawing.Size(500, 0);
            this.dir_music.Name = "dir_music";
            this.dir_music.Size = new System.Drawing.Size(380, 18);
            this.dir_music.TabIndex = 10;
            this.dir_music.Text = " ______________________________________________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.iconButton5);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.adelante);
            this.panel1.Controls.Add(this.atras);
            this.panel1.Controls.Add(this.txt_volumen);
            this.panel1.Controls.Add(this.vol_bar);
            this.panel1.Controls.Add(this.btn_mute);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.lblPosicionActual);
            this.panel1.Controls.Add(this.lblDuracionTotal);
            this.panel1.Controls.Add(this.trackBarPosicion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 108);
            this.panel1.TabIndex = 11;
            // 
            // iconButton5
            // 
            this.iconButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton5.CausesValidation = false;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.iconButton5.IconColor = System.Drawing.Color.Crimson;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.IconSize = 35;
            this.iconButton5.Location = new System.Drawing.Point(689, 61);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(40, 40);
            this.iconButton5.TabIndex = 11;
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton4.CausesValidation = false;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.BackwardFast;
            this.iconButton4.IconColor = System.Drawing.Color.Crimson;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(272, 57);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(39, 38);
            this.iconButton4.TabIndex = 10;
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // adelante
            // 
            this.adelante.FlatAppearance.BorderSize = 0;
            this.adelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adelante.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.adelante.IconColor = System.Drawing.Color.Crimson;
            this.adelante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adelante.IconSize = 30;
            this.adelante.Location = new System.Drawing.Point(417, 61);
            this.adelante.Name = "adelante";
            this.adelante.Size = new System.Drawing.Size(28, 29);
            this.adelante.TabIndex = 9;
            this.adelante.UseVisualStyleBackColor = true;
            this.adelante.Click += new System.EventHandler(this.adelante_Click);
            // 
            // atras
            // 
            this.atras.FlatAppearance.BorderSize = 0;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.atras.IconColor = System.Drawing.Color.Crimson;
            this.atras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.atras.IconSize = 30;
            this.atras.Location = new System.Drawing.Point(314, 61);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(28, 29);
            this.atras.TabIndex = 8;
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txt_volumen
            // 
            this.txt_volumen.AutoSize = true;
            this.txt_volumen.Location = new System.Drawing.Point(165, 78);
            this.txt_volumen.Name = "txt_volumen";
            this.txt_volumen.Size = new System.Drawing.Size(25, 13);
            this.txt_volumen.TabIndex = 7;
            this.txt_volumen.Tag = "";
            this.txt_volumen.Text = "100";
            // 
            // vol_bar
            // 
            this.vol_bar.LargeChange = 1;
            this.vol_bar.Location = new System.Drawing.Point(83, 74);
            this.vol_bar.Maximum = 100;
            this.vol_bar.Name = "vol_bar";
            this.vol_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vol_bar.Size = new System.Drawing.Size(86, 45);
            this.vol_bar.TabIndex = 6;
            this.vol_bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.vol_bar.Value = 100;
            this.vol_bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = " Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dir_music);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.name_music);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 342);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 342);
            this.panel3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewCanciones);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 264);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Lista Actual";
            // 
            // listViewCanciones
            // 
            this.listViewCanciones.HideSelection = false;
            listViewItem2.StateImageIndex = 0;
            this.listViewCanciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewCanciones.Location = new System.Drawing.Point(6, 19);
            this.listViewCanciones.Name = "listViewCanciones";
            this.listViewCanciones.Size = new System.Drawing.Size(178, 239);
            this.listViewCanciones.TabIndex = 1;
            this.listViewCanciones.UseCompatibleStateImageBehavior = false;
            this.listViewCanciones.View = System.Windows.Forms.View.List;
            this.listViewCanciones.SelectedIndexChanged += new System.EventHandler(this.listViewCanciones_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton3);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBoxListas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 78);
            this.panel4.TabIndex = 6;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Red;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 24;
            this.iconButton3.Location = new System.Drawing.Point(32, 48);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(23, 24);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(9, 50);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(23, 22);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = " Listas de Reproduccion";
            // 
            // comboBoxListas
            // 
            this.comboBoxListas.FormattingEnabled = true;
            this.comboBoxListas.Location = new System.Drawing.Point(4, 27);
            this.comboBoxListas.Name = "comboBoxListas";
            this.comboBoxListas.Size = new System.Drawing.Size(141, 21);
            this.comboBoxListas.TabIndex = 0;
            this.comboBoxListas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListas_SelectedIndexChanged);
            // 
            // Multimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Multimedia";
            this.Text = "Multimedia";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosicion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vol_bar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDuracionTotal;
        private System.Windows.Forms.Label lblPosicionActual;
        private FontAwesome.Sharp.IconButton btn_play;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btn_mute;
        private System.Windows.Forms.TrackBar trackBarPosicion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label name_music;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label dir_music;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar vol_bar;
        private System.Windows.Forms.Label txt_volumen;
        private FontAwesome.Sharp.IconButton adelante;
        private FontAwesome.Sharp.IconButton atras;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBoxListas;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewCanciones;
    }
}