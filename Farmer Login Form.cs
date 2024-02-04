using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class Farmer_Login_Form : Form
    {
        public Farmer_Login_Form()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }





        private void FbtnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = FtxtBoxPhoneOrEmail.Text;
            password = FtxtBoxPassword.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True"))

                {
                    conn.Open();

                    string query = "SELECT * FROM farmerCreateAccountt WHERE phoneNumber = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                Farmerr_First_Page farmerr_First_Page = new Farmerr_First_Page();
                                farmerr_First_Page.Show();
                                
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the exception or display a more informative error message
                MessageBox.Show("A SQL error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Log the exception or display a more informative error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FtxtBoxPassword.Clear();
            }
        }


        private void FbtnCreateAccount_Click(object sender, EventArgs e)
        {
            Farmer_Create_account_page farmer_Create_Account_Page = new Farmer_Create_account_page();
            farmer_Create_Account_Page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
            this.Close();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showPasswordCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            FtxtBoxPassword.PasswordChar = showPasswordCheckBox1.Checked ? '\0' : '*';
        }
    }
}
