
namespace QRCode
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxQrImageData = new System.Windows.Forms.TextBox();
            this.tbxQrImageFileName = new System.Windows.Forms.TextBox();
            this.pbxQrImage = new System.Windows.Forms.PictureBox();
            this.btnGenerateQr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(100, 31);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(241, 21);
            this.cboDevice.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(100, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 213);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(100, 344);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(241, 155);
            this.txtQRCode.TabIndex = 3;
            this.txtQRCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(100, 303);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(241, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text To QR Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "QR Image File";
            // 
            // tbxQrImageData
            // 
            this.tbxQrImageData.Location = new System.Drawing.Point(432, 93);
            this.tbxQrImageData.Name = "tbxQrImageData";
            this.tbxQrImageData.Size = new System.Drawing.Size(220, 20);
            this.tbxQrImageData.TabIndex = 7;
            // 
            // tbxQrImageFileName
            // 
            this.tbxQrImageFileName.Location = new System.Drawing.Point(432, 150);
            this.tbxQrImageFileName.Name = "tbxQrImageFileName";
            this.tbxQrImageFileName.Size = new System.Drawing.Size(220, 20);
            this.tbxQrImageFileName.TabIndex = 8;
            // 
            // pbxQrImage
            // 
            this.pbxQrImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxQrImage.Location = new System.Drawing.Point(432, 233);
            this.pbxQrImage.Name = "pbxQrImage";
            this.pbxQrImage.Size = new System.Drawing.Size(220, 198);
            this.pbxQrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQrImage.TabIndex = 9;
            this.pbxQrImage.TabStop = false;
            // 
            // btnGenerateQr
            // 
            this.btnGenerateQr.Location = new System.Drawing.Point(432, 190);
            this.btnGenerateQr.Name = "btnGenerateQr";
            this.btnGenerateQr.Size = new System.Drawing.Size(220, 23);
            this.btnGenerateQr.TabIndex = 10;
            this.btnGenerateQr.Text = "Generate QR";
            this.btnGenerateQr.UseVisualStyleBackColor = true;
            this.btnGenerateQr.Click += new System.EventHandler(this.btnGenerateQr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 524);
            this.Controls.Add(this.btnGenerateQr);
            this.Controls.Add(this.pbxQrImage);
            this.Controls.Add(this.tbxQrImageFileName);
            this.Controls.Add(this.tbxQrImageData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQrImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxQrImageData;
        private System.Windows.Forms.TextBox tbxQrImageFileName;
        private System.Windows.Forms.PictureBox pbxQrImage;
        private System.Windows.Forms.Button btnGenerateQr;
    }
}

