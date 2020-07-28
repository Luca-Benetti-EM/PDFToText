using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFToText
{
    public partial class PDFToText : Form
    {
        public PDFToText()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Selecionar PDF";
            openFileDialog1.InitialDirectory = @"C:\dados";
            //filtra para exibir somente arquivos de imagens
            openFileDialog1.Filter = "Files (*.PDF)|*.PDF|" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = false;

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtCaminho.Text = openFileDialog1.FileName;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertePDF conversor = new ConvertePDF();
                string clean = conversor.ExtrairTexto(txtCaminho.Text);
                string retira = "QUADRO DE CURSOS DE FORMAÇÃO SUPERIOR\nCÓDIGO DE \nNOME DA ÁREA CÓGIGO DO CURSO NOME/GRAU\nÁREA";
                clean = clean.Replace(retira, string.Empty);
                txtConvertido.Text = clean;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var sql = $"--#start\nALTER TABLE TBCURSODEFORMACAOSUPERIOR ALTER COLUMN CURSOCHAVE TYPE CHAR(8)\n--#end\n";

            var linhas = Regex.Split(txtConvertido.Text, "\r\n|\r|\n").ToList();

            foreach(var linha in linhas)
            {
                var codigo = linha.Substring(0, 8);
                var descricao = linha.Substring(9, linha.Length - 9);
                sql += $"--#start\nDELETE FROM TBCURSODEFORMACAOSUPERIOR WHERE CURSOCHAVE = '{codigo}' OR CURSODESCRICAO = '{descricao.ToUpper()}'\n--#end\n";
            }

            int id = 1456;
            foreach (var linha in linhas)
            {
                var codigo = linha.Substring(0, 8);
                var descricao = linha.Substring(9, linha.Length - 9);

                sql += $"--#start\nINSERT INTO TBCURSODEFORMACAOSUPERIOR(CURSOID, CURSOCHAVE, CURSODESCRICAO) VALUES('{id}', '{codigo}', '{descricao.ToUpper()}')\n--#end\n";

                id++;
            }

            //CONVERTE PARA UTF8

            var charsetPadrao = Encoding.Default;
            var bytesPadrao = charsetPadrao.GetBytes(sql);
            var utf8 = Encoding.UTF8;
            var bytesUtf8 = Encoding.Convert(charsetPadrao, utf8, bytesPadrao);
            sql = utf8.GetString(bytesUtf8);

            System.IO.File.WriteAllText(@"CAMINHO\insercao.sql", sql, Encoding.UTF8);
        }
    }
}
