namespace TDX_Extended
{
    partial class AddressBook_Form
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prodServerTxtBox = new System.Windows.Forms.TextBox();
            this.prodAdminBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.prodBeidTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodKeyTxtBox = new System.Windows.Forms.TextBox();
            this.prodUserPwdTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prodUserUsernameTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodUserBtn = new System.Windows.Forms.RadioButton();
            this.prodUserServerTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sandboxUserPwdTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sandboxUserUsernameTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sandboxUserBtn = new System.Windows.Forms.RadioButton();
            this.sandboxUserServerTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sandboxKeyTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sandboxBeidTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sandboxAdminBtn = new System.Windows.Forms.RadioButton();
            this.sandboxServerTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(713, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server: (form https://url.tdx.com/TDWebApi)";
            // 
            // prodServerTxtBox
            // 
            this.prodServerTxtBox.Location = new System.Drawing.Point(32, 111);
            this.prodServerTxtBox.Name = "prodServerTxtBox";
            this.prodServerTxtBox.Size = new System.Drawing.Size(305, 23);
            this.prodServerTxtBox.TabIndex = 4;
            // 
            // prodAdminBtn
            // 
            this.prodAdminBtn.AutoSize = true;
            this.prodAdminBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodAdminBtn.Location = new System.Drawing.Point(12, 65);
            this.prodAdminBtn.Name = "prodAdminBtn";
            this.prodAdminBtn.Size = new System.Drawing.Size(216, 25);
            this.prodAdminBtn.TabIndex = 5;
            this.prodAdminBtn.TabStop = true;
            this.prodAdminBtn.Text = "Production Server (Admin):";
            this.prodAdminBtn.UseVisualStyleBackColor = true;
            this.prodAdminBtn.CheckedChanged += new System.EventHandler(this.prodAdminBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "BEID:";
            // 
            // prodBeidTxtBox
            // 
            this.prodBeidTxtBox.Location = new System.Drawing.Point(32, 155);
            this.prodBeidTxtBox.Name = "prodBeidTxtBox";
            this.prodBeidTxtBox.Size = new System.Drawing.Size(305, 23);
            this.prodBeidTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Web Services Key:";
            // 
            // prodKeyTxtBox
            // 
            this.prodKeyTxtBox.Location = new System.Drawing.Point(33, 199);
            this.prodKeyTxtBox.Name = "prodKeyTxtBox";
            this.prodKeyTxtBox.Size = new System.Drawing.Size(304, 23);
            this.prodKeyTxtBox.TabIndex = 9;
            // 
            // prodUserPwdTxtBox
            // 
            this.prodUserPwdTxtBox.Location = new System.Drawing.Point(33, 395);
            this.prodUserPwdTxtBox.Name = "prodUserPwdTxtBox";
            this.prodUserPwdTxtBox.PasswordChar = '*';
            this.prodUserPwdTxtBox.Size = new System.Drawing.Size(304, 23);
            this.prodUserPwdTxtBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // prodUserUsernameTxtBox
            // 
            this.prodUserUsernameTxtBox.Location = new System.Drawing.Point(32, 351);
            this.prodUserUsernameTxtBox.Name = "prodUserUsernameTxtBox";
            this.prodUserUsernameTxtBox.Size = new System.Drawing.Size(305, 23);
            this.prodUserUsernameTxtBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username:";
            // 
            // prodUserBtn
            // 
            this.prodUserBtn.AutoSize = true;
            this.prodUserBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodUserBtn.Location = new System.Drawing.Point(12, 261);
            this.prodUserBtn.Name = "prodUserBtn";
            this.prodUserBtn.Size = new System.Drawing.Size(202, 25);
            this.prodUserBtn.TabIndex = 12;
            this.prodUserBtn.TabStop = true;
            this.prodUserBtn.Text = "Production Server (User):";
            this.prodUserBtn.UseVisualStyleBackColor = true;
            this.prodUserBtn.CheckedChanged += new System.EventHandler(this.prodUserBtn_CheckedChanged);
            // 
            // prodUserServerTxtBox
            // 
            this.prodUserServerTxtBox.Location = new System.Drawing.Point(32, 307);
            this.prodUserServerTxtBox.Name = "prodUserServerTxtBox";
            this.prodUserServerTxtBox.Size = new System.Drawing.Size(305, 23);
            this.prodUserServerTxtBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Server: (form https://url.tdx.com/TDWebApi)";
            // 
            // sandboxUserPwdTxtBox
            // 
            this.sandboxUserPwdTxtBox.Location = new System.Drawing.Point(408, 395);
            this.sandboxUserPwdTxtBox.Name = "sandboxUserPwdTxtBox";
            this.sandboxUserPwdTxtBox.PasswordChar = '*';
            this.sandboxUserPwdTxtBox.Size = new System.Drawing.Size(305, 23);
            this.sandboxUserPwdTxtBox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Password:";
            // 
            // sandboxUserUsernameTxtBox
            // 
            this.sandboxUserUsernameTxtBox.Location = new System.Drawing.Point(407, 351);
            this.sandboxUserUsernameTxtBox.Name = "sandboxUserUsernameTxtBox";
            this.sandboxUserUsernameTxtBox.Size = new System.Drawing.Size(306, 23);
            this.sandboxUserUsernameTxtBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Username:";
            // 
            // sandboxUserBtn
            // 
            this.sandboxUserBtn.AutoSize = true;
            this.sandboxUserBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sandboxUserBtn.Location = new System.Drawing.Point(387, 261);
            this.sandboxUserBtn.Name = "sandboxUserBtn";
            this.sandboxUserBtn.Size = new System.Drawing.Size(186, 25);
            this.sandboxUserBtn.TabIndex = 26;
            this.sandboxUserBtn.TabStop = true;
            this.sandboxUserBtn.Text = "Sandbox Server (User):";
            this.sandboxUserBtn.UseVisualStyleBackColor = true;
            this.sandboxUserBtn.CheckedChanged += new System.EventHandler(this.sandboxUserBtn_CheckedChanged);
            // 
            // sandboxUserServerTxtBox
            // 
            this.sandboxUserServerTxtBox.Location = new System.Drawing.Point(407, 307);
            this.sandboxUserServerTxtBox.Name = "sandboxUserServerTxtBox";
            this.sandboxUserServerTxtBox.Size = new System.Drawing.Size(306, 23);
            this.sandboxUserServerTxtBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Server: (form https://url.tdx.com/SBTDWebApi)";
            // 
            // sandboxKeyTxtBox
            // 
            this.sandboxKeyTxtBox.Location = new System.Drawing.Point(408, 199);
            this.sandboxKeyTxtBox.Name = "sandboxKeyTxtBox";
            this.sandboxKeyTxtBox.Size = new System.Drawing.Size(305, 23);
            this.sandboxKeyTxtBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Web Services Key:";
            // 
            // sandboxBeidTxtBox
            // 
            this.sandboxBeidTxtBox.Location = new System.Drawing.Point(407, 155);
            this.sandboxBeidTxtBox.Name = "sandboxBeidTxtBox";
            this.sandboxBeidTxtBox.Size = new System.Drawing.Size(306, 23);
            this.sandboxBeidTxtBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "BEID:";
            // 
            // sandboxAdminBtn
            // 
            this.sandboxAdminBtn.AutoSize = true;
            this.sandboxAdminBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sandboxAdminBtn.Location = new System.Drawing.Point(387, 65);
            this.sandboxAdminBtn.Name = "sandboxAdminBtn";
            this.sandboxAdminBtn.Size = new System.Drawing.Size(200, 25);
            this.sandboxAdminBtn.TabIndex = 19;
            this.sandboxAdminBtn.TabStop = true;
            this.sandboxAdminBtn.Text = "Sandbox Server (Admin):";
            this.sandboxAdminBtn.UseVisualStyleBackColor = true;
            this.sandboxAdminBtn.CheckedChanged += new System.EventHandler(this.sandboxAdminBtn_CheckedChanged);
            // 
            // sandboxServerTxtBox
            // 
            this.sandboxServerTxtBox.Location = new System.Drawing.Point(407, 111);
            this.sandboxServerTxtBox.Name = "sandboxServerTxtBox";
            this.sandboxServerTxtBox.Size = new System.Drawing.Size(306, 23);
            this.sandboxServerTxtBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(407, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Server: (form https://url.tdx.com/SBTDWebApi)";
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sandboxUserPwdTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sandboxUserUsernameTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sandboxUserBtn);
            this.Controls.Add(this.sandboxUserServerTxtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sandboxKeyTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sandboxBeidTxtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sandboxAdminBtn);
            this.Controls.Add(this.sandboxServerTxtBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.prodUserPwdTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodUserUsernameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prodUserBtn);
            this.Controls.Add(this.prodUserServerTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prodKeyTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodBeidTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodAdminBtn);
            this.Controls.Add(this.prodServerTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "AddressBook";
            this.Text = "AddressBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveBtn;
        private Button cancelBtn;
        private Label label2;
        private TextBox prodServerTxtBox;
        private RadioButton prodAdminBtn;
        private Label label1;
        private TextBox prodBeidTxtBox;
        private Label label3;
        private TextBox prodKeyTxtBox;
        private TextBox prodUserPwdTxtBox;
        private Label label4;
        private TextBox prodUserUsernameTxtBox;
        private Label label5;
        private RadioButton prodUserBtn;
        private TextBox prodUserServerTxtBox;
        private Label label6;
        private TextBox sandboxUserPwdTxtBox;
        private Label label7;
        private TextBox sandboxUserUsernameTxtBox;
        private Label label8;
        private RadioButton sandboxUserBtn;
        private TextBox sandboxUserServerTxtBox;
        private Label label9;
        private TextBox sandboxKeyTxtBox;
        private Label label10;
        private TextBox sandboxBeidTxtBox;
        private Label label11;
        private RadioButton sandboxAdminBtn;
        private TextBox sandboxServerTxtBox;
        private Label label12;
    }
}