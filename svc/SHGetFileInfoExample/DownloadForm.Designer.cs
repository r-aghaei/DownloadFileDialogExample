namespace SHGetFileInfoExample {
    partial class DownloadForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.OpenCommandButton = new System.Windows.Forms.Button();
            this.SaveCommandButton = new System.Windows.Forms.Button();
            this.CancelCommandButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCommandButton
            // 
            this.OpenCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenCommandButton.Location = new System.Drawing.Point(236, 129);
            this.OpenCommandButton.Name = "OpenCommandButton";
            this.OpenCommandButton.Size = new System.Drawing.Size(75, 31);
            this.OpenCommandButton.TabIndex = 1;
            this.OpenCommandButton.Text = "&Open";
            this.OpenCommandButton.UseVisualStyleBackColor = true;
            // 
            // SaveCommandButton
            // 
            this.SaveCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCommandButton.Location = new System.Drawing.Point(324, 129);
            this.SaveCommandButton.Name = "SaveCommandButton";
            this.SaveCommandButton.Size = new System.Drawing.Size(75, 31);
            this.SaveCommandButton.TabIndex = 0;
            this.SaveCommandButton.Text = "&Save";
            this.SaveCommandButton.UseVisualStyleBackColor = true;
            // 
            // CancelCommandButton
            // 
            this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCommandButton.Location = new System.Drawing.Point(412, 129);
            this.CancelCommandButton.Name = "CancelCommandButton";
            this.CancelCommandButton.Size = new System.Drawing.Size(75, 31);
            this.CancelCommandButton.TabIndex = 2;
            this.CancelCommandButton.Text = "&Cancel";
            this.CancelCommandButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to open or save this file?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(147, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(98, 20);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name of File";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(147, 60);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(90, 20);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "Type of File";
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Location = new System.Drawing.Point(16, 36);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(64, 64);
            this.IconPictureBox.TabIndex = 8;
            this.IconPictureBox.TabStop = false;
            // 
            // DownloadForm
            // 
            this.AcceptButton = this.SaveCommandButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelCommandButton;
            this.ClientSize = new System.Drawing.Size(499, 172);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelCommandButton);
            this.Controls.Add(this.SaveCommandButton);
            this.Controls.Add(this.OpenCommandButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadForm";
            this.ShowIcon = false;
            this.Text = "File Download";
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button OpenCommandButton;
        public System.Windows.Forms.Button SaveCommandButton;
        public System.Windows.Forms.Button CancelCommandButton;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label TypeLabel;
        public System.Windows.Forms.PictureBox IconPictureBox;
    }
}