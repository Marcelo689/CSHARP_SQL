namespace Dividas
{
    partial class TelaInserir
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 99);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 20);
            this.textBox3.TabIndex = 2;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(54, 51);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(34, 13);
            this.texto.TabIndex = 3;
            this.texto.Text = "Texto";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(54, 196);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(31, 13);
            this.valor.TabIndex = 4;
            this.valor.Text = "Valor";
            this.valor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.valor.Click += new System.EventHandler(this.label2_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(54, 247);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(30, 13);
            this.data.TabIndex = 5;
            this.data.Text = "Data";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(173, 326);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // TelaInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.data);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "TelaInserir";
            this.Text = "TelaInserir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Button btnInserir;
    }
}