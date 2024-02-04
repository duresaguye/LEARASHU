using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class create_account_step2 : Form
    {

        public TextBox AccessPhoneNumberTextBox
        {
            get { return createAccountPhoneNumber; }
        }

        
        public create_account_step2()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }










        

        private void coverUploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    CoverPictureBox.Image = Image.FromFile(selectedImagePath);
                }
            }
        }








        private void profileUploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    profilePictureBox.Image = Image.FromFile(selectedImagePath);
                }
            }
        }








        private void proofDocUploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedDocumentPath = openFileDialog.FileName;
                    proofDocTextBox.Text = selectedDocumentPath; // Assuming you have a TextBox named textBoxDocumentPath
                    byte[] documentFileBytes = File.ReadAllBytes(selectedDocumentPath);
                    // Process the selected PDF document file, for example, by reading it into a byte array
                }
            }
        }








        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }









        private void finishRegButton_Click(object sender, EventArgs e)
        {
            string documentPath = proofDocTextBox.Text;

            // Check if a path is provided
            if (!string.IsNullOrEmpty(documentPath))
            {
                // Read the content of the document into a byte array
                byte[] documentFileBytes = File.ReadAllBytes(documentPath);

                // Convert images to byte arrays
                byte[] coverPictureBytes = ImageToByteArray(CoverPictureBox.Image);
                byte[] profilePictureBytes = ImageToByteArray(profilePictureBox.Image);
                string phoneNumber = AccessPhoneNumberTextBox.Text;


                string connectionString = @"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO UserAdditionalData (CoverPicture, ProfilePicture, DocumentFile, phoneNumber) VALUES (@CoverPicture, @ProfilePicture, @DocumentFile, @phoneNumber)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@CoverPicture", coverPictureBytes);
                            command.Parameters.AddWithValue("@ProfilePicture", profilePictureBytes);
                            command.Parameters.AddWithValue("@DocumentFile", documentFileBytes);
                            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);


                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data saved successfully.");
                    Login_page login_Page = new Login_page();
                    login_Page.Show();
                    this.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Exception: {ex.Message}");
                }
            }

            else
            {
                MessageBox.Show("Please provide a document path.");
            }
        }








        private void EbtnSuperHome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}