using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        string _filePath;
        
        public Form1()
        {

            InitializeComponent();
            tbfilePath.Text = "File Path";

            btnDeletePicture.Enabled = false;

            


            //if (pbxPictureViewer.Image != null)
            //{
            //    MessageBox.Show("Test");
            //    btnDeletePicture.Enabled = true;
            //}
        }

        //pictureBox1.Image = Image.FromFile(@"Images\a.bmp");
        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxPictureViewer.Image = new Bitmap(fileDialog.FileName);
                 _filePath = fileDialog.FileName;

                tbfilePath.Text = _filePath;
                btnDeletePicture.Enabled = true;
                
                
            }

            
        }

        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            pbxPictureViewer.Image = null;
            tbfilePath.Text = "File Path";
            btnDeletePicture.Enabled = false;
        }


        
        

    }
}









