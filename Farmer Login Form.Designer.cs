namespace LEARASHU
{
    partial class Farmer_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmer_Login_Form));
            this.topPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FbtnCreateAccount = new System.Windows.Forms.Button();
            this.FLpassLabel = new System.Windows.Forms.Label();
            this.FtxtBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FtxtBoxPhoneOrEmail = new System.Windows.Forms.TextBox();
            this.FbtnLogin = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1171, 72);
            this.topPanel.TabIndex = 10;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1059, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 72);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Farmer Login Page";
            // 
            // FbtnCreateAccount
            // 
            this.FbtnCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FbtnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.FbtnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FbtnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FbtnCreateAccount.Location = new System.Drawing.Point(565, 443);
            this.FbtnCreateAccount.Name = "FbtnCreateAccount";
            this.FbtnCreateAccount.Size = new System.Drawing.Size(170, 38);
            this.FbtnCreateAccount.TabIndex = 17;
            this.FbtnCreateAccount.Text = "Create Account";
            this.FbtnCreateAccount.UseVisualStyleBackColor = false;
            this.FbtnCreateAccount.Click += new System.EventHandler(this.FbtnCreateAccount_Click);
            // 
            // FLpassLabel
            // 
            this.FLpassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLpassLabel.AutoSize = true;
            this.FLpassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLpassLabel.Location = new System.Drawing.Point(435, 322);
            this.FLpassLabel.Name = "FLpassLabel";
            this.FLpassLabel.Size = new System.Drawing.Size(120, 29);
            this.FLpassLabel.TabIndex = 16;
            this.FLpassLabel.Text = "Password";
            // 
            // FtxtBoxPassword
            // 
            this.FtxtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FtxtBoxPassword.Location = new System.Drawing.Point(440, 378);
            this.FtxtBoxPassword.Multiline = true;
            this.FtxtBoxPassword.Name = "FtxtBoxPassword";
            this.FtxtBoxPassword.Size = new System.Drawing.Size(295, 40);
            this.FtxtBoxPassword.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone Number/Email";
            // 
            // FtxtBoxPhoneOrEmail
            // 
            this.FtxtBoxPhoneOrEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FtxtBoxPhoneOrEmail.Location = new System.Drawing.Point(440, 255);
            this.FtxtBoxPhoneOrEmail.Multiline = true;
            this.FtxtBoxPhoneOrEmail.Name = "FtxtBoxPhoneOrEmail";
            this.FtxtBoxPhoneOrEmail.Size = new System.Drawing.Size(295, 40);
            this.FtxtBoxPhoneOrEmail.TabIndex = 13;
            // 
            // FbtnLogin
            // 
            this.FbtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.FbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FbtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FbtnLogin.Location = new System.Drawing.Point(440, 443);
            this.FbtnLogin.Name = "FbtnLogin";
            this.FbtnLogin.Size = new System.Drawing.Size(79, 38);
            this.FbtnLogin.TabIndex = 12;
            this.FbtnLogin.Text = "Login";
            this.FbtnLogin.UseVisualStyleBackColor = false;
            this.FbtnLogin.Click += new System.EventHandler(this.FbtnLogin_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(483, 111);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(176, 36);
            this.welcomeLabel.TabIndex = 11;
            this.welcomeLabel.Text = "WELCOME";
            // 
            // showPasswordCheckBox1
            // 
            this.showPasswordCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordCheckBox1.AutoSize = true;
            this.showPasswordCheckBox1.Location = new System.Drawing.Point(765, 394);
            this.showPasswordCheckBox1.Name = "showPasswordCheckBox1";
            this.showPasswordCheckBox1.Size = new System.Drawing.Size(72, 24);
            this.showPasswordCheckBox1.TabIndex = 24;
            this.showPasswordCheckBox1.Text = "Show";
            this.showPasswordCheckBox1.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox1.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1171, 593);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // Farmer_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 593);
            this.Controls.Add(this.showPasswordCheckBox1);
            this.Controls.Add(this.FbtnCreateAccount);
            this.Controls.Add(this.FLpassLabel);
            this.Controls.Add(this.FtxtBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FtxtBoxPhoneOrEmail);
            this.Controls.Add(this.FbtnLogin);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Farmer_Login_Form";
            this.Text = "Farmer_Login_Form";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button FbtnCreateAccount;
        private System.Windows.Forms.Label FLpassLabel;
        private System.Windows.Forms.TextBox FtxtBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FtxtBoxPhoneOrEmail;
        private System.Windows.Forms.Button FbtnLogin;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox showPasswordCheckBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}