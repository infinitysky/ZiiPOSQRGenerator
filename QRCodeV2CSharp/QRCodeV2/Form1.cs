

using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QRCodeV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                OutputBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            
            if (string.IsNullOrEmpty(branchIDBox.Text))
            {
                // Do something...
                string message = "Branch ID box cannot be empty!!";
                MessageBox.Show(message);

            }
            else if (string.IsNullOrEmpty(OutputBox.Text))
            {
                // Do something...
                string message = "Output box cannot be empty!!";
                MessageBox.Show(message);

            }
            else if (string.IsNullOrEmpty(tableQRcodelist.Text))
            {
                // Do something...
                string message = "Please enter table number";
                MessageBox.Show(message);

            }
            else
            {
               // MessageBox.Show("start");
                TableQRcodeGenerate();
            }
        }


        public void TableQRcodeGenerate()
        {
            string tableQRURLFormat = "https://app.ziicloud.com/store/e/" + branchIDBox.Text + "?tableNo=";
            tableQRcodelist.Lines = tableQRcodelist.Lines.Where(line => line.Trim() != string.Empty).ToArray();

            string[] tableNumber = tableQRcodelist.Lines;
            
            var folderPath = OutputBox.Text;
            string path = @folderPath;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            int i = 0;
            for (i = 0; i <= tableNumber.GetUpperBound(0); i++)
            {
                if (string.IsNullOrEmpty(tableNumber[i]))
                {
                    i++;
                }
                else
                {
                    string filePathpng = OutputBox.Text + "\\Table_" + tableNumber[i] + ".png";
                    string QRString = tableQRURLFormat + tableNumber[i];

                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRString, QRCodeGenerator.ECCLevel.M);
                    //QRCode qrCode = new QRCode(qrCodeData);
                    //Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
                    byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);

                    //e.g. Windows 10 - Full .NET Framework
                    Bitmap qrCodeImage;
                    using (var ms = new MemoryStream(qrCodeAsPngByteArr))
                    {
                        qrCodeImage = new Bitmap(ms);
                    }
                    qrCodeImage.Save(filePathpng);

                }
                       
            }
            MessageBox.Show("Create QR code complete");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                OnlineOrderPathBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(OnlineOrderBranchBox.Text))
            {
                // Do something...
                string message = "Online Order Branch ID box cannot be empty!!";
                MessageBox.Show(message);

            }
            else if (string.IsNullOrEmpty(OnlineOrderPathBox.Text))
            {
                // Do something...
                string message = "Online Order Path box cannot be empty!!";
                MessageBox.Show(message);

            }
            else
            {
                // MessageBox.Show("start");
                OnlineQRcodeGenerate();
            }
        }

        public void OnlineQRcodeGenerate()
        {
            string OnlineQRURLFormat = "https://app.ziicloud.com/store/view/";
            var folderPath = OnlineOrderPathBox.Text;
            string path = @folderPath;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }    
            string filePathpng = OnlineOrderPathBox.Text + "\\OnlineOrder_" + OnlineOrderBranchBox.Text + ".png";
            string QRString = OnlineQRURLFormat + OnlineOrderBranchBox.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRString, QRCodeGenerator.ECCLevel.M);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);

            //e.g. Windows 10 - Full .NET Framework
            Bitmap qrCodeImage;
            using (var ms = new MemoryStream(qrCodeAsPngByteArr))
            {
                 qrCodeImage = new Bitmap(ms);
            }
            qrCodeImage.Save(filePathpng);
                      
            MessageBox.Show("Create Online Order QR code complete");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                QRCodePathBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(QRCodeList.Text))
            {
                // Do something...
                string message = "QRCode input box cannot be empty!!";
                MessageBox.Show(message);

            }
            else if (string.IsNullOrEmpty(QRCodePathBox.Text))
            {
                // Do something...
                string message = "QR Code Path box cannot be empty!!";
                MessageBox.Show(message);

            }
            else
            {
                // MessageBox.Show("start");
                QRcodeListGenerate();
            }
        }

        public void QRcodeListGenerate()
        {

            QRCodeList.Lines = QRCodeList.Lines.Where(line => line.Trim() != string.Empty).ToArray();

            string[] QRCodeList_ = QRCodeList.Lines;

            var folderPath = QRCodePathBox.Text;
            string path = @folderPath;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
           

            int i = 0;
            for (i = 0; i <= QRCodeList_.GetUpperBound(0); i++)
            {
                if (string.IsNullOrEmpty(QRCodeList_[i]))
                {
                    i++;
                }
                else
                {
                    string tempString = String.Concat(QRCodeList_[i].Where(c => !Char.IsWhiteSpace(c)));
                    string tempfileName = "";
                    string fileName = "";
                    tempfileName = removeSpecialChars(tempString);

                    if (tempfileName.Length > 8)
                    {
                        fileName = tempfileName.Substring(0, 8);
                    }
                    else
                    {
                        fileName = tempfileName;
                    }
                    
                    string filePathpng = QRCodePathBox.Text + "\\QR_" + i+"_" + fileName + "_.png";
                    string QRString = QRCodeList_[i];

                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRString, QRCodeGenerator.ECCLevel.M);
                    //QRCode qrCode = new QRCode(qrCodeData);
                    //Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
                    byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);

                    //e.g. Windows 10 - Full .NET Framework
                    Bitmap qrCodeImage;
                    using (var ms = new MemoryStream(qrCodeAsPngByteArr))
                    {
                        qrCodeImage = new Bitmap(ms);
                    }
                    qrCodeImage.Save(filePathpng);

                }

            }
            MessageBox.Show("Create QR code complete");

        }

        public static string removeSpecialChars(string text)
        {
            return Regex.Replace(text, @"[^\w \-]", "");
        }



    }
}

