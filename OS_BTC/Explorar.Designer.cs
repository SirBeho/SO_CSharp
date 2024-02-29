namespace OS_BTC
{
    partial class Explorar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorar));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ListIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.ListIcon;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(225, 311);
            this.treeView1.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 23;
            this.iconButton1.Location = new System.Drawing.Point(198, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(27, 23);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = " ";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ListIcon
            // 
            this.ListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListIcon.ImageStream")));
            this.ListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ListIcon.Images.SetKeyName(0, "carpeta-32.png");
            this.ListIcon.Images.SetKeyName(1, "audio-256.png");
            this.ListIcon.Images.SetKeyName(2, "multimedia-256.png");
            // 
            // Explorar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 311);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.treeView1);
            this.Name = "Explorar";
            this.Text = "explorar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ImageList ListIcon;
    }
}