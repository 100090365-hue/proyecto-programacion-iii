using System;
using System.Collections.Generic;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Fonts;

namespace Diseño_Trabajo_final.Servicios
{
  public class FacturaItem
  {
    public string Codigo { get; set; } = "";
    public string Articulo { get; set; } = "";
    public int Cantidad { get; set; }
    public decimal MontoTotal { get; set; }
  }

  // Resolutor de fuentes para cargar fuentes del sistema Windows en PDFsharp
  public class FileFontResolver : IFontResolver
  {
    public string DefaultFontName => "Arial";

    public byte[] GetFont(string faceName)
    {
      string fontsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
      string fontPath = Path.Combine(fontsFolder, faceName);
      
      if (File.Exists(fontPath))
      {
        return File.ReadAllBytes(fontPath);
      }
      
      // Fallback a arial.ttf si no se encuentra la variante
      string defaultPath = Path.Combine(fontsFolder, "arial.ttf");
      if (File.Exists(defaultPath))
      {
        return File.ReadAllBytes(defaultPath);
      }
      
      return null;
    }

    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
      string faceName = "arial.ttf";

      if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
      {
        if (isBold && isItalic)
        {
          faceName = "arialbi.ttf";
        }
        else if (isBold)
        {
          faceName = "arialbd.ttf";
        }
        else if (isItalic)
        {
          faceName = "ariali.ttf";
        }
        else
        {
          faceName = "arial.ttf";
        }
      }
      
      return new FontResolverInfo(faceName);
    }
  }

  public class PdfReportService
  {
    static PdfReportService()
    {
      try
      {
        // Registrar el resolutor de fuentes de manera global
        GlobalFontSettings.FontResolver = new FileFontResolver();
      }
      catch
      {
        // Ya está registrado globalmente
      }
    }

    public void GenerarFacturaPdf(string destPath, string cliente, string evento, string metodoPago, string total, List<FacturaItem> items)
    {
      // Crear documento PDF
      PdfDocument document = new PdfDocument();
      document.Info.Title = "Factura de Evento - " + cliente;
      
      PdfPage page = document.AddPage();
      page.Size = PdfSharp.PageSize.Letter;
      XGraphics gfx = XGraphics.FromPdfPage(page);

      double pageWidth = page.Width.Point;
      double pageHeight = page.Height.Point;

      // Colores de diseño (Premium Palette)
      XColor colorPrimario = XColor.FromArgb(30, 41, 59);   // Slate Navy (#1E293B)
      XColor colorSecundario = XColor.FromArgb(14, 165, 233); // Light Blue Accent (#0EA5E9)
      XColor colorTextoDark = XColor.FromArgb(51, 65, 85);   // Dark Slate (#334155)
      XColor colorTextoLight = XColor.FromArgb(255, 255, 255);
      XColor colorFondoTabla = XColor.FromArgb(248, 250, 252); // Light Gray (#F8FAFC)
      XColor colorBorde = XColor.FromArgb(226, 232, 240);    // Light Gray Border (#E2E8F0)

      XBrush brushPrimario = new XSolidBrush(colorPrimario);
      XBrush brushSecundario = new XSolidBrush(colorSecundario);
      XBrush brushTextoDark = new XSolidBrush(colorTextoDark);
      XBrush brushTextoLight = new XSolidBrush(colorTextoLight);
      XBrush brushFondoTabla = new XSolidBrush(colorFondoTabla);
      
      XPen penBorde = new XPen(colorBorde, 1);
      XPen penLineaAccent = new XPen(colorSecundario, 2);

      // Fuentes
      XFont fontTitulo = new XFont("Arial", 22, XFontStyleEx.Bold);
      XFont fontSubtitulo = new XFont("Arial", 12, XFontStyleEx.Bold);
      XFont fontInfoLabel = new XFont("Arial", 10, XFontStyleEx.Bold);
      XFont fontInfoValue = new XFont("Arial", 10, XFontStyleEx.Regular);
      XFont fontCabeceraTabla = new XFont("Arial", 10, XFontStyleEx.Bold);
      XFont fontCuerpoTabla = new XFont("Arial", 9, XFontStyleEx.Regular);
      XFont fontTotal = new XFont("Arial", 12, XFontStyleEx.Bold);
      XFont fontFooter = new XFont("Arial", 8, XFontStyleEx.Italic);

      // 1. BANNER DE ENCABEZADO (Fondo azul oscuro con título)
      gfx.DrawRectangle(brushPrimario, 0, 0, pageWidth, 120);
      
      // Texto del Encabezado
      gfx.DrawString("FIESTAS & EVENTOS", fontTitulo, brushTextoLight, 40, 60);
      gfx.DrawString("FACTURA DE SERVICIOS", fontInfoLabel, brushTextoLight, 40, 85);

      // Recuadro de ID de Factura en el Encabezado
      gfx.DrawRectangle(brushSecundario, pageWidth - 220, 35, 180, 50);
      gfx.DrawString("FACTURA", fontInfoLabel, brushTextoLight, pageWidth - 210, 53);
      string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
      gfx.DrawString("Fecha: " + fechaActual, fontInfoValue, brushTextoLight, pageWidth - 210, 73);

      double y = 160;

      // 2. INFORMACIÓN DEL CLIENTE Y EVENTO (Dos columnas)
      gfx.DrawString("INFORMACIÓN DE FACTURACIÓN", fontSubtitulo, brushPrimario, 40, y);
      gfx.DrawLine(penLineaAccent, 40, y + 5, 230, y + 5);
      y += 25;

      // Columna Izquierda: Cliente
      gfx.DrawString("Cliente:", fontInfoLabel, brushTextoDark, 40, y);
      gfx.DrawString(cliente, fontInfoValue, brushTextoDark, 100, y);
      
      // Columna Derecha: Detalles del Evento
      gfx.DrawString("Evento:", fontInfoLabel, brushTextoDark, 340, y);
      gfx.DrawString(evento, fontInfoValue, brushTextoDark, 420, y);
      
      y += 18;

      // Pago
      gfx.DrawString("Método Pago:", fontInfoLabel, brushTextoDark, 40, y);
      gfx.DrawString(metodoPago, fontInfoValue, brushTextoDark, 120, y);

      gfx.DrawString("Estado:", fontInfoLabel, brushTextoDark, 340, y);
      gfx.DrawString("PAGADO", fontInfoLabel, brushSecundario, 420, y);

      y += 40;

      // 3. TABLA DE ARTÍCULOS
      // Dibujar cabeceras
      double tablaX = 40;
      double tablaW = pageWidth - 80;
      double colCantW = 70;
      double colTotalW = 100;
      double colArticuloW = tablaW - colCantW - colTotalW;

      // Fondo de la cabecera de la tabla
      gfx.DrawRectangle(brushPrimario, tablaX, y, tablaW, 25);
      
      // Texto de la cabecera
      gfx.DrawString("Articulo / Descripción", fontCabeceraTabla, brushTextoLight, tablaX + 10, y + 17);
      gfx.DrawString("Cantidad", fontCabeceraTabla, brushTextoLight, tablaX + colArticuloW + 10, y + 17);
      gfx.DrawString("Total", fontCabeceraTabla, brushTextoLight, tablaX + colArticuloW + colCantW + 10, y + 17);
      
      y += 25;

      // Filas de la tabla
      bool filaPar = false;
      foreach (var item in items)
      {
        // Fondo de fila alterno
        if (filaPar)
        {
          gfx.DrawRectangle(brushFondoTabla, tablaX, y, tablaW, 22);
        }
        
        // Bordes de fila
        gfx.DrawRectangle(penBorde, tablaX, y, tablaW, 22);

        // Datos
        gfx.DrawString(item.Articulo, fontCuerpoTabla, brushTextoDark, tablaX + 10, y + 15);
        gfx.DrawString(item.Cantidad.ToString(), fontCuerpoTabla, brushTextoDark, tablaX + colArticuloW + 10, y + 15);
        gfx.DrawString("$" + item.MontoTotal.ToString("N2"), fontCuerpoTabla, brushTextoDark, tablaX + colArticuloW + colCantW + 10, y + 15);

        y += 22;
        filaPar = !filaPar;
      }

      y += 15;

      // 4. TOTAL GENERAL
      double totalBoxX = pageWidth - 240;
      gfx.DrawRectangle(brushPrimario, totalBoxX, y, 200, 35);
      gfx.DrawString("TOTAL A PAGAR:", fontInfoLabel, brushTextoLight, totalBoxX + 15, y + 22);
      gfx.DrawString("$" + total, fontTotal, brushTextoLight, totalBoxX + 110, y + 22);

      // 5. PIE DE PÁGINA (Footer)
      double footerY = pageHeight - 60;
      gfx.DrawLine(penBorde, 40, footerY, pageWidth - 40, footerY);
      gfx.DrawString("Gracias por confiar en Fiestas & Eventos para la planificación de su día especial.", fontFooter, brushTextoDark, 40, footerY + 15);
      gfx.DrawString("Para cualquier duda o aclaración, contáctenos en soporte@fiestaseventos.com", fontFooter, brushTextoDark, 40, footerY + 28);

      // Guardar archivo PDF
      document.Save(destPath);
    }
  }
}
