namespace WindowsApp
{
    partial class FrmPractica3
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
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.Location = new System.Drawing.Point(285, 185);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(208, 25);
            this.btnCargaDatos.TabIndex = 0;
            this.btnCargaDatos.Text = "Cargar Datos";
            this.btnCargaDatos.UseVisualStyleBackColor = true;
            this.btnCargaDatos.Click += new System.EventHandler(this.btnCargaDatos_Click);
            // 
            // FrmPractica3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargaDatos);
            this.Name = "FrmPractica3";
            this.Text = "FrmPractica3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaDatos;
    }
}