using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.Text.RegularExpressions;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf.parser;
using System.IO.Compression;
using ZXing.QrCode;

namespace QrCode
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void CreateZipFile(string ZipedFileFolder, string SourceFolder)//STATUS: NO-USE           // Refatorar de acordo com a implementação
        {
            // Create and open a new ZIP file
            string zipFileName = string.Format("zipfile-{0:yyyy-MM-dd_hh-mm-ss-tt}.zip", DateTime.Now);
            string zipFilepath = System.IO.Path.Combine(ZipedFileFolder, zipFileName);
            var zip = ZipFile.Open(zipFilepath, ZipArchiveMode.Create);
            string[] filesToZip = Directory.GetFiles(SourceFolder, "*.pdf", SearchOption.AllDirectories);
            foreach (var file in filesToZip)
            {
                // Add the entry for each file
                zip.CreateEntryFromFile(file, System.IO.Path.GetFileName(file), CompressionLevel.Optimal);
            }
            // Dispose of the object when we are done
            zip.Dispose();
        }
        public static void MergePdfFiles(string SourcePdfPath, string outputPath)//STATUS: NO-USE           // Refatorar de acordo com a implementação
        {
            // Methodo merge
            string[] filenames = Directory.GetFiles(SourcePdfPath);
            string outputFileName = "Merge.pdf";
            outputPath = outputPath + outputFileName;
            try
            {

                Document doc = new Document();
                PdfCopy writer = new PdfCopy(doc, new FileStream(outputPath, FileMode.Create));

                if (writer == null)
                {
                    return;
                }
                doc.Open();
                foreach (string filename in filenames)
                {
                    PdfReader reader = new PdfReader(filename);
                    reader.ConsolidateNamedDestinations();
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        PdfImportedPage page = writer.GetImportedPage(reader, i);
                        writer.AddPage(page);
                    }
                    reader.Close();
                }

                writer.Close();
                doc.Close();


            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("exceção");
                FileAttributes attributes = File.GetAttributes(outputPath);
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    Console.WriteLine("entrou");
                    Console.WriteLine(attributes.ToString());
                    attributes &= ~FileAttributes.ReadOnly;
                    File.SetAttributes(outputPath, attributes);
                    //File.Delete(outputPath);
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                Console.WriteLine("Fim do processo");
            }
        }
        public static void addQrCode(byte[] file, string qrPath, string fileResult) //STATUS: Using          
        {
            //Usado para abrir com o path do arquivo
            //using (var inputPdfStream = new FileStream(file, FileMode.Open))
            using (var inputImageStream = new FileStream(qrPath, FileMode.Open))
            using (var outputPdfStream = new FileStream(fileResult, FileMode.Create))
            {

                PdfReader reader = new PdfReader(file);  //usando o path a variavel do inputPdfStream vem aqui
                PdfStamper stamper = new PdfStamper(reader, outputPdfStream);
                PdfContentByte pdfContentByte = stamper.GetOverContent(1);
                var image = iTextSharp.text.Image.GetInstance(inputImageStream);

                try
                {
                    var parser = new PdfReaderContentParser(reader);
                    var strategy = parser.ProcessContent(1, new LocationTextExtractionStrategyWithPosition());

                    var res = strategy.GetLocations();

                    Console.WriteLine(res.ToArray().Length);
                    for (int i = 0; i < res.ToArray().Length; i++)
                    {

                        if (res[i].Text.Equals("__QRCODE__"))
                        {
                            Console.WriteLine($"local para adicionar QR encontrado! \t");
                            image.SetAbsolutePosition((res[i].X-10), (res[i].Y - 30));
                            image.ScaleToFit(70, 70);
                            pdfContentByte.AddImage(image);
                            break;
                        }
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    stamper.Close();
                    Console.WriteLine("Fim do processo");
                }
            }
        }
        private static byte[] ImageToByte(Bitmap img)//STATUS: NO-USE           // Refatorar de acordo com a implementação
        {
            using var stream = new MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }


        private static void routineZip(string pathZip)//STATUS: Using    
        {
            using (FileStream fs = new FileStream(pathZip, FileMode.Open))
            using (ZipArchive zip = new ZipArchive(fs))
            {
                var entry = zip.Entries.First();
                Console.WriteLine(zip.Entries.ToList());

                foreach (var file in zip.Entries.ToList())
                {
                    var stream = file.Open();
                    byte[] fileBytes;
                    using (var ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        fileBytes = ms.ToArray();

                        addQrCode(fileBytes, "C:\\qr\\qr_code.png", $"C:\\pdf\\zip\\out\\{file.Name}.pdf"); // array de byte do file dentro do zip, qrCodePath, path para salvar.

                    }    
                }
            }
        }

        static void Main()
        {
            routineZip(@"C:/pdf/zip/files.zip");

  

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
