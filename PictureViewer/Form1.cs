using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {

        string _path = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\PicturePath.txt";
        public Form1()
        {
            InitializeComponent();
            tbfilePath.ReadOnly = true;
            tbfilePath.Text = "File Path";
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            { 
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxPictureViewer.Image = new Bitmap(fileDialog.FileName);
                var filePath = fileDialog.FileName;
                tbfilePath.Text = filePath;

                btnDeletePicture.Enabled = true;

                File.WriteAllText(_path, filePath);
            }
        }
    }
        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            pbxPictureViewer.Image = null;
            File.WriteAllText(_path, "File Path");

            tbfilePath.Text = "File Path";
            DisableDeleteButton();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_path))
                File.Create(_path).Close();
            
            pbxPictureViewer.ImageLocation = File.ReadAllText(_path);
            tbfilePath.Text = File.ReadAllText(_path);
            if (tbfilePath.Text == "File Path")
                DisableDeleteButton();
            
        }
        private void DisableDeleteButton()
        {
            btnDeletePicture.Enabled = false;
        }

    }
}











































