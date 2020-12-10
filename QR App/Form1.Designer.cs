namespace QR_App
{
    partial class QRApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRApp));
            this.buttonBarCode = new System.Windows.Forms.Button();
            this.buttonQRCode = new System.Windows.Forms.Button();
            this.pictureBoxBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBarCode = new System.Windows.Forms.TextBox();
            this.textQRCode = new System.Windows.Forms.TextBox();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.buttonPrintBar = new System.Windows.Forms.Button();
            this.buttonPrintQR = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageLabelQr = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBarCode
            // 
            this.buttonBarCode.Location = new System.Drawing.Point(85, 271);
            this.buttonBarCode.Name = "buttonBarCode";
            this.buttonBarCode.Size = new System.Drawing.Size(108, 23);
            this.buttonBarCode.TabIndex = 0;
            this.buttonBarCode.Text = "Create Bar Code";
            this.buttonBarCode.UseVisualStyleBackColor = true;
            this.buttonBarCode.Click += new System.EventHandler(this.buttonBarCode_Click);
            // 
            // buttonQRCode
            // 
            this.buttonQRCode.Location = new System.Drawing.Point(345, 271);
            this.buttonQRCode.Name = "buttonQRCode";
            this.buttonQRCode.Size = new System.Drawing.Size(99, 23);
            this.buttonQRCode.TabIndex = 1;
            this.buttonQRCode.Text = "Create QR Code";
            this.buttonQRCode.UseVisualStyleBackColor = true;
            this.buttonQRCode.Click += new System.EventHandler(this.buttonQRCode_Click_1);
            // 
            // pictureBoxBar
            // 
            this.pictureBoxBar.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBar.Name = "pictureBoxBar";
            this.pictureBoxBar.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxBar.TabIndex = 2;
            this.pictureBoxBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BarCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "QR Code";
            // 
            // textBarCode
            // 
            this.textBarCode.Location = new System.Drawing.Point(63, 300);
            this.textBarCode.Name = "textBarCode";
            this.textBarCode.Size = new System.Drawing.Size(455, 20);
            this.textBarCode.TabIndex = 5;
            // 
            // textQRCode
            // 
            this.textQRCode.Location = new System.Drawing.Point(63, 326);
            this.textQRCode.Name = "textQRCode";
            this.textQRCode.Size = new System.Drawing.Size(455, 20);
            this.textQRCode.TabIndex = 6;
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxQR.Location = new System.Drawing.Point(268, 12);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxQR.TabIndex = 7;
            this.pictureBoxQR.TabStop = false;
            // 
            // buttonPrintBar
            // 
            this.buttonPrintBar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPrintBar.Location = new System.Drawing.Point(85, 364);
            this.buttonPrintBar.Name = "buttonPrintBar";
            this.buttonPrintBar.Size = new System.Drawing.Size(108, 23);
            this.buttonPrintBar.TabIndex = 8;
            this.buttonPrintBar.Text = "Print Bar";
            this.buttonPrintBar.UseVisualStyleBackColor = true;
            this.buttonPrintBar.Click += new System.EventHandler(this.buttonPrintBar_Click);
            // 
            // buttonPrintQR
            // 
            this.buttonPrintQR.Location = new System.Drawing.Point(345, 364);
            this.buttonPrintQR.Name = "buttonPrintQR";
            this.buttonPrintQR.Size = new System.Drawing.Size(99, 23);
            this.buttonPrintQR.TabIndex = 9;
            this.buttonPrintQR.Text = "Print QR";
            this.buttonPrintQR.UseVisualStyleBackColor = true;
            this.buttonPrintQR.Click += new System.EventHandler(this.buttonPrintQR_Click_1);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(199, 276);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 10;
            // 
            // MessageLabelQr
            // 
            this.MessageLabelQr.AutoSize = true;
            this.MessageLabelQr.Location = new System.Drawing.Point(450, 274);
            this.MessageLabelQr.Name = "MessageLabelQr";
            this.MessageLabelQr.Size = new System.Drawing.Size(0, 13);
            this.MessageLabelQr.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(223, 415);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ResearcherS Palestine";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // QRApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 437);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.MessageLabelQr);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.buttonPrintQR);
            this.Controls.Add(this.buttonPrintBar);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.textQRCode);
            this.Controls.Add(this.textBarCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBar);
            this.Controls.Add(this.buttonQRCode);
            this.Controls.Add(this.buttonBarCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRApp";
            this.Text = "QRApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBarCode;
        private System.Windows.Forms.Button buttonQRCode;
        private System.Windows.Forms.PictureBox pictureBoxBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBarCode;
        private System.Windows.Forms.TextBox textQRCode;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.Button buttonPrintBar;
        private System.Windows.Forms.Button buttonPrintQR;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label MessageLabelQr;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

