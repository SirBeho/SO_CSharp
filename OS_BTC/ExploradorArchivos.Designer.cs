namespace OS_BTC
{
    partial class ExploradorArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploradorArchivos));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ListIcon = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListLarge = new System.Windows.Forms.ImageList(this.components);
            this.ListSmall = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label_crear = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxVistas = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lavel_ruta_ = new System.Windows.Forms.ToolStripStatusLabel();
            this.lavel_ruta = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.ListIcon;
            this.treeView1.Location = new System.Drawing.Point(0, 47);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(163, 403);
            this.treeView1.TabIndex = 0;
            // 
            // ListIcon
            // 
            this.ListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListIcon.ImageStream")));
            this.ListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ListIcon.Images.SetKeyName(0, "carpeta-32.png");
            this.ListIcon.Images.SetKeyName(1, "txt-256.png");
            this.ListIcon.Images.SetKeyName(2, "audio-256.png");
            this.ListIcon.Images.SetKeyName(3, "multimedia-256.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Tipo,
            this.Tamano});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.LargeImageList = this.ListLarge;
            this.listView1.Location = new System.Drawing.Point(163, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 403);
            this.listView1.SmallImageList = this.ListSmall;
            this.listView1.TabIndex = 1;
            this.listView1.TileSize = new System.Drawing.Size(100, 100);
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 300;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 100;
            // 
            // Tamano
            // 
            this.Tamano.Text = "Tamaño (bytes)";
            this.Tamano.Width = 150;
            // 
            // ListLarge
            // 
            this.ListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListLarge.ImageStream")));
            this.ListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ListLarge.Images.SetKeyName(0, "carpeta-128.png");
            this.ListLarge.Images.SetKeyName(1, "txt-256.png");
            this.ListLarge.Images.SetKeyName(2, "3333.png");
            this.ListLarge.Images.SetKeyName(3, "multimedia-256.png");
            // 
            // ListSmall
            // 
            this.ListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListSmall.ImageStream")));
            this.ListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ListSmall.Images.SetKeyName(0, "carpeta-256.png");
            this.ListSmall.Images.SetKeyName(1, "txt-256.png");
            this.ListSmall.Images.SetKeyName(2, "audio-256.png");
            this.ListSmall.Images.SetKeyName(3, "multimedia-256.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_crear});
            this.toolStrip1.Location = new System.Drawing.Point(44, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // label_crear
            // 
            this.label_crear.Name = "label_crear";
            this.label_crear.Size = new System.Drawing.Size(79, 22);
            this.label_crear.Text = "Crear Carpeta";
            this.label_crear.Click += new System.EventHandler(this.CrearCarpetaButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.comboBoxVistas);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 5;
            // 
            // comboBoxVistas
            // 
            this.comboBoxVistas.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxVistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVistas.FormattingEnabled = true;
            this.comboBoxVistas.Items.AddRange(new object[] {
            "Detalles",
            "Iconos Grandes",
            "Iconos Pequeños",
            "Lista",
            "Mosaico"});
            this.comboBoxVistas.Location = new System.Drawing.Point(695, 0);
            this.comboBoxVistas.Name = "comboBoxVistas";
            this.comboBoxVistas.Size = new System.Drawing.Size(105, 21);
            this.comboBoxVistas.TabIndex = 5;
            this.comboBoxVistas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.iconButton1.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 25);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // lavel_ruta_
            // 
            this.lavel_ruta_.Name = "lavel_ruta_";
            this.lavel_ruta_.Size = new System.Drawing.Size(37, 17);
            this.lavel_ruta_.Text = "Ruta: ";
            // 
            // lavel_ruta
            // 
            this.lavel_ruta.Name = "lavel_ruta";
            this.lavel_ruta.Size = new System.Drawing.Size(10, 17);
            this.lavel_ruta.Text = " ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lavel_ruta_,
            this.lavel_ruta});
            this.statusStrip1.Location = new System.Drawing.Point(0, 25);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip2";
            // 
            // ExploradorArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "ExploradorArchivos";
            this.ShowIcon = false;
            this.Text = "Explorador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Tamano;
        private System.Windows.Forms.ToolStripLabel label_crear;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel lavel_ruta_;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList ListLarge;
        private System.Windows.Forms.ComboBox comboBoxVistas;
        private System.Windows.Forms.ImageList ListSmall;
        private System.Windows.Forms.ImageList ListIcon;
        public System.Windows.Forms.ToolStripStatusLabel lavel_ruta;
        public System.Windows.Forms.ListView listView1;
    }
}