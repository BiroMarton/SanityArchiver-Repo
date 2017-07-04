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
        private String pathString;
        private string rootPath;

        public Form1()
        {
            InitializeComponent();

            foreach (DriveInfo drive in allDrives)
            {
                LeftBox.Items.Add(drive.Name + "," + drive.DriveType);
                RightBox.Items.Add(drive.Name + "," + drive.DriveType);
            }


        }

        public void ListItems(DirectoryInfo dir, ListBox box)
        {
            box.Items.Clear();
            if (!dir.Exists)
            {
                box.Items.Add("The specified directory does not exist.");
                return;
            }

            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                box.Items.Add(directory.Name);
            }

            foreach (FileInfo files in dir.GetFiles())
            {
                box.Items.Add(files.Name);
            }
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

        private void LeftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeftDisplay.Items.Clear();
            String[] info = LeftBox.SelectedItem.ToString().Split(',');
            String root = info[0];
            pathString = @root;
            rootPath = @root;
            DirectoryInfo rootDir = new DirectoryInfo(root);
            ListItems(rootDir,LeftDisplay);



        }

        private void LeftDisplay_DoubleClick(object sender, EventArgs e)
        {
            String text = LeftDisplay.SelectedItem.ToString();
            string path = @pathString + @"\" + text;
            @pathString = @path;
            DirectoryInfo currentDir = new DirectoryInfo(path);
            ListItems(currentDir, LeftDisplay);


        }

        private void BackLeft_Click(object sender, EventArgs e)
        {
            pathString = rootPath;
            DirectoryInfo currentDir = new DirectoryInfo(rootPath);
            ListItems(currentDir, LeftDisplay);
        }

        private void CompressLeft_Click_1(object sender, EventArgs e)
        {
            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                DirectoryInfo currentDir = new DirectoryInfo(pathString);
                string path = @pathString + @"\" + text;
                FileInfo currentFile = new FileInfo(path);
                ArchiveFile(currentDir, currentFile);
                ListItems(currentDir, LeftDisplay);
            }
            catch (NullReferenceException exception)
            {
                LeftDisplay.Items.Clear();
                LeftDisplay.Items.Add("No files selected!");
            }

        }
    }

}
