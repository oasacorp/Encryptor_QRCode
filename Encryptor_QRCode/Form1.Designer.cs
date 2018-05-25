namespace Encryptor_QRCode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.addrText = new System.Windows.Forms.TextBox();
            this.iconText = new System.Windows.Forms.TextBox();
            this.encText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(837, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 456);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Icon";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(308, 443);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(235, 81);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(293, 193);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(429, 31);
            this.titleText.TabIndex = 5;
            // 
            // addrText
            // 
            this.addrText.Location = new System.Drawing.Point(293, 251);
            this.addrText.Name = "addrText";
            this.addrText.Size = new System.Drawing.Size(429, 31);
            this.addrText.TabIndex = 6;
            // 
            // iconText
            // 
            this.iconText.Location = new System.Drawing.Point(293, 314);
            this.iconText.Name = "iconText";
            this.iconText.Size = new System.Drawing.Size(87, 31);
            this.iconText.TabIndex = 7;
            // 
            // encText
            // 
            this.encText.Location = new System.Drawing.Point(837, 599);
            this.encText.Name = "encText";
            this.encText.ReadOnly = true;
            this.encText.Size = new System.Drawing.Size(499, 31);
            this.encText.TabIndex = 8;
            this.encText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 666);
            this.Controls.Add(this.encText);
            this.Controls.Add(this.iconText);
            this.Controls.Add(this.addrText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "HomeMate QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox addrText;
        private System.Windows.Forms.TextBox iconText;
        private System.Windows.Forms.TextBox encText;
    }
}

