namespace Dividas
{
    partial class TelaConsulta
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
            this.listViewDeItems = new System.Windows.Forms.ListView();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.Texto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewDeItems
            // 
            this.listViewDeItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Texto,
            this.Valor,
            this.Data});
            this.listViewDeItems.HideSelection = false;
            this.listViewDeItems.Location = new System.Drawing.Point(21, 46);
            this.listViewDeItems.Name = "listViewDeItems";
            this.listViewDeItems.Size = new System.Drawing.Size(300, 352);
            this.listViewDeItems.TabIndex = 1;
            this.listViewDeItems.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(456, 46);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(265, 20);
            this.textBoxFiltro.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(504, 104);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.listViewDeItems);
            this.Name = "TelaConsulta";
            this.Text = "TelaConsulta";
            this.Load += new System.EventHandler(this.TelaConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDeItems;
        private System.Windows.Forms.ColumnHeader Texto;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button btnFiltrar;
    }
}