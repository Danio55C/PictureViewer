namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.pbxPictureViewer = new System.Windows.Forms.PictureBox();
            this.tbfilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPictureViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(12, 42);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(131, 46);
            this.btnLoadPicture.TabIndex = 0;
            this.btnLoadPicture.Text = "Dodaj zdjęcie";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.Location = new System.Drawing.Point(161, 42);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.Size = new System.Drawing.Size(133, 46);
            this.btnDeletePicture.TabIndex = 1;
            this.btnDeletePicture.Text = "Usuń zdjęcie";
            this.btnDeletePicture.UseVisualStyleBackColor = true;
            this.btnDeletePicture.Click += new System.EventHandler(this.btnDeletePicture_Click);
            // 
            // pbxPictureViewer
            // 
            this.pbxPictureViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPictureViewer.Location = new System.Drawing.Point(86, 109);
            this.pbxPictureViewer.Name = "pbxPictureViewer";
            this.pbxPictureViewer.Size = new System.Drawing.Size(788, 440);
            this.pbxPictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPictureViewer.TabIndex = 2;
            this.pbxPictureViewer.TabStop = false;
            // 
            // tbfilePath
            // 
            this.tbfilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbfilePath.Location = new System.Drawing.Point(0, 0);
            this.tbfilePath.Name = "tbfilePath";
            this.tbfilePath.Size = new System.Drawing.Size(984, 20);
            this.tbfilePath.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tbfilePath);
            this.Controls.Add(this.pbxPictureViewer);
            this.Controls.Add(this.btnDeletePicture);
            this.Controls.Add(this.btnLoadPicture);
            this.Name = "Form1";
            
            
            ((System.ComponentModel.ISupportInitialize)(this.pbxPictureViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.PictureBox pbxPictureViewer;
        private System.Windows.Forms.TextBox tbfilePath;
    }
}

