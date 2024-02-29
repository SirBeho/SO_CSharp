namespace OS_BTC
{
    partial class mensaje
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
            this.text_name = new System.Windows.Forms.TextBox();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(39, 39);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(265, 20);
            this.text_name.TabIndex = 0;
            // 
            // Ok_Button
            // 
            this.Ok_Button.Location = new System.Drawing.Point(60, 81);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(75, 23);
            this.Ok_Button.TabIndex = 1;
            this.Ok_Button.Text = " Crear";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(188, 81);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = " Cancelar";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " Nombre de la carpeta:";
            // 
            // mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.text_name);
            this.Name = "mensaje";
            this.Text = "mensaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ok_Button;
        private System.Windows.Forms.Button Cancel_Button;
        public System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label1;
    }
}