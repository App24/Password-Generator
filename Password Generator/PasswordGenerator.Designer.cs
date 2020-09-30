using JeremieLauncher;

namespace Password_Generator
{
    partial class PasswordGenerator
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
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.chkLetters = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new JeremieLauncher.PlaceholderTextBox();
            this.txtLength = new JeremieLauncher.PlaceholderTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.lbPasswords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumbers.Location = new System.Drawing.Point(237, 165);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(92, 24);
            this.chkNumbers.TabIndex = 6;
            this.chkNumbers.Text = "Numbers";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.Location = new System.Drawing.Point(256, 112);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(73, 20);
            this.lblFeatures.TabIndex = 5;
            this.lblFeatures.Text = "Features";
            // 
            // chkLetters
            // 
            this.chkLetters.AutoSize = true;
            this.chkLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLetters.Location = new System.Drawing.Point(237, 135);
            this.chkLetters.Name = "chkLetters";
            this.chkLetters.Size = new System.Drawing.Size(78, 24);
            this.chkLetters.TabIndex = 4;
            this.chkLetters.Text = "Letters";
            this.chkLetters.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpecial.Location = new System.Drawing.Point(237, 195);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(162, 24);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special Characters";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(195, 288);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(287, 29);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(195, 256);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(310, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(195, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Password";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(260, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 26);
            this.txtName.TabIndex = 0;
            this.txtName.Placeholder = "Name";
            this.txtName.Text = this.txtName.Placeholder;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(232, 83);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(186, 26);
            this.txtLength.TabIndex = 0;
            this.txtLength.Placeholder = "Length of Password";
            this.txtLength.Text = this.txtLength.Placeholder;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(195, 358);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(204, 29);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Get Password";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lbPasswords
            // 
            this.lbPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswords.FormattingEnabled = true;
            this.lbPasswords.ItemHeight = 20;
            this.lbPasswords.Location = new System.Drawing.Point(565, 12);
            this.lbPasswords.Name = "lbPasswords";
            this.lbPasswords.Size = new System.Drawing.Size(166, 384);
            this.lbPasswords.TabIndex = 9;
            this.lbPasswords.SelectedIndexChanged += new System.EventHandler(this.lbPasswords_SelectedIndexChanged);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 405);
            this.Controls.Add(this.lbPasswords);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkSpecial);
            this.Controls.Add(this.chkLetters);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.txtLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox txtLength;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.CheckBox chkLetters;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPassword;
        private JeremieLauncher.PlaceholderTextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ListBox lbPasswords;
    }
}

