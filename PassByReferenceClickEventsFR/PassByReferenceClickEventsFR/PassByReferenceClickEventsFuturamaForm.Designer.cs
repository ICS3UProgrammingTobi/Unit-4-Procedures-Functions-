namespace PassByReferenceClickEventsFR
{
    partial class frmPassByReferenceClickEventsFuturama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClick = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(29, 22);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(583, 33);
            this.lblClick.TabIndex = 0;
            this.lblClick.Text = "Click on the image to change it randomly";
            // 
            // picImage
            // 
            this.picImage.Image = global::PassByReferenceClickEventsFR.Properties.Resources.QS;
            this.picImage.Location = new System.Drawing.Point(136, 77);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(350, 500);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmPassByReferenceClickEventsFuturama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 603);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblClick);
            this.Name = "frmPassByReferenceClickEventsFuturama";
            this.Text = "Pass by Reference & Click Events Futurama";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.PictureBox picImage;
    }
}

