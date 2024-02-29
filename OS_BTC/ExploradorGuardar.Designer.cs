namespace OS_BTC
{
    partial class ExploradorGuardar
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
            this.panel_guardar = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_guardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Size = new System.Drawing.Size(555, 210);
            // 
            // panel_guardar
            // 
            this.panel_guardar.Controls.Add(this.btn_guardar);
            this.panel_guardar.Controls.Add(this.text_nombre);
            this.panel_guardar.Controls.Add(this.label1);
            this.panel_guardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_guardar.Location = new System.Drawing.Point(163, 257);
            this.panel_guardar.Name = "panel_guardar";
            this.panel_guardar.Size = new System.Drawing.Size(555, 75);
            this.panel_guardar.TabIndex = 6;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(321, 32);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(103, 22);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // text_nombre
            // 
            this.text_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nombre.Location = new System.Drawing.Point(8, 32);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(294, 22);
            this.text_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Archivo";
            // 
            // ExploradorGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 332);
            this.Controls.Add(this.panel_guardar);
            this.Name = "ExploradorGuardar";
            this.Text = "ExploradorGuardar";
            this.Controls.SetChildIndex(this.panel_guardar, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.panel_guardar.ResumeLayout(false);
            this.panel_guardar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox text_nombre;
    }
}