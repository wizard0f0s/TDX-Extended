namespace TDX_Extended
{
    partial class Settings_Form
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.addressBookBtn = new System.Windows.Forms.Button();
            this.serverLbl = new System.Windows.Forms.Label();
            this.serverTxtBox = new System.Windows.Forms.TextBox();
            this.envLbl = new System.Windows.Forms.Label();
            this.envTxtBox = new System.Windows.Forms.TextBox();
            this.accountLbl = new System.Windows.Forms.Label();
            this.accountTxtBox = new System.Windows.Forms.TextBox();
            this.passwdTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.passwdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // addressBookBtn
            // 
            this.addressBookBtn.Location = new System.Drawing.Point(27, 69);
            this.addressBookBtn.Name = "addressBookBtn";
            this.addressBookBtn.Size = new System.Drawing.Size(157, 23);
            this.addressBookBtn.TabIndex = 2;
            this.addressBookBtn.Text = "Address Book";
            this.addressBookBtn.UseVisualStyleBackColor = true;
            this.addressBookBtn.Click += new System.EventHandler(this.addressBookBtn_Click);
            // 
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Location = new System.Drawing.Point(12, 106);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(89, 15);
            this.serverLbl.TabIndex = 3;
            this.serverLbl.Text = "Selected Server:";
            // 
            // serverTxtBox
            // 
            this.serverTxtBox.Location = new System.Drawing.Point(111, 98);
            this.serverTxtBox.Name = "serverTxtBox";
            this.serverTxtBox.ReadOnly = true;
            this.serverTxtBox.Size = new System.Drawing.Size(150, 23);
            this.serverTxtBox.TabIndex = 4;
            // 
            // envLbl
            // 
            this.envLbl.AutoSize = true;
            this.envLbl.Location = new System.Drawing.Point(12, 135);
            this.envLbl.Name = "envLbl";
            this.envLbl.Size = new System.Drawing.Size(78, 15);
            this.envLbl.TabIndex = 5;
            this.envLbl.Text = "Environment:";
            // 
            // envTxtBox
            // 
            this.envTxtBox.Location = new System.Drawing.Point(111, 127);
            this.envTxtBox.Name = "envTxtBox";
            this.envTxtBox.ReadOnly = true;
            this.envTxtBox.Size = new System.Drawing.Size(150, 23);
            this.envTxtBox.TabIndex = 6;
            // 
            // accountLbl
            // 
            this.accountLbl.AutoSize = true;
            this.accountLbl.Location = new System.Drawing.Point(12, 164);
            this.accountLbl.Name = "accountLbl";
            this.accountLbl.Size = new System.Drawing.Size(55, 15);
            this.accountLbl.TabIndex = 7;
            this.accountLbl.Text = "Account:";
            // 
            // accountTxtBox
            // 
            this.accountTxtBox.Location = new System.Drawing.Point(111, 156);
            this.accountTxtBox.Name = "accountTxtBox";
            this.accountTxtBox.ReadOnly = true;
            this.accountTxtBox.Size = new System.Drawing.Size(150, 23);
            this.accountTxtBox.TabIndex = 8;
            // 
            // passwdTxtBox
            // 
            this.passwdTxtBox.Location = new System.Drawing.Point(111, 185);
            this.passwdTxtBox.Name = "passwdTxtBox";
            this.passwdTxtBox.PasswordChar = '*';
            this.passwdTxtBox.ReadOnly = true;
            this.passwdTxtBox.Size = new System.Drawing.Size(150, 23);
            this.passwdTxtBox.TabIndex = 9;
            // 
            // passwdLbl
            // 
            this.passwdLbl.AutoSize = true;
            this.passwdLbl.Location = new System.Drawing.Point(12, 193);
            this.passwdLbl.Name = "passwdLbl";
            this.passwdLbl.Size = new System.Drawing.Size(60, 15);
            this.passwdLbl.TabIndex = 10;
            this.passwdLbl.Text = "Password:";
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwdLbl);
            this.Controls.Add(this.passwdTxtBox);
            this.Controls.Add(this.accountTxtBox);
            this.Controls.Add(this.accountLbl);
            this.Controls.Add(this.envTxtBox);
            this.Controls.Add(this.envLbl);
            this.Controls.Add(this.serverTxtBox);
            this.Controls.Add(this.serverLbl);
            this.Controls.Add(this.addressBookBtn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Settings_Form";
            this.Text = "Settings_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button addressBookBtn;
        private Label serverLbl;
        private TextBox serverTxtBox;
        private Label envLbl;
        private TextBox envTxtBox;
        private Label accountLbl;
        private TextBox accountTxtBox;
        private MaskedTextBox passwdTxtBox;
        private Label passwdLbl;
    }
}