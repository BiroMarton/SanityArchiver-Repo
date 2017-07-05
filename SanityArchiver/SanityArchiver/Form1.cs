using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class Decompress : Form
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        private String pathString;
        private string rootPath;

        public Decompress()
        {
            InitializeComponent();

            foreach (DriveInfo drive in allDrives)
            {
                LeftBox.Items.Add(drive.Name + "," + drive.DriveType);
              

            }


        }

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        public void ListItems(DirectoryInfo dir, ListBox box)
        {
            box.Items.Clear();
            if (!dir.Exists)
            {
                myConsole.Text = "The specified directory does not exist.";
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

        public void RegExSearch(DirectoryInfo dir, ListBox box, string name)
        {
            box.Items.Clear();
            Regex regex = new Regex(name);
            if (!dir.Exists)
            {
                myConsole.Text = "The specified directory does not exist.";
                return;
            }

            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                if(regex.IsMatch(directory.Name))
                box.Items.Add(directory.Name);
            }

            foreach (FileInfo files in dir.GetFiles())
            {
               if (regex.IsMatch(files.Name))
                {
                    box.Items.Add(files.Name);
                }
                
            }
            if (box.Items.Count == 0)
            {
                myConsole.Text = "No match found.";
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

        static  void DecompressFile(FileInfo fileToDecompress)
        {

            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        
                    }
                }
            }
        }



        private void LeftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LeftDisplay.Items.Clear();
                String[] info = LeftBox.SelectedItem.ToString().Split(',');
                String root = info[0];
                pathString = @root;
                rootPath = @root;
                Location.Text = @root;
                DirectoryInfo rootDir = new DirectoryInfo(root);
                ListItems(rootDir, LeftDisplay);
                FreeSpaceAmount.Text = allDrives[LeftBox.SelectedIndex].AvailableFreeSpace / 1048576 + " GB";
            }
            catch (IOException exception)
            {
                FreeSpaceAmount.Text = "NaN";
                LeftDisplay.Items.Clear();
                myConsole.Text = "Can not open that disc.";
            }




        }

        private void LeftDisplay_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                string path = @pathString + @"\" + text;
                @pathString = @path;
                Location.Text = @path;
                DirectoryInfo currentDir = new DirectoryInfo(path);
                ListItems(currentDir, LeftDisplay);
            }
            catch (NullReferenceException exception)
            {

                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {

                myConsole.Text = "You do not have permission for that action.";
            }



        }

        private void BackLeft_Click(object sender, EventArgs e)
        {
            try
            {
                pathString = rootPath;
                Location.Text = @pathString;
                DirectoryInfo currentDir = new DirectoryInfo(rootPath);
                ListItems(currentDir, LeftDisplay);
            }
            catch (ArgumentNullException exception)
            {

            }

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
                
                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {
                
                myConsole.Text = "You do not have permission for that action.";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                DirectoryInfo currentDir = new DirectoryInfo(pathString);
                string path = @pathString + @"\" + text;
                FileInfo currentFile = new FileInfo(path);
                DecompressFile(currentFile);
                ListItems(currentDir, LeftDisplay);
            }
            catch (NullReferenceException exception)
            {
                
                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {
                
                myConsole.Text = "You do not have permission for that action.";
            }
            catch (InvalidDataException id)
            {

                myConsole.Text = "This is not a gzip file.";
            }

        }

        private void ReadText_Click(object sender, EventArgs e)
        {
            String text = LeftDisplay.SelectedItem.ToString();
            DirectoryInfo currentDir = new DirectoryInfo(pathString);
            string path = @pathString + @"\" + text;

            string content = System.IO.File.ReadAllText(path);
            myConsole.Text = content;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                DirectoryInfo currentDir = new DirectoryInfo(pathString);
                string path = @pathString + @"\" + text;
                string content = System.IO.File.ReadAllText(path);

                FileStream stream = new FileStream(path,
                    FileMode.OpenOrCreate, FileAccess.Write);

                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                CryptoStream crStream = new CryptoStream(stream,
                    cryptic.CreateEncryptor(), CryptoStreamMode.Write);


                byte[] data = ASCIIEncoding.ASCII.GetBytes(content);

                crStream.Write(data, 0, data.Length);

                crStream.Close();
                stream.Close();

                myConsole.Text = "Data enrypted.";


            }
            catch (NullReferenceException exception)
            {

                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {

                myConsole.Text = "You do not have permission for that action.";
            }

        }

        private void Decrypt_Click(object sender, EventArgs e)
        {

            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                DirectoryInfo currentDir = new DirectoryInfo(pathString);
                string path = @pathString + @"\" + text;

                FileStream stream = new FileStream(path,
                    FileMode.Open, FileAccess.Read);

                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                CryptoStream crStream = new CryptoStream(stream,
                    cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                StreamReader reader = new StreamReader(crStream);

                string data = reader.ReadToEnd();

                

                reader.Close();
                stream.Close();



                File.WriteAllText(path,data);

                myConsole.Text = "File decrypted.";

            }
            catch (NullReferenceException exception)
            {

                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {

                myConsole.Text = "You do not have permission for that action.";
            }
        }

        private void saveText_Click(object sender, EventArgs e)
        {
            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                DirectoryInfo currentDir = new DirectoryInfo(pathString);
                string path = @pathString + @"\" + text;

                string content = myConsole.Text;

                File.WriteAllText(path, content);

                myConsole.Text = "Textfile saved.";
            }
            catch (NullReferenceException exception)
            {

                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {

                myConsole.Text = "You do not have permission for that action.";
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                DirectoryInfo currentDir = new DirectoryInfo(pathString);
                string path = @pathString + @"\" + text;

                FileInfo file = new FileInfo(path);

                file.IsReadOnly = !file.IsReadOnly;

                if (file.IsReadOnly == false)
                {
                    myConsole.Text = "The file is readable and writeable.";
                }
                else
                {
                    myConsole.Text = "The file is read-only.";
                }
            }
            catch (NullReferenceException exception)
            {

                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {

                myConsole.Text = "You do not have permission for that action.";
            }


        }

        private void Hidden_Click(object sender, EventArgs e)
        {
            try
            {
                String text = LeftDisplay.SelectedItem.ToString();
                DirectoryInfo currentDir = new DirectoryInfo(pathString);
                string path = @pathString + @"\" + text;

                FileAttributes attributes = File.GetAttributes(path);



                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    // Show the file.
                    attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                    File.SetAttributes(path, attributes);
                    myConsole.Text = "The file is no longer hidden.";
                }
                else
                {
                    // Hide the file.
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
                    myConsole.Text = "The file is hidden now.";
                }
            }
            catch (NullReferenceException exception)
            {

                myConsole.Text = "No files selected!";
            }
            catch (UnauthorizedAccessException ua)
            {

                myConsole.Text = "You do not have permission for that action.";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            
            DirectoryInfo currentDir = new DirectoryInfo(pathString);

            RegExSearch(currentDir,LeftDisplay,regex.Text);
        }

    }

}
