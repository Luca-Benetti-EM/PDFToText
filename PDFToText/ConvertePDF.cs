using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFToText
{
    public class ConvertePDF
    {
        public string ExtrairTexto(string caminho)
        {
            using (PdfReader leitor = new PdfReader(caminho))
            {
                StringBuilder textoAgrupado = new StringBuilder();

                for (int i = 1; i <= leitor.NumberOfPages; i++)
                {
                    var textoPaginaBruta = PdfTextExtractor.GetTextFromPage(leitor, i);
                    
                    textoAgrupado.Append(textoPaginaBruta);
                }

                string tituloColunas = "QUADRO DE CURSOS DE FORMAÇÃO SUPERIOR\nCÓDIGO DE \nNOME DA ÁREA CÓGIGO DO CURSO NOME/GRAU\nÁREA";
                string fonte = "Fonte: Elaborado pela Deed/Inep com base no Cine Brasil 2018.";

                textoAgrupado = textoAgrupado.Replace(tituloColunas, string.Empty);
                textoAgrupado = textoAgrupado.Replace(fonte, string.Empty);

                return textoAgrupado.ToString();
            }
        }
    }

}