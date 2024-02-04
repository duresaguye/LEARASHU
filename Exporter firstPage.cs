using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class firstPage : Form
    {


        public TextBox AccessPhoneNumberTextBox
        {
            get { return accessPhoneNumber; }
        }

        public TextBox AccessPasswordTextBox
        {
            get { return accessPassword; }
        }



        public firstPage()
        {
            InitializeComponent();
            InitializeTableLayoutPanel();
            DisplayDataOnTableLayoutPanel();
            InitializeComboBoxes();
            this.Load += firstPage_Load;
            EpostTextBox.Enter += EpostTextBox_Enter;
            EpostTextBox.Leave += EpostTextBox_Leave;
            ActiveControl = EfontStylecomboBox;


            panel6.Paint += panel6_Paint;


            this.WindowState = FormWindowState.Maximized;
        }

        




        private void ExporterSpecificationss()
        {
            string connectionString = @"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS; Initial Catalog=LEARASHU; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM productRegistration", sqlConnection);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }


       

        private void InitializeComboBoxes()
        {
            // Font Styles ComboBox
            EfontStylecomboBox.Items.AddRange(Enum.GetNames(typeof(FontStyle)));
            EfontStylecomboBox.SelectedIndex = 0;


            // Font Sizes ComboBox
            EfontSizecomboBox.Items.AddRange(new object[] { 10, 12, 14, 16 });
            EfontSizecomboBox.SelectedIndex = 1;
        }


        private void ApplyFontStyleAndSize()
        {
            try
            {
                // Get selected font style
                FontStyle selectedStyle = (FontStyle)Enum.Parse(typeof(FontStyle), EfontStylecomboBox.SelectedItem.ToString());

                // Get selected font size
                float selectedSize = Convert.ToSingle(EfontSizecomboBox.SelectedItem);

                // Ensure that the font size is greater than 0
                if (selectedSize <= 0)
                {
                    // Handle the error or set a default font size
                    selectedSize = 10;
                }

                // Apply font to the TextBox
                EpostTextBox.Font = new Font(EpostTextBox.Font.FontFamily, selectedSize, selectedStyle);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during font application
                MessageBox.Show("Error applying font: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ExporterSpecifications()
        {

            Color errorColor = Color.FromArgb(240, 128, 128);


            string patternDecimal = @"^\d+(\.\d+)?$";
            Regex objDecimal = new Regex(patternDecimal);

            bool isValid = true;

            // Validate price
            if (objDecimal.IsMatch(EpricePerKgTextBox.Text))
            {
                EpricePerKgTextBox.BackColor = Color.White;
            }
            else
            {
                EpricePerKgTextBox.BackColor = errorColor;
                isValid = false;
            }

            // Validate quantity
            if (objDecimal.IsMatch(EquantityInKgTextBox.Text))
            {
                EquantityInKgTextBox.BackColor = Color.White;
            }
            else
            {
                EquantityInKgTextBox.BackColor = errorColor;
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please enter valid numeric values for quantity and price before proceeding.");
                return;
            }


            // Connection string to your database
            string connectionString = @"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS; Initial Catalog=LEARASHU; Integrated Security=True";

            // Assuming you have the necessary TextBoxes and controls in your form
            ComboBox desiredProductTextBox = comboBox1; // Replace with your actual TextBox
            TextBox quantityTextBox = EquantityInKgTextBox; // Replace with your actual TextBox
            TextBox priceTextBox = EpricePerKgTextBox; // Replace with your actual TextBox
            ComboBox quauitycomboboxBox = EqualityComboBox; // Replace with your actual TextBox
            TextBox exportToTextBox = EexportToTextBox; // Replace with your actual TextBox
            DateTimePicker timeDateTimePicker = EdateTimePicker1; // Replace with your actual DateTimePicker



            // SQL query to insert data into the Exporter_Specifications table
            string query = "INSERT INTO Exporter_Specifications" +
                           "([The Product I want to Export is:], [I want this amount of Quantity], [I pay this much per Killogrm], [The Quality Level I want is:], " +
                           "[I am Exporting the product to:], [I need the product upto:]) " +
                           "VALUES (@Product, @Quantity, @Price, @QualityLevel, @ExportTo, @Time)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Product", (comboBox1.SelectedItem != null) ? comboBox1.SelectedItem.ToString() : "DefaultProduct");
                    command.Parameters.AddWithValue("@Quantity", int.Parse(EquantityInKgTextBox.Text)); // Assuming Quantity is an INT
                    command.Parameters.AddWithValue("@Price", decimal.Parse(EpricePerKgTextBox.Text)); // Assuming Price is a DECIMAL
                    command.Parameters.AddWithValue("@QualityLevel", (EqualityComboBox.SelectedItem != null) ? comboBox1.SelectedItem.ToString() : "DefaultProduct");
                    command.Parameters.AddWithValue("@ExportTo", EexportToTextBox.Text);
                    command.Parameters.AddWithValue("@Time", EdateTimePicker1.Value);


                    // Open the connection
                    connection.Open();

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Exporter Specifications inserted successfully.");
                        tabPage4.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert Exporter Specifications.");
                    }


                    
                }
            }
        }






        


        private void DisplayDataOnTableLayoutPanel()
        {
            string checkPassword = accessPassword.Text;
            string checkPhoneNumber = accessPhoneNumber.Text;


            // Connection string to your database
            string connectionString = @"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS; Initial Catalog=LEARASHU; Integrated Security=True";

            // SQL query to select data from the database
            string query = "SELECT * FROM exporterCreateAccountt WHERE phoneNumber = @checkPhoneNumber AND password = @checkPassword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@checkPhoneNumber", checkPhoneNumber);
                    command.Parameters.AddWithValue("@checkPassword", checkPassword);
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Assuming your TabControl is named tabControl1
                        // and the index of the desired tab is 2 (as you've set it)
                        TabPage tabPage = tabControl1.TabPages[1];

                        // Assuming your TableLayoutPanel is named tableLayoutPanel1
                        TableLayoutPanel tableLayoutPanel = tabPage.Controls["tableLayoutPanel1"] as TableLayoutPanel;

                        // Assuming your Labels are named ElblName, ElblAge, ElblExportTo, etc.
                        Label labelFirstName = tableLayoutPanel.Controls["firstName"] as Label;
                        Label labelLastName = tableLayoutPanel.Controls["lastName"] as Label;
                        Label labelDateOfBirth = tableLayoutPanel.Controls["dateOfBirth"] as Label;
                        Label labelProduct = tableLayoutPanel.Controls["product"] as Label;
                        Label labelRegion = tableLayoutPanel.Controls["region"] as Label;
                        Label labelCity = tableLayoutPanel.Controls["AreaLabel"] as Label;
                        Label labelGender = tableLayoutPanel.Controls["gender"] as Label;
                        Label labelEmail = tableLayoutPanel.Controls["emailLabel"] as Label; // assuming your email label is named EmailLabel
                        Label labelPhoneNumber = tableLayoutPanel.Controls["PhoneNumberLabel"] as Label; // assuming your phone number label is named PhoneNumberLabel

                        // Set the text of Labels with data from the database
                        firstName.Text = reader["firstName"].ToString();
                        lastName.Text = reader["lastName"].ToString();
                        dateOfBirthLabel.Text = reader["dateOfBirth"].ToString();
                        product.Text = reader["exportingProduct"].ToString();
                        region.Text = reader["region"].ToString();
                        AreaLabel.Text = reader["city"].ToString();
                        gender.Text = reader["gender"].ToString();
                        emailLabel.Text = reader["emailAddress"].ToString();
                        phoneNumberLabel.Text = reader["phoneNumber"].ToString();
                    }

                    // Close the reader and connection
                    reader.Close();
                    connection.Close();
                }
            }
        }








        private void InitializeTableLayoutPanel()
        {
            // Initialize your TableLayoutPanel here and set the RowCount and ColumnCount properties.
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.RowCount = 2; // Update with your desired row count.
            tableLayoutPanel1.ColumnCount = 2; // Update with your desired column count.

            // Add the TableLayoutPanel to your form's controls.
            Controls.Add(tableLayoutPanel1);

        }





       







            private void InitializeTabControl()
        {
        }

        bool menuExpand = false;


        private void firstPage_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height -= 20; // Adjust the value based on the desired speed of the transition

                if (menuContainer.Height <= 69)
                {
                    menuContainer.Height = 69; // Ensure the height doesn't go below 69
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height += 20; // Adjust the value based on the desired speed of the transition

                if (menuContainer.Height >= 280)
                {
                    menuContainer.Height = 280; // Ensure the height doesn't exceed 309
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 15; 

                if (sidebar.Width <= 95)
                {
                    sidebar.Width = 95; 
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 15; 

                if (sidebar.Width >= 309)
                {
                    sidebar.Width = 309; 
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Close();
        }

        private void EbtnSetting_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;

        }

        private void EbtnRegister_Click(object sender, EventArgs e)
        {
           tabControl1.SelectedIndex = 0;
            
        }

        private void EbtnExplore_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            ExporterSpecificationss();
        }

        private void EbtnProfile_Click(object sender, EventArgs e)
        {
          
            tabControl1.SelectedIndex = 2;
            DisplayDataOnTableLayoutPanel();

        }

        private void EbtnHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            LoadProfileAndCoverImages();

        }

        private void EbtnAbout_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ElblName_Click(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExporterSpecifications();
           

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string websiteUrl = "https://duresaguye.github.io/learshu-About-Us/";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void EfontStylecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFontStyleAndSize();
        }

        private void EfontSizecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFontStyleAndSize();
        }

        private void EpostTextBox_Enter(object sender, EventArgs e)
        {
            if (EpostTextBox.Text == "Share your thoughts here")
            {
                EpostTextBox.Text = "";
                EpostTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void EpostTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EpostTextBox.Text) || EpostTextBox.Text == "|")
            {
                EpostTextBox.Text = "Share your thoughts here";
                EpostTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }




        private void LoadProfileAndCoverImages()
        {

            string checkPhoneNumber = accessPhoneNumber.Text;



            string connectionString = @"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS; Initial Catalog=LEARASHU; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT CoverPicture, ProfilePicture FROM UserAdditionalData WHERE phoneNumber = @checkPhoneNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@checkPhoneNumber", checkPhoneNumber);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] coverPictureData = (byte[])reader["CoverPicture"];
                                byte[] profilePictureData = (byte[])reader["ProfilePicture"];

                                // Convert byte arrays to Image
                                Image coverPicture = ByteArrayToImage(coverPictureData);
                                Image profilePicture = ByteArrayToImage(profilePictureData);

                                // Set the images to PictureBox controls
                                pictureBox1.Image = coverPicture;
                                pictureBox3.Image = profilePicture;
                                pictureBox4.Image = profilePicture;
                                pictureBox2.Image = coverPicture;


                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading images: " + ex.Message);
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Draw a thicker border for the panel
            int borderWidth = 20;
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                                    Color.Black, borderWidth, ButtonBorderStyle.Solid,
                                    Color.Black, borderWidth, ButtonBorderStyle.Solid,
                                    Color.Black, borderWidth, ButtonBorderStyle.Solid,
                                    Color.Black, borderWidth, ButtonBorderStyle.Solid);

            // Create rounded edges for the panel
            int cornerRadius = 30;
            Rectangle rectangle = panel1.ClientRectangle;
            rectangle.Inflate(-borderWidth, -borderWidth);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (GraphicsPath path = RoundedRectangle(rectangle, cornerRadius))
            {
                using (Pen pen = new Pen(Color.Black, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }





        }


        private GraphicsPath RoundedRectangle(Rectangle rectangle, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, cornerRadius * 10, cornerRadius * 10, 180, 90);
            path.AddArc(rectangle.Right - cornerRadius * 10, rectangle.Y, cornerRadius * 10, cornerRadius * 2, 270, 90);
            path.AddArc(rectangle.Right - cornerRadius * 10, rectangle.Bottom - cornerRadius * 10, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(rectangle.X, rectangle.Bottom - cornerRadius * 10, cornerRadius * 10, cornerRadius * 10, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
