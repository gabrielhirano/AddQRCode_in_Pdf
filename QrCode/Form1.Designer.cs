namespace QrCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQrImageData = new System.Windows.Forms.TextBox();
            this.btnGenerateQr = new System.Windows.Forms.Button();
            this.pbxQrImage = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite link para Qr_Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxQrImageData
            // 
            this.tbxQrImageData.Location = new System.Drawing.Point(51, 40);
            this.tbxQrImageData.Name = "tbxQrImageData";
            this.tbxQrImageData.Size = new System.Drawing.Size(267, 23);
            this.tbxQrImageData.TabIndex = 2;
            // 
            // btnGenerateQr
            // 
            this.btnGenerateQr.BackColor = System.Drawing.Color.White;
            this.btnGenerateQr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateQr.Location = new System.Drawing.Point(109, 166);
            this.btnGenerateQr.Name = "btnGenerateQr";
            this.btnGenerateQr.Size = new System.Drawing.Size(134, 54);
            this.btnGenerateQr.TabIndex = 4;
            this.btnGenerateQr.Text = "Generate QR";
            this.btnGenerateQr.UseVisualStyleBackColor = false;
            this.btnGenerateQr.Click += new System.EventHandler(this.btnGenerateQr_Click);
            // 
            // pbxQrImage
            // 
            this.pbxQrImage.BackColor = System.Drawing.Color.White;
            this.pbxQrImage.Location = new System.Drawing.Point(461, 22);
            this.pbxQrImage.Name = "pbxQrImage";
            this.pbxQrImage.Size = new System.Drawing.Size(267, 174);
            this.pbxQrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQrImage.TabIndex = 5;
            this.pbxQrImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(51, 106);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(267, 23);
            this.inputPath.TabIndex = 7;
            this.inputPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite caminho do pdf";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPath);
            this.Controls.Add(this.pbxQrImage);
            this.Controls.Add(this.btnGenerateQr);
            this.Controls.Add(this.tbxQrImageData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxQrImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQrImageData;
        private System.Windows.Forms.Button btnGenerateQr;
        private System.Windows.Forms.PictureBox pbxQrImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Label label2;
    }
}
