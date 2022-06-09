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
using ZXing.QrCode;
using iTextSharp.text.pdf.parser;

namespace QrCode
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateQr_Click(object sender, EventArgs e)
        {

            string qrData = tbxQrImageData.Text;
            //string qrImageFileName = tbxQrImageFileName.Text;
            Console.WriteLine($"input link{qrData}");
            BarcodeWriter barcodeW = new BarcodeWriter();

            barcodeW.Format = BarcodeFormat.QR_CODE;
            barcodeW.Options = new QrCodeEncodingOptions { Width = 200, Height = 200, PureBarcode = true, Margin = 0 };

            string qrPath = @"C:\qr\qr_code.png";
            barcodeW.Write(qrData).Save(qrPath);

            pbxQrImage.Image = barcodeW.Write(qrData);
            //  Image.FromFile(@"C:\qr\" + qrImageFileName + ".png");

            //string filePath = @"C:\Users\gabriel.gomes\Downloads\teste\aprov_qr_1.pdf";
            //string filePath = inputPath.Text;
            //string fileResult = @"C:\\Users\\gabriel.gomes\\Downloads\\teste\\qrresult.pdf";
            //iTextSharp.text.Image qr = iTextSharp.text.Image.GetInstance(qrPath);











        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
