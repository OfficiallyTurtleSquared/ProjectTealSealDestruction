namespace ProjectTealSealDestruction
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.encryptionLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 34);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(776, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(9, 13);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(34, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input:";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "SHA512",
            "DES"});
            this.typeCombo.Location = new System.Drawing.Point(266, 5);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 2;
            // 
            // encryptionLabel
            // 
            this.encryptionLabel.AutoSize = true;
            this.encryptionLabel.Location = new System.Drawing.Point(173, 8);
            this.encryptionLabel.Name = "encryptionLabel";
            this.encryptionLabel.Size = new System.Drawing.Size(87, 13);
            this.encryptionLabel.TabIndex = 3;
            this.encryptionLabel.Text = "Encryption Type:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 92);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(776, 20);
            this.outputTextBox.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(9, 76);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output:";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(622, 180);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(713, 180);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 7;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(753, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(9, 127);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(74, 13);
            this.keyLabel.TabIndex = 9;
            this.keyLabel.Text = "Key (optional):";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(12, 143);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(776, 20);
            this.keyTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.encryptionLabel);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label encryptionLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
    }
}

