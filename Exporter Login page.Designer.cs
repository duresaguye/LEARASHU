namespace LEARASHU
{
    partial class Login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.EbtnLogin = new System.Windows.Forms.Button();
            this.EtxtBoxPhoneOrEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FLpassLabel = new System.Windows.Forms.Label();
            this.EtxtBoxPassword = new System.Windows.Forms.TextBox();
            this.EbtnCreateAccount = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.showPasswordCheckBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(483, 96);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(176, 36);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "WELCOME";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // EbtnLogin
            // 
            this.EbtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.EbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EbtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EbtnLogin.Location = new System.Drawing.Point(440, 428);
            this.EbtnLogin.Name = "EbtnLogin";
            this.EbtnLogin.Size = new System.Drawing.Size(79, 38);
            this.EbtnLogin.TabIndex = 1;
            this.EbtnLogin.Text = "Login";
            this.EbtnLogin.UseVisualStyleBackColor = false;
            this.EbtnLogin.Click += new System.EventHandler(this.FloginBtn_Click);
            // 
            // EtxtBoxPhoneOrEmail
            // 
            this.EtxtBoxPhoneOrEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EtxtBoxPhoneOrEmail.Location = new System.Drawing.Point(440, 240);
            this.EtxtBoxPhoneOrEmail.Multiline = true;
            this.EtxtBoxPhoneOrEmail.Name = "EtxtBoxPhoneOrEmail";
            this.EtxtBoxPhoneOrEmail.Size = new System.Drawing.Size(295, 40);
            this.EtxtBoxPhoneOrEmail.TabIndex = 2;
            this.EtxtBoxPhoneOrEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Number/Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FLpassLabel
            // 
            this.FLpassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLpassLabel.AutoSize = true;
            this.FLpassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLpassLabel.Location = new System.Drawing.Point(435, 307);
            this.FLpassLabel.Name = "FLpassLabel";
            this.FLpassLabel.Size = new System.Drawing.Size(120, 29);
            this.FLpassLabel.TabIndex = 7;
            this.FLpassLabel.Text = "Password";
            this.FLpassLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // EtxtBoxPassword
            // 
            this.EtxtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EtxtBoxPassword.Location = new System.Drawing.Point(440, 363);
            this.EtxtBoxPassword.Multiline = true;
            this.EtxtBoxPassword.Name = "EtxtBoxPassword";
            this.EtxtBoxPassword.Size = new System.Drawing.Size(295, 40);
            this.EtxtBoxPassword.TabIndex = 6;
            this.EtxtBoxPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // EbtnCreateAccount
            // 
            this.EbtnCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EbtnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.EbtnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EbtnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EbtnCreateAccount.Location = new System.Drawing.Point(565, 428);
            this.EbtnCreateAccount.Name = "EbtnCreateAccount";
            this.EbtnCreateAccount.Size = new System.Drawing.Size(170, 38);
            this.EbtnCreateAccount.TabIndex = 8;
            this.EbtnCreateAccount.Text = "Create Account";
            this.EbtnCreateAccount.UseVisualStyleBackColor = false;
            this.EbtnCreateAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1171, 72);
            this.topPanel.TabIndex = 9;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Exporter Login Page";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1074, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 72);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // showPasswordCheckBox1
            // 
            this.showPasswordCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordCheckBox1.AutoSize = true;
            this.showPasswordCheckBox1.Location = new System.Drawing.Point(757, 379);
            this.showPasswordCheckBox1.Name = "showPasswordCheckBox1";
            this.showPasswordCheckBox1.Size = new System.Drawing.Size(72, 24);
            this.showPasswordCheckBox1.TabIndex = 25;
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
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 593);
            this.Controls.Add(this.showPasswordCheckBox1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.EbtnCreateAccount);
            this.Controls.Add(this.FLpassLabel);
            this.Controls.Add(this.EtxtBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EtxtBoxPhoneOrEmail);
            this.Controls.Add(this.EbtnLogin);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_page";
            this.Text = "Exporter LoginP age";
            this.Load += new System.EventHandler(this.Login_page_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button EbtnLogin;
        private System.Windows.Forms.TextBox EtxtBoxPhoneOrEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FLpassLabel;
        private System.Windows.Forms.TextBox EtxtBoxPassword;
        private System.Windows.Forms.Button EbtnCreateAccount;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showPasswordCheckBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}