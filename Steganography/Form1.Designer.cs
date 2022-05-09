namespace Steganography
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.PreviewCheckbox = new System.Windows.Forms.CheckBox();
            this.ClearImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(343, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steganograph";
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectImageButton.Location = new System.Drawing.Point(73, 80);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(173, 68);
            this.SelectImageButton.TabIndex = 2;
            this.SelectImageButton.Text = "Select image";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Enabled = false;
            this.EncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EncryptButton.Location = new System.Drawing.Point(502, 488);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(187, 78);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DecryptButton.Location = new System.Drawing.Point(165, 488);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(187, 78);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // PreviewBox
            // 
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewBox.Location = new System.Drawing.Point(330, 80);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(538, 383);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewBox.TabIndex = 6;
            this.PreviewBox.TabStop = false;
            this.PreviewBox.Click += new System.EventHandler(this.PreviewBox_Click);
            // 
            // PreviewCheckbox
            // 
            this.PreviewCheckbox.AutoSize = true;
            this.PreviewCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreviewCheckbox.Location = new System.Drawing.Point(97, 154);
            this.PreviewCheckbox.Name = "PreviewCheckbox";
            this.PreviewCheckbox.Size = new System.Drawing.Size(118, 24);
            this.PreviewCheckbox.TabIndex = 7;
            this.PreviewCheckbox.Text = "Hide preview";
            this.PreviewCheckbox.UseVisualStyleBackColor = true;
            this.PreviewCheckbox.CheckedChanged += new System.EventHandler(this.PreviewCheckbox_CheckedChanged);
            // 
            // ClearImageButton
            // 
            this.ClearImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearImageButton.Location = new System.Drawing.Point(73, 264);
            this.ClearImageButton.Name = "ClearImageButton";
            this.ClearImageButton.Size = new System.Drawing.Size(173, 68);
            this.ClearImageButton.TabIndex = 8;
            this.ClearImageButton.Text = "Clear Image";
            this.ClearImageButton.UseVisualStyleBackColor = true;
            this.ClearImageButton.Click += new System.EventHandler(this.ClearImageButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 616);
            this.Controls.Add(this.ClearImageButton);
            this.Controls.Add(this.PreviewCheckbox);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.CheckBox PreviewCheckbox;
        private System.Windows.Forms.Button ClearImageButton;
    }
}

