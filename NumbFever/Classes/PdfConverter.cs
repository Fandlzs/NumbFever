using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TextPDF;

namespace NumbFever.Classes
{
    public static class PdfConverter
    {
        public static void GeneratePdf(string path)
        {
            PdfWriter writer = new PdfWriter(842.0f, 1190.0f, 10.0f, 10.0f);
            writer.Write(path);
        }
        
        
        
    }
}
