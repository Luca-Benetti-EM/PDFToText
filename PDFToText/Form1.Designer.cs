namespace PDFToText
{
    partial class PDFToText
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
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtConvertido = new System.Windows.Forms.RichTextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(65, 74);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(502, 20);
            this.txtCaminho.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(606, 72);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(687, 72);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtConvertido
            // 
            this.txtConvertido.Location = new System.Drawing.Point(65, 161);
            this.txtConvertido.Name = "txtConvertido";
            this.txtConvertido.Size = new System.Drawing.Size(562, 168);
            this.txtConvertido.TabIndex = 3;
            this.txtConvertido.Text = "";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(687, 231);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // PDFToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtConvertido);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtCaminho);
            this.Name = "PDFToText";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtConvertido;
        private System.Windows.Forms.Button btnGerar;
    }
}

