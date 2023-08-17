using System;
using System.IO;
using iText.IO.Image;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Org.BouncyCastle;

namespace SIGT___PCM.Relatorio
{
    class relatorioOS
    {
        public void GerarRelatorioPDF()
        {
            Random radn = new Random();
            int numb = radn.Next();
            DateTime dateTime = DateTime.Now;

            string outputFile = @"C:\TempGSG\Ordem de Serviço Nº "+ numb + " de "+ dateTime.ToString("G").Replace("/","-").Replace(":",".") +".pdf";
            PageSize pageSize = PageSize.A4;
            // Criar um novo documento PDF
            using (PdfWriter writer = new PdfWriter(outputFile))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document doc = new Document(pdf))
            {
                // Definir cabeçalho
                Image img1 = new Image(ImageDataFactory.Create(@"C:\logo\usga.png"))
                    .SetFixedPosition(35, 750) // Mover para a posição desejada (x, y)
                    .SetWidth(50)
                    .SetHeight(50);
                doc.Add(img1);
                
                Image img2 = new Image(ImageDataFactory.Create(@"C:\logo\DNV-GL-Certification-logo.png"))
                    .SetFixedPosition(418, 750) // Mover para a posição desejada (x, y)
                    .SetWidth(50)
                    .SetHeight(50);
                doc.Add(img2);
                
                Image img3 = new Image(ImageDataFactory.Create(@"C:\logo\Logomarca_Bonsucro_2016.png"))
                    .SetFixedPosition(465, 737) // Mover para a posição desejada (x, y)
                    .SetWidth(70)
                    .SetHeight(70);
                doc.Add(img3);
                
                Image img4 = new Image(ImageDataFactory.Create(@"C:\logo\renovabio.png"))
                    .SetFixedPosition(537, 750) // Mover para a posição desejada (x, y)
                    .SetWidth(50)
                    .SetHeight(50);
                doc.Add(img4);
                
                Paragraph paragraph1 = new Paragraph("USINA SERRA GRANDE S/A")
                    .SetFont(PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD))
                    .SetFixedPosition(110, 775,900) // Mover para a posição desejada (x, y)
                    .SetFontSize(20);
                doc.Add(paragraph1);
                
                Paragraph paragraph2 = new Paragraph("AÇÚCAR, ÁLCOOL & ENERGIA")
                    .SetFont(PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_OBLIQUE))
                    .SetFixedPosition(110, 762, 900) // Mover para a posição desejada (x, y)
                    .SetFontSize(15);
                doc.Add(paragraph2);
                
                Paragraph paragraph3 = new Paragraph("ORDEM DE SERVIÇO")
                    .SetFont(PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA))
                    .SetFixedPosition(110, 748, 1000) // Mover para a posição desejada (x, y)
                    .SetFontSize(13);
                doc.Add(paragraph3);
                

                // Criar uma tabela
                Table table = new Table(3); // 3 colunas
                table.SetWidth(UnitValue.CreatePercentValue(100)); // Largura da tabela

                // Adicionar células à tabela
                table.AddCell(new Cell().Add(new Paragraph("Coluna 1")));
                table.AddCell(new Cell().Add(new Paragraph("Coluna 2")));
                table.AddCell(new Cell().Add(new Paragraph("Coluna 3")));

                // Definir a posição da tabela
                float xPosition = 50; // Posição horizontal em pontos
                float yPosition = doc.GetPageEffectiveArea(pageSize).GetHeight() - 100; // Posição vertical em pontos
                table.SetFixedPosition(xPosition, yPosition, pageSize.GetWidth() - xPosition * 2);

                // Adicionar a tabela ao documento
                doc.Add(table);
            }
        }
    }
}
