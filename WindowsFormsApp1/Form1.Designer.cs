namespace WindowsFormsApp1
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonConsultar
            // 
            this.ButtonConsultar.Location = new System.Drawing.Point(337, 255);
            this.ButtonConsultar.Name = "ButtonConsultar";
            this.ButtonConsultar.Size = new System.Drawing.Size(75, 23);
            this.ButtonConsultar.TabIndex = 0;
            this.ButtonConsultar.Text = "Consultar";
            this.ButtonConsultar.UseVisualStyleBackColor = true;
            this.ButtonConsultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonConsultar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Aplicativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonConsultar;
    }
}

