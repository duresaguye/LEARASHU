using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class Farmer_Create_account_Step2 : Form
    {
        public Farmer_Create_account_Step2()
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

                string connectionString = @"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO farmerAdditionalData (CoverPicture, ProfilePicture, DocumentFile) VALUES (@CoverPicture, @ProfilePicture, @DocumentFile)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@CoverPicture", coverPictureBytes);
                            command.Parameters.AddWithValue("@ProfilePicture", profilePictureBytes);
                            command.Parameters.AddWithValue("@DocumentFile", documentFileBytes);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data saved successfully.");
                    Farmer_Login_Form farmer_Login_Form = new Farmer_Login_Form();
                    farmer_Login_Form.Show();
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

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
