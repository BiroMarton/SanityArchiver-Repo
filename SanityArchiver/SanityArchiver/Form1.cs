using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class Form1 : Form
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        public Form1()
        {
            InitializeComponent();

            foreach (DriveInfo drive in allDrives)
            {
                LeftBox.Items.Add(drive.Name + "," + drive.DriveType);
                RightBox.Items.Add(drive.Name + "," + drive.DriveType);
            }


        }

        private void LeftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] info = LeftBox.SelectedItem.ToString().Split(',');
            String root = info[0];

            LeftBrowser.Url = new Uri(@root);
        }

        private void RightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] info = RightBox.SelectedItem.ToString().Split(',');
            String root = info[0];

            RightBrowser.Url = new Uri(@root);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeftBrowser.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RightBrowser.GoBack();
        }

        static void ArchiveFile(DirectoryInfo archiveDir, FileInfo fileToArchive)
        {
            FileStream input = fileToArchive.OpenRead();
            FileStream output = File.Create(archiveDir.FullName + @"\" + fileToArchive.Name + ".gz");
            GZipStream Compressor = new GZipStream(output, CompressionMode.Compress);
            int b = input.ReadByte();
            while (b != -1)
            {
                Compressor.WriteByte((byte)b);

                b = input.ReadByte();
            }
            Compressor.Close();
            input.Close();
            output.Close();
        }

        private void CompressLeft_Click(object sender, EventArgs e)
        {

        }


    }

}
