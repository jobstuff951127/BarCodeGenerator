using _808.Model;
using Guna.UI.WinForms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfiumViewer;
using PdfSharp.Drawing;
using PdfSharp.Drawing.BarCodes;
using PdfSharp.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace _808.ViewModel
{
    public class Viewer
    {
        #region Constantes
        const string filename = @"C:\temp\Etiquetas.pdf"; //Donde se creara el pdf 
        const string path = @"C:\temp\generated.png";  //Donde se crearan los codigos de barras
        #endregion

        #region Atributos
        //Eje en Y de la hojas del pdf en donde se insertaran los codigos de barras
        static double CoordinateY { get; set; }
        //Eje en X de la hojas del pdf en donde se insertaran los codigos de barras
        static double CoordinateX { get; set; }
        //Eje en X de la hojas del pdf en donde se insertará el texto de familias
        static double CoordFamX { get; set; }
        //Eje en Y de la hojas del pdf en donde se insertará el texto de familias
        static double CoordFamY { get; set; }
        
        //Eje en X de la hojas del pdf en donde se insertará el texto de Codigo
        static double CoordCodeX { get; set; }
        
        //Eje en Y de la hojas del pdf en donde se insertará el texto de familias
        static double CoordCodeY { get; set; }

        //Eje en X de la hojas del pdf en donde se insertará el texto de Linea
        static double CoordLineX { get; set; }

        //Eje en Y de la hojas del pdf en donde se insertará el texto de Linea
        static double CoordLineY { get; set; }

        //Counter mantiene el conteo de cada codigo de barras que ya fue procesado
        static int Counter { get; set; }

        //Counter mantiene el conteo de cada tres codigos de barras para insertar en la siguiente linea los nuevos codigos
        static int CounterEachThree { get; set; }

        //Counter mantiene el conteo de cada catorce codigos de barras para insertar en la siguiente hoja los nuevos codigos
        static int CounterEach14 { get; set; }
        #endregion

        public static async Task CreatePdf(List<Article> lstArt, PdfViewer pdfViewer, GunaLabel label, GunaWinCircleProgressIndicator loader)
        {
            await Task.Run(() =>
            {
                
                pdfViewer.Invoke(new MethodInvoker(delegate
                {
                    pdfViewer.Hide();
                }));
                loader.Invoke(new MethodInvoker(delegate
                {
                    loader.Show();
                }));
                try
                {
                    PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
                    document.Info.Title = "Etiquetas";
                    List<PdfPage> lstPages = new List<PdfPage>();
                    XFont fontBold = new XFont("Times New Roman", 7, XFontStyle.Bold);

                    CoordinateX = 20;
                    CoordinateY = 80;

                    CoordFamX = 25;
                    CoordFamY = 40;

                    CoordLineX = 25;
                    CoordLineY = 55;

                    CoordCodeX = 25;
                    CoordCodeY = 70;

                    Counter = 0;
                    CounterEachThree = 0;
                    CounterEach14 = 0;

                    label.Invoke(new MethodInvoker(delegate
                    {
                        label.BringToFront();
                        label.Text = "1 Página(s).";

                    }));

                    //This one works like a charm, lstArt.Where(c => c.Artículo.Contains("Ñ")).ToList().ForEach(d => d.Artículo = d.Artículo.Replace("Ñ", "N"));

                    //Valida si se marco algun checkbox
                    var printableCodes = lstArt.Where(c => c.Checked).ToList();
                    if (printableCodes.Count > 0)
                    {
                        var casiTotalHojas = printableCodes.Count / 15; //Calcula el total de hojas a generar menos 1
                        //Valida si se necesitara mas de una hoja
                        if (casiTotalHojas > 1)
                        {
                            //Crea hojas en funcion a la variable "casiTotalHojas" y las carga en una lista de hojas
                            for (int i = 0; i <= casiTotalHojas; i++)
                            {
                                lstPages.Add(new PdfPage());
                            }
                            label.Invoke(new MethodInvoker(delegate
                            {
                                label.Text = lstPages.Count().ToString() + " " + "Página(s).";
                            }));
                            //Por cada hoja realiza el proceso de carga de los codigos de barras junto con su texto correpondiente
                            foreach (var page in lstPages)
                            {
                                document.AddPage(page);
                                var lienzo = XGraphics.FromPdfPage(page);

                                for (int i = Counter; i < printableCodes.Count; i++)
                                {

                                    var barcodeWriter = new BarcodeWriter
                                    {
                                        Format = BarcodeFormat.CODE_128
                                    };

                                    var img = new Bitmap(barcodeWriter.Write(printableCodes[Counter].Artículo), 1200, 100);
                                    img.Save(path);

                                    byte[] imgBytes = File.ReadAllBytes(path);
                                    var streamSavedImg = new MemoryStream(imgBytes);
                                    XImage xPhoto = XImage.FromStream(streamSavedImg);

                                    if (CounterEachThree == 3)
                                    {
                                        CoordinateY += 150;
                                        CoordinateX = 20;
                                        CounterEachThree = 0;

                                        CoordFamX = 25;
                                        CoordFamY += 150;

                                        CoordLineX = 25;
                                        CoordLineY += 150;

                                        CoordCodeX = 25;
                                        CoordCodeY += 150;
                                    }

                                    lienzo.DrawImage(xPhoto, CoordinateX, CoordinateY, 150, 80);
                                    lienzo.DrawString("FAMILIA: " + printableCodes[Counter].Familia, fontBold, XBrushes.Black, CoordFamX, CoordFamY);
                                    lienzo.DrawString("ARTÍCULO: " + printableCodes[Counter].Cuenta, fontBold, XBrushes.Black, CoordCodeX, CoordCodeY);
                                    lienzo.DrawString("LÍNEA: " + printableCodes[Counter].Linea, fontBold, XBrushes.Black, CoordLineX, CoordLineY);

                                    CoordinateX += 200;
                                    CoordFamX += 200;
                                    CoordLineX += 200;
                                    CoordCodeX += 200;


                                    if (CounterEach14 == 14)
                                    {
                                        CoordinateX = 20;
                                        CoordinateY = 80;

                                        CoordFamX = 25;
                                        CoordFamY = 40;

                                        CoordLineX = 25;
                                        CoordLineY = 55;

                                        CoordCodeX = 25;
                                        CoordCodeY = 70;

                                        Counter++;
                                        CounterEachThree = 0;
                                        CounterEach14 = 0;
                                        break;
                                    }
                                    Counter++;
                                    CounterEachThree++;
                                    CounterEach14++;

                                }
                            }
                        }
                        else
                        {

                            PdfPage page = document.AddPage();
                            XGraphics gfx = XGraphics.FromPdfPage(page);

                            foreach (var item in printableCodes)
                            {
                                var barcodeWriter = new BarcodeWriter
                                {
                                    Format = BarcodeFormat.CODE_128
                                };

                                var img = new Bitmap(barcodeWriter.Write(item.Artículo), 1200, 100);
                                img.Save(path);

                                byte[] imgBytes = File.ReadAllBytes(path);
                                var streamSavedImg = new MemoryStream(imgBytes);
                                XImage xPhoto = XImage.FromStream(streamSavedImg);

                                if (Counter % 3 == 0 && Counter != 0)
                                {
                                    CoordinateY += 150;
                                    CoordinateX = 20;

                                    CoordFamX = 25;
                                    CoordFamY += 150;

                                    CoordLineX = 25;
                                    CoordLineY += 150;

                                    CoordCodeX = 25;
                                    CoordCodeY += 150;

                                }

                                gfx.DrawString("FAMILIA: " + item.Familia, fontBold, XBrushes.Black, CoordFamX, CoordFamY);
                                gfx.DrawString("ARTÍCULO: " + item.Cuenta, fontBold, XBrushes.Black, CoordCodeX, CoordCodeY);
                                gfx.DrawString("LÍNEA: " + item.Linea, fontBold, XBrushes.Black, CoordLineX, CoordLineY);
                                gfx.DrawImage(xPhoto, CoordinateX, CoordinateY, 150, 80);
                                CoordinateX += 200;
                                CoordFamX += 200;
                                CoordLineX += 200;
                                CoordCodeX += 200;
                                Counter++;

                            }

                        }
                    }
                    else
                    {
                        var casiTotalHojas = lstArt.Count / 15;

                        if (casiTotalHojas > 1)
                        {
                            for (int i = 0; i <= casiTotalHojas; i++)
                            {
                                lstPages.Add(new PdfPage());
                            }
                            label.Invoke(new MethodInvoker(delegate
                            {
                                label.Text = lstPages.Count().ToString() + " " + "Página(s).";
                            }));

                            foreach (var page in lstPages)
                            {
                                document.AddPage(page);
                                var lienzo = XGraphics.FromPdfPage(page);

                                for (int i = Counter; i < lstArt.Count; i++)
                                {
                                    var barcodeWriter = new BarcodeWriter
                                    {
                                        Format = BarcodeFormat.CODE_128,

                                    };

                                    var img = new Bitmap(barcodeWriter.Write(lstArt[Counter].Artículo), 1200, 100);
                                    img.Save(path);

                                    byte[] imgBytes = File.ReadAllBytes(path);
                                    var streamSavedImg = new MemoryStream(imgBytes);
                                    XImage xPhoto = XImage.FromStream(streamSavedImg);

                                    if (CounterEachThree == 3)
                                    {
                                        CoordinateY += 150;
                                        CoordinateX = 20;
                                        CounterEachThree = 0;

                                        CoordFamX = 25;
                                        CoordFamY += 150;

                                        CoordLineX = 25;
                                        CoordLineY += 150;

                                        CoordCodeX = 25;
                                        CoordCodeY += 150;
                                    }

                                    lienzo.DrawString("FAMILIA: " + lstArt[Counter].Familia, fontBold, XBrushes.Black, CoordFamX, CoordFamY);
                                    lienzo.DrawString("ARTÍCULO: " + lstArt[Counter].Cuenta, fontBold, XBrushes.Black, CoordCodeX, CoordCodeY);
                                    lienzo.DrawString("LÍNEA: " + lstArt[Counter].Linea, fontBold, XBrushes.Black, CoordLineX, CoordLineY);
                                    lienzo.DrawImage(xPhoto, CoordinateX, CoordinateY, 150, 80);

                                    CoordinateX += 200;
                                    CoordFamX += 200;
                                    CoordLineX += 200;
                                    CoordCodeX += 200;

                                    if (CounterEach14 == 14)
                                    {

                                        CoordinateX = 20;
                                        CoordinateY = 80;

                                        CoordFamX = 25;
                                        CoordFamY = 40;

                                        CoordLineX = 25;
                                        CoordLineY = 55;

                                        CoordCodeX = 25;
                                        CoordCodeY = 70;

                                        Counter++;
                                        CounterEachThree = 0;
                                        CounterEach14 = 0;
                                        break;
                                    }
                                    Counter++;
                                    CounterEachThree++;
                                    CounterEach14++;

                                }
                            }
                        }
                        else
                        {

                            PdfPage page = document.AddPage();
                            XGraphics gfx = XGraphics.FromPdfPage(page);

                            foreach (var item in lstArt)
                            {
                                var barcodeWriter = new BarcodeWriter
                                {
                                    Format = BarcodeFormat.CODE_128
                                };

                                var img = new Bitmap(barcodeWriter.Write(item.Artículo), 1200, 100);
                                img.Save(path);

                                byte[] imgBytes = File.ReadAllBytes(path);
                                var streamSavedImg = new MemoryStream(imgBytes);
                                XImage xPhoto = XImage.FromStream(streamSavedImg);

                                if (Counter % 3 == 0 && Counter != 0)
                                {
                                    CoordinateY += 150;
                                    CoordinateX = 20;

                                    CoordFamX = 25;
                                    CoordFamY += 150;

                                    CoordLineX = 25;
                                    CoordLineY += 150;

                                    CoordCodeX = 25;
                                    CoordCodeY += 150;
                                }

                                gfx.DrawString("FAMILIA: " + item.Familia, fontBold, XBrushes.Black, CoordFamX, CoordFamY);
                                gfx.DrawString("ARTÍCULO: " + item.Cuenta, fontBold, XBrushes.Black, CoordCodeX, CoordCodeY);
                                gfx.DrawString("LÍNEA: " + item.Linea, fontBold, XBrushes.Black, CoordLineX, CoordLineY);
                                gfx.DrawImage(xPhoto, CoordinateX, CoordinateY, 150, 80);
                                CoordinateX += 200;
                                CoordFamX += 200;
                                CoordLineX += 200;
                                CoordCodeX += 200;
                                Counter++;

                            }

                        }
                    }

                    document.Save(filename);
                    byte[] bytes = File.ReadAllBytes(filename);
                    var stream = new MemoryStream(bytes);
                    var pdfDocument = PdfiumViewer.PdfDocument.Load(stream);
                    loader.Invoke(new MethodInvoker(delegate
                    {
                        loader.Hide();
                    }));
                    pdfViewer.Invoke(new MethodInvoker(delegate
                    {
                        pdfViewer.Show();
                    }));
                    pdfViewer.Invoke(new MethodInvoker(delegate
                    {
                        pdfViewer.Document = pdfDocument;
                    }));
                }
                catch (Exception ex)
                {
                    loader.Invoke(new MethodInvoker(delegate
                    {
                        loader.Hide();
                    }));
                    MessageBox.Show(ex.ToString(), "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

        }
    }
}
