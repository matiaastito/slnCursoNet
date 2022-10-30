namespace WindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargaProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargaProducto
            // 
            this.btnCargaProducto.Location = new System.Drawing.Point(55, 66);
            this.btnCargaProducto.Name = "btnCargaProducto";
            this.btnCargaProducto.Size = new System.Drawing.Size(227, 21);
            this.btnCargaProducto.TabIndex = 0;
            this.btnCargaProducto.Text = "Cargar Productos";
            this.btnCargaProducto.UseVisualStyleBackColor = true;
            this.btnCargaProducto.Click += new System.EventHandler(this.btnCargaProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargaProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaProducto;
    }
}

