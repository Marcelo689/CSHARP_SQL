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
            this.ListViewItem = new System.Windows.Forms.ListView();
            this.Texto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBoxFiltro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonConsultar
            // 
            this.ButtonConsultar.Location = new System.Drawing.Point(465, 77);
            this.ButtonConsultar.Name = "ButtonConsultar";
            this.ButtonConsultar.Size = new System.Drawing.Size(75, 23);
            this.ButtonConsultar.TabIndex = 0;
            this.ButtonConsultar.Text = "Consultar";
            this.ButtonConsultar.UseVisualStyleBackColor = true;
            this.ButtonConsultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // ListViewItem
            // 
            this.ListViewItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Texto,
            this.Valor,
            this.Data});
            this.ListViewItem.HideSelection = false;
            this.ListViewItem.Location = new System.Drawing.Point(25, 32);
            this.ListViewItem.Name = "ListViewItem";
            this.ListViewItem.Size = new System.Drawing.Size(341, 387);
            this.ListViewItem.TabIndex = 1;
            this.ListViewItem.UseCompatibleStateImageBehavior = false;
            this.ListViewItem.SelectedIndexChanged += new System.EventHandler(this.Form_Load);
            // 
            // Texto
            // 
            this.Texto.Text = "Texto";
            this.Texto.Width = 120;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 120;
            // 
            // TextBoxFiltro
            // 
            this.TextBoxFiltro.Location = new System.Drawing.Point(422, 32);
            this.TextBoxFiltro.Name = "TextBoxFiltro";
            this.TextBoxFiltro.Size = new System.Drawing.Size(328, 20);
            this.TextBoxFiltro.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxFiltro);
            this.Controls.Add(this.ListViewItem);
            this.Controls.Add(this.ButtonConsultar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Aplicativo";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConsultar;
        private System.Windows.Forms.ListView ListViewItem;
        private System.Windows.Forms.TextBox TextBoxFiltro;
        private System.Windows.Forms.ColumnHeader Texto;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Data;
    }
}

