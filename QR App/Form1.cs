using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QR_App
{
    public partial class QRApp : Form
    {
        public QRApp()
        {
            InitializeComponent();
        }

        // Convert Text To BarCode After Clicking the BarCode Button
        private void buttonBarCode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBoxBar.Image = barcode.Draw(textBarCode.Text, 50);
            MessageLabel.Text = "Done";
        }
        // Convert Text To BarCode After Clicking the BarCode Button Ends

        // Convert Text To QRCode After Clicking the QRCode Button
        private void buttonQRCode_Click_1(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;

            pictureBoxQR.Image = qrcode.Draw(textQRCode.Text, 50);
            MessageLabelQr.Text = "Done";

        }
        // Convert Text To QRCode After Clicking the QRCode Button Ends 

        // Let the system print the image you want (BAR, QR Code)

        private void buttonPrintQR_Click_1(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBoxQR.Width, pictureBoxQR.Height);
            pictureBoxQR.DrawToBitmap(bm, new Rectangle(0, 0, pictureBoxQR.Width, pictureBoxQR.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void buttonPrintBar_Click(object sender, EventArgs e)
        {
            PrintDialog pd2 = new PrintDialog();
            PrintDocument doc2 = new PrintDocument();
            doc2.PrintPage += Doc2_PrintPage;
            pd2.Document = doc2;
            if (pd2.ShowDialog() == DialogResult.OK)
                doc2.Print();
        }

        private void Doc2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBoxBar.Width, pictureBoxBar.Height);
            pictureBoxBar.DrawToBitmap(bm, new Rectangle(0, 0, pictureBoxBar.Width, pictureBoxBar.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
        // Let the system print the image you want (BAR, QR Code) Ends
       
        // Link for مشلاثم مهىن 

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.researchers-pal.com");
        }
    }

}
