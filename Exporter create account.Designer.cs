using System;
using System.Windows.Forms;

namespace LEARASHU
{
    partial class create_account
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.EfirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EphoneNumTextBox = new System.Windows.Forms.TextBox();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EpasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.EemailTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox1 = new System.Windows.Forms.CheckBox();
            this.EgenderRadiolbl = new System.Windows.Forms.Label();
            this.EmaleRadioButton = new System.Windows.Forms.RadioButton();
            this.EfemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.EregionLbl = new System.Windows.Forms.Label();
            this.EregionComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EareaComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EproductComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.topPanel.Controls.Add(this.label13);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1171, 72);
            this.topPanel.TabIndex = 18;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(473, 36);
            this.label13.TabIndex = 14;
            this.label13.Text = "Exporter Account Creation Page";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // EfirstNameTextBox
            // 
            this.EfirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EfirstNameTextBox.Location = new System.Drawing.Point(332, 115);
            this.EfirstNameTextBox.Name = "EfirstNameTextBox";
            this.EfirstNameTextBox.Size = new System.Drawing.Size(157, 27);
            this.EfirstNameTextBox.TabIndex = 5;
            // 
            // EphoneNumTextBox
            // 
            this.EphoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EphoneNumTextBox.Location = new System.Drawing.Point(332, 276);
            this.EphoneNumTextBox.Name = "EphoneNumTextBox";
            this.EphoneNumTextBox.Size = new System.Drawing.Size(157, 27);
            this.EphoneNumTextBox.TabIndex = 7;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filePathTextBox.Location = new System.Drawing.Point(332, 404);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(160, 27);
            this.filePathTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date of Birth\r\n";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Proof Document";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // EpasswordTextBox
            // 
            this.EpasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EpasswordTextBox.Location = new System.Drawing.Point(332, 470);
            this.EpasswordTextBox.Name = "EpasswordTextBox";
            this.EpasswordTextBox.PasswordChar = '*';
            this.EpasswordTextBox.Size = new System.Drawing.Size(157, 27);
            this.EpasswordTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(395, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(617, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(612, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Already have an account?";
            // 
            // browseButton
            // 
            this.browseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Location = new System.Drawing.Point(498, 402);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(85, 29);
            this.browseButton.TabIndex = 21;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            // 
            // EemailTextBox
            // 
            this.EemailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EemailTextBox.Location = new System.Drawing.Point(332, 342);
            this.EemailTextBox.Name = "EemailTextBox";
            this.EemailTextBox.Size = new System.Drawing.Size(157, 27);
            this.EemailTextBox.TabIndex = 22;
            // 
            // showPasswordCheckBox1
            // 
            this.showPasswordCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordCheckBox1.AutoSize = true;
            this.showPasswordCheckBox1.Location = new System.Drawing.Point(498, 476);
            this.showPasswordCheckBox1.Name = "showPasswordCheckBox1";
            this.showPasswordCheckBox1.Size = new System.Drawing.Size(72, 24);
            this.showPasswordCheckBox1.TabIndex = 23;
            this.showPasswordCheckBox1.Text = "Show";
            this.showPasswordCheckBox1.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EgenderRadiolbl
            // 
            this.EgenderRadiolbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EgenderRadiolbl.AutoSize = true;
            this.EgenderRadiolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EgenderRadiolbl.Location = new System.Drawing.Point(788, 142);
            this.EgenderRadiolbl.Name = "EgenderRadiolbl";
            this.EgenderRadiolbl.Size = new System.Drawing.Size(94, 29);
            this.EgenderRadiolbl.TabIndex = 24;
            this.EgenderRadiolbl.Text = "Gender";
            // 
            // EmaleRadioButton
            // 
            this.EmaleRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmaleRadioButton.AutoSize = true;
            this.EmaleRadioButton.Location = new System.Drawing.Point(897, 145);
            this.EmaleRadioButton.Name = "EmaleRadioButton";
            this.EmaleRadioButton.Size = new System.Drawing.Size(66, 24);
            this.EmaleRadioButton.TabIndex = 25;
            this.EmaleRadioButton.TabStop = true;
            this.EmaleRadioButton.Text = "Male";
            this.EmaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // EfemaleRadioButton
            // 
            this.EfemaleRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EfemaleRadioButton.AutoSize = true;
            this.EfemaleRadioButton.Location = new System.Drawing.Point(969, 145);
            this.EfemaleRadioButton.Name = "EfemaleRadioButton";
            this.EfemaleRadioButton.Size = new System.Drawing.Size(85, 24);
            this.EfemaleRadioButton.TabIndex = 26;
            this.EfemaleRadioButton.TabStop = true;
            this.EfemaleRadioButton.Text = "Female";
            this.EfemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // EregionLbl
            // 
            this.EregionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EregionLbl.AutoSize = true;
            this.EregionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EregionLbl.Location = new System.Drawing.Point(788, 250);
            this.EregionLbl.Name = "EregionLbl";
            this.EregionLbl.Size = new System.Drawing.Size(199, 29);
            this.EregionLbl.TabIndex = 27;
            this.EregionLbl.Text = "Region/City Adm.";
            // 
            // EregionComboBox
            // 
            this.EregionComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EregionComboBox.FormattingEnabled = true;
            this.EregionComboBox.Items.AddRange(new object[] {
            "Afar Region",
            "Amhara Region",
            "Benishangul-Gumuz Region",
            "Central Ethiopia Region",
            "Gambela Region",
            "Harari Region",
            "Oromia Region",
            "Sidama Region",
            "Somali Region",
            "South Ethiopia Region",
            "Tigray Region",
            "Dire Dawa (chartered city)",
            "Addis Ababa (chartered city)"});
            this.EregionComboBox.Location = new System.Drawing.Point(1002, 251);
            this.EregionComboBox.Name = "EregionComboBox";
            this.EregionComboBox.Size = new System.Drawing.Size(157, 28);
            this.EregionComboBox.TabIndex = 28;
            this.EregionComboBox.SelectedIndexChanged += new System.EventHandler(this.EregionComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(788, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "City/subcity";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // EareaComboBox
            // 
            this.EareaComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EareaComboBox.FormattingEnabled = true;
            this.EareaComboBox.Location = new System.Drawing.Point(1002, 321);
            this.EareaComboBox.Name = "EareaComboBox";
            this.EareaComboBox.Size = new System.Drawing.Size(157, 28);
            this.EareaComboBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(788, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Exporting Product";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // EproductComboBox
            // 
            this.EproductComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EproductComboBox.FormattingEnabled = true;
            this.EproductComboBox.Items.AddRange(new object[] {
            "Coffee(Buna)",
            "khat(chat)",
            "Selit"});
            this.EproductComboBox.Location = new System.Drawing.Point(1002, 391);
            this.EproductComboBox.Name = "EproductComboBox";
            this.EproductComboBox.Size = new System.Drawing.Size(157, 28);
            this.EproductComboBox.TabIndex = 32;
            this.EproductComboBox.Text = "Select";
            this.EproductComboBox.SelectedIndexChanged += new System.EventHandler(this.EproductComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(870, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 29);
            this.label11.TabIndex = 33;
            this.label11.Text = "Address";
            // 
            // birthDate
            // 
            this.birthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDate.Location = new System.Drawing.Point(332, 220);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(160, 27);
            this.birthDate.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(116, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 29);
            this.label12.TabIndex = 36;
            this.label12.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameTextBox.Location = new System.Drawing.Point(332, 168);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(157, 27);
            this.LastNameTextBox.TabIndex = 35;
            // 
            // create_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 593);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EproductComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EareaComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EregionComboBox);
            this.Controls.Add(this.EregionLbl);
            this.Controls.Add(this.EfemaleRadioButton);
            this.Controls.Add(this.EmaleRadioButton);
            this.Controls.Add(this.EgenderRadiolbl);
            this.Controls.Add(this.showPasswordCheckBox1);
            this.Controls.Add(this.EemailTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EpasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.EphoneNumTextBox);
            this.Controls.Add(this.EfirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "create_account";
            this.Text = "create_account";
            this.Load += new System.EventHandler(this.create_account_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EproductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = EproductComboBox.SelectedItem.ToString();
        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EfirstNameTextBox;
        private System.Windows.Forms.TextBox EphoneNumTextBox;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EpasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox EemailTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox1;
        private System.Windows.Forms.Label EgenderRadiolbl;
        private System.Windows.Forms.RadioButton EmaleRadioButton;
        private System.Windows.Forms.RadioButton EfemaleRadioButton;
        private System.Windows.Forms.Label EregionLbl;
        private System.Windows.Forms.ComboBox EregionComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox EareaComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox EproductComboBox;
        private EventHandler EfirstNameTextBox_TextChanged;
        private EventHandler ElastNameTextBox_TextChanged;
        private EventHandler label1_Click;
        private EventHandler EphoneNumTextBox_TextChanged;
        private EventHandler filePathTextBox_TextChanged;
        private EventHandler EfemaleRadioButton_CheckedChanged;
        private EventHandler label5_Click;
        private EventHandler label4_Click;
        private EventHandler label3_Click;
        private EventHandler label2_Click;
        private EventHandler label8_Click;
        private EventHandler label7_Click;
        private EventHandler label6_Click;
        private PaintEventHandler tableLayoutPanel1_Paint;
        private Label label11;
        private DateTimePicker birthDate;
        private Label label12;
        private TextBox LastNameTextBox;
        private Label label13;

        public EventHandler textBox1_TextChanged { get; private set; }
        public EventHandler EareaComboBox_SelectedIndexChanged { get; private set; }
        public EventHandler EregionLbl_Click { get; private set; }
        public EventHandler EmaleRadioButton_CheckedChanged { get; private set; }
        public EventHandler EgenderRadiolbl_Click { get; private set; }
        public EventHandler EemailTextBox_TextChanged { get; private set; }
        public EventHandler EpasswordTextBox_TextChanged { get; private set; }
    }
}