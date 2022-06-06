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
            this.serverLbl = new System.Windows.Forms.Label();
            this.serverTxtBox = new System.Windows.Forms.TextBox();
            this.envLbl = new System.Windows.Forms.Label();
            this.envTxtBox = new System.Windows.Forms.TextBox();
            this.accountLbl = new System.Windows.Forms.Label();
            this.accountTxtBox = new System.Windows.Forms.TextBox();
            this.passwdTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.passwdLbl = new System.Windows.Forms.Label();
            this.friendlyNameTxtBox = new System.Windows.Forms.TextBox();
            this.friendlyNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.friendlyNameEntryTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pwdEntryTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.accountEntryTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.envEntryTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serverEntryTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.entrySaveBtn = new System.Windows.Forms.Button();
            this.entryCancelBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.counterLbl = new System.Windows.Forms.Label();
            this.leftBtn = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.testConnectionBtn = new System.Windows.Forms.Button();
            this.webServEntryCheckBox = new System.Windows.Forms.CheckBox();
            this.webServCheckBox = new System.Windows.Forms.CheckBox();
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Location = new System.Drawing.Point(165, 75);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(89, 15);
            this.serverLbl.TabIndex = 3;
            this.serverLbl.Text = "Selected Server:";
            // 
            // serverTxtBox
            // 
            this.serverTxtBox.Location = new System.Drawing.Point(264, 67);
            this.serverTxtBox.Name = "serverTxtBox";
            this.serverTxtBox.ReadOnly = true;
            this.serverTxtBox.Size = new System.Drawing.Size(350, 23);
            this.serverTxtBox.TabIndex = 4;
            // 
            // envLbl
            // 
            this.envLbl.AutoSize = true;
            this.envLbl.Location = new System.Drawing.Point(165, 104);
            this.envLbl.Name = "envLbl";
            this.envLbl.Size = new System.Drawing.Size(78, 15);
            this.envLbl.TabIndex = 5;
            this.envLbl.Text = "Environment:";
            // 
            // envTxtBox
            // 
            this.envTxtBox.Location = new System.Drawing.Point(264, 96);
            this.envTxtBox.Name = "envTxtBox";
            this.envTxtBox.ReadOnly = true;
            this.envTxtBox.Size = new System.Drawing.Size(350, 23);
            this.envTxtBox.TabIndex = 6;
            // 
            // accountLbl
            // 
            this.accountLbl.AutoSize = true;
            this.accountLbl.Location = new System.Drawing.Point(165, 133);
            this.accountLbl.Name = "accountLbl";
            this.accountLbl.Size = new System.Drawing.Size(55, 15);
            this.accountLbl.TabIndex = 7;
            this.accountLbl.Text = "Account:";
            // 
            // accountTxtBox
            // 
            this.accountTxtBox.Location = new System.Drawing.Point(264, 125);
            this.accountTxtBox.Name = "accountTxtBox";
            this.accountTxtBox.ReadOnly = true;
            this.accountTxtBox.Size = new System.Drawing.Size(350, 23);
            this.accountTxtBox.TabIndex = 8;
            // 
            // passwdTxtBox
            // 
            this.passwdTxtBox.Location = new System.Drawing.Point(264, 154);
            this.passwdTxtBox.Name = "passwdTxtBox";
            this.passwdTxtBox.PasswordChar = '*';
            this.passwdTxtBox.ReadOnly = true;
            this.passwdTxtBox.Size = new System.Drawing.Size(350, 23);
            this.passwdTxtBox.TabIndex = 9;
            // 
            // passwdLbl
            // 
            this.passwdLbl.AutoSize = true;
            this.passwdLbl.Location = new System.Drawing.Point(165, 162);
            this.passwdLbl.Name = "passwdLbl";
            this.passwdLbl.Size = new System.Drawing.Size(60, 15);
            this.passwdLbl.TabIndex = 10;
            this.passwdLbl.Text = "Password:";
            // 
            // friendlyNameTxtBox
            // 
            this.friendlyNameTxtBox.Location = new System.Drawing.Point(264, 38);
            this.friendlyNameTxtBox.Name = "friendlyNameTxtBox";
            this.friendlyNameTxtBox.ReadOnly = true;
            this.friendlyNameTxtBox.Size = new System.Drawing.Size(350, 23);
            this.friendlyNameTxtBox.TabIndex = 11;
            // 
            // friendlyNameLbl
            // 
            this.friendlyNameLbl.AutoSize = true;
            this.friendlyNameLbl.Location = new System.Drawing.Point(165, 46);
            this.friendlyNameLbl.Name = "friendlyNameLbl";
            this.friendlyNameLbl.Size = new System.Drawing.Size(87, 15);
            this.friendlyNameLbl.TabIndex = 12;
            this.friendlyNameLbl.Text = "Friendly Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(345, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selected Entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(345, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Address Book:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Friendly Name:";
            // 
            // friendlyNameEntryTxtBox
            // 
            this.friendlyNameEntryTxtBox.Location = new System.Drawing.Point(264, 259);
            this.friendlyNameEntryTxtBox.Name = "friendlyNameEntryTxtBox";
            this.friendlyNameEntryTxtBox.ReadOnly = true;
            this.friendlyNameEntryTxtBox.Size = new System.Drawing.Size(350, 23);
            this.friendlyNameEntryTxtBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // pwdEntryTxtBox
            // 
            this.pwdEntryTxtBox.Location = new System.Drawing.Point(264, 375);
            this.pwdEntryTxtBox.Name = "pwdEntryTxtBox";
            this.pwdEntryTxtBox.PasswordChar = '*';
            this.pwdEntryTxtBox.ReadOnly = true;
            this.pwdEntryTxtBox.Size = new System.Drawing.Size(350, 23);
            this.pwdEntryTxtBox.TabIndex = 20;
            // 
            // accountEntryTxtBox
            // 
            this.accountEntryTxtBox.Location = new System.Drawing.Point(264, 346);
            this.accountEntryTxtBox.Name = "accountEntryTxtBox";
            this.accountEntryTxtBox.ReadOnly = true;
            this.accountEntryTxtBox.Size = new System.Drawing.Size(350, 23);
            this.accountEntryTxtBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Account:";
            // 
            // envEntryTxtBox
            // 
            this.envEntryTxtBox.Location = new System.Drawing.Point(264, 317);
            this.envEntryTxtBox.Name = "envEntryTxtBox";
            this.envEntryTxtBox.ReadOnly = true;
            this.envEntryTxtBox.Size = new System.Drawing.Size(350, 23);
            this.envEntryTxtBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Environment:";
            // 
            // serverEntryTxtBox
            // 
            this.serverEntryTxtBox.Location = new System.Drawing.Point(264, 288);
            this.serverEntryTxtBox.Name = "serverEntryTxtBox";
            this.serverEntryTxtBox.ReadOnly = true;
            this.serverEntryTxtBox.Size = new System.Drawing.Size(350, 23);
            this.serverEntryTxtBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selected Server:";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 321);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 25;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // entrySaveBtn
            // 
            this.entrySaveBtn.Enabled = false;
            this.entrySaveBtn.Location = new System.Drawing.Point(321, 444);
            this.entrySaveBtn.Name = "entrySaveBtn";
            this.entrySaveBtn.Size = new System.Drawing.Size(75, 23);
            this.entrySaveBtn.TabIndex = 26;
            this.entrySaveBtn.Text = "Save";
            this.entrySaveBtn.UseVisualStyleBackColor = true;
            this.entrySaveBtn.Click += new System.EventHandler(this.entrySaveBtn_Click);
            // 
            // entryCancelBtn
            // 
            this.entryCancelBtn.Enabled = false;
            this.entryCancelBtn.Location = new System.Drawing.Point(444, 444);
            this.entryCancelBtn.Name = "entryCancelBtn";
            this.entryCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.entryCancelBtn.TabIndex = 27;
            this.entryCancelBtn.Text = "Cancel";
            this.entryCancelBtn.UseVisualStyleBackColor = true;
            this.entryCancelBtn.Click += new System.EventHandler(this.entryCancelBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(12, 233);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 28;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 276);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 29;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.counterLbl.Location = new System.Drawing.Point(468, 235);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(52, 21);
            this.counterLbl.TabIndex = 30;
            this.counterLbl.Text = "0 of 0";
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(264, 230);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(50, 23);
            this.leftBtn.TabIndex = 31;
            this.leftBtn.Text = "<<";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(564, 230);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(50, 23);
            this.rightBtn.TabIndex = 32;
            this.rightBtn.Text = ">>";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // testConnectionBtn
            // 
            this.testConnectionBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testConnectionBtn.Location = new System.Drawing.Point(661, 233);
            this.testConnectionBtn.Name = "testConnectionBtn";
            this.testConnectionBtn.Size = new System.Drawing.Size(127, 23);
            this.testConnectionBtn.TabIndex = 33;
            this.testConnectionBtn.Text = "Test Connection";
            this.testConnectionBtn.UseVisualStyleBackColor = true;
            this.testConnectionBtn.Click += new System.EventHandler(this.testConnectionBtn_Click);
            // 
            // webServEntryCheckBox
            // 
            this.webServEntryCheckBox.AutoSize = true;
            this.webServEntryCheckBox.Enabled = false;
            this.webServEntryCheckBox.Location = new System.Drawing.Point(264, 404);
            this.webServEntryCheckBox.Name = "webServEntryCheckBox";
            this.webServEntryCheckBox.Size = new System.Drawing.Size(154, 19);
            this.webServEntryCheckBox.TabIndex = 34;
            this.webServEntryCheckBox.Text = "is Web Services Account";
            this.webServEntryCheckBox.UseVisualStyleBackColor = true;
            // 
            // webServCheckBox
            // 
            this.webServCheckBox.AutoSize = true;
            this.webServCheckBox.Enabled = false;
            this.webServCheckBox.Location = new System.Drawing.Point(264, 183);
            this.webServCheckBox.Name = "webServCheckBox";
            this.webServCheckBox.Size = new System.Drawing.Size(154, 19);
            this.webServCheckBox.TabIndex = 35;
            this.webServCheckBox.Text = "is Web Services Account";
            this.webServCheckBox.UseVisualStyleBackColor = true;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 479);
            this.Controls.Add(this.webServCheckBox);
            this.Controls.Add(this.webServEntryCheckBox);
            this.Controls.Add(this.testConnectionBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.counterLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.entryCancelBtn);
            this.Controls.Add(this.entrySaveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.friendlyNameEntryTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pwdEntryTxtBox);
            this.Controls.Add(this.accountEntryTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.envEntryTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverEntryTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.friendlyNameLbl);
            this.Controls.Add(this.friendlyNameTxtBox);
            this.Controls.Add(this.passwdLbl);
            this.Controls.Add(this.passwdTxtBox);
            this.Controls.Add(this.accountTxtBox);
            this.Controls.Add(this.accountLbl);
            this.Controls.Add(this.envTxtBox);
            this.Controls.Add(this.envLbl);
            this.Controls.Add(this.serverTxtBox);
            this.Controls.Add(this.serverLbl);
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
        private Label serverLbl;
        private TextBox serverTxtBox;
        private Label envLbl;
        private TextBox envTxtBox;
        private Label accountLbl;
        private TextBox accountTxtBox;
        private MaskedTextBox passwdTxtBox;
        private Label passwdLbl;
        private TextBox friendlyNameTxtBox;
        private Label friendlyNameLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox friendlyNameEntryTxtBox;
        private Label label4;
        private MaskedTextBox pwdEntryTxtBox;
        private TextBox accountEntryTxtBox;
        private Label label5;
        private TextBox envEntryTxtBox;
        private Label label6;
        private TextBox serverEntryTxtBox;
        private Label label7;
        private Button editBtn;
        private Button entrySaveBtn;
        private Button entryCancelBtn;
        private Button selectBtn;
        private Button addBtn;
        private Label counterLbl;
        private Button leftBtn;
        private Button rightBtn;
        private Button testConnectionBtn;
        private CheckBox webServEntryCheckBox;
        private CheckBox webServCheckBox;
    }
}