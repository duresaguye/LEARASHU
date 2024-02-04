using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class Farmer_Create_account_page : Form
    {








        private string connectionString = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True";
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();






        public Farmer_Create_account_page()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }





        private void button2_Click_1(object sender, EventArgs e)
        {
            Farmer_Login_Form farmer_Login_Form = new Farmer_Login_Form();
            farmer_Login_Form.Show();
            this.Close();
            
        }










        private void showPasswordCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            EpasswordTextBox.PasswordChar = showPasswordCheckBox1.Checked ? '\0' : '*';
        }






        private void EregionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] amhara = { "Bahir Dar", "Gondar", "Dessie", "Debre Markos", "Debre Berhan", "Woldiya", "Kombolcha", "Lalibela", "Mekane Selam", "Injibara", "Finote Selam", "Debre Tabor", "Bure", "Debre Sina", "Debre Werk" };
            string[] oromia = { "Adama (Nazret)", "Jimma", "Nekemte", "Bishoftu (Debre Zeyit)", "Shashamane", "Ambo", "Bule Hora", "Robe", "Asella", "Goba", "Bale Robe", "Negele Boran", "Guder", "Burayu", "Mojo" };

            string[] sidama = { "Hawassa", "Leku", "Yirgalem", "Dilla", "Aleta Wendo", "Bensa", "Wondo Genet", "Yirgacheffe", "Arbegona", "Chuko", "Hula" };
            string[] SNNPR = { "Kaffa", "Wolaita Sodo", "Arba Minch", "Sawla", "Dilla", "Dimeka", "Jinka", "Karati", "Gidole", "Soyama", "Kelle", "Laska", "Kolango" };

            EareaComboBox.Items.Clear();
            if (EregionComboBox.SelectedIndex == 0)
            {

                EareaComboBox.Items.AddRange(amhara);
            }
            else if (EregionComboBox.SelectedIndex == 1)
            {
                EareaComboBox.Items.AddRange(oromia);
            }
            else if (EregionComboBox.SelectedIndex == 2)
            {
                EareaComboBox.Items.AddRange(sidama);
            }
            else if (EregionComboBox.SelectedIndex == 3)
            {
                EareaComboBox.Items.AddRange(SNNPR);
            }
        }














        private void button1_Click_1(object sender, EventArgs e)
        {
            Color errorColor = Color.FromArgb(240, 128, 128);

            string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string patternPhone = @"^[0-9]{9}$";
            string patternStrongPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex objPhone = new Regex(patternPhone);
            Regex objEmail = new Regex(patternEmail);
            Regex objPassword = new Regex(patternStrongPassword);

            bool isValid = true;

            // Validate phone number
            if (objPhone.IsMatch(EphoneNumTextBox.Text))
            {
                EphoneNumTextBox.BackColor = Color.White;
            }
            else
            {
                EphoneNumTextBox.BackColor = errorColor;
                isValid = false;
            }

            // Validate email
            if (objEmail.IsMatch(EemailTextBox.Text))
            {
                EemailTextBox.BackColor = Color.White;
            }
            else
            {
                EemailTextBox.BackColor = errorColor;
                isValid = false;
            }

            // Validate password
            if (objPassword.IsMatch(EpasswordTextBox.Text))
            {
                EpasswordTextBox.BackColor = Color.White;
            }
            else
            {
                EpasswordTextBox.BackColor = errorColor;
                isValid = false;
            }

            // If data is not valid, return without inserting into the database
            if (!isValid)
            {
                MessageBox.Show("Please correct the errors in the form before proceeding.");
                return;

            }

            InsertUserIntoDatabase();

            // Move the form closing code after showing the create_account_step2 form
        }













        private void InsertUserIntoDatabase()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string firstName = EfirstNameTextBox.Text;
                string lastName = LastNameTextBox.Text;
                DateTime dateOfBirth = birthDate.Value;
                string phoneNumber = EphoneNumTextBox.Text;
                string email = EemailTextBox.Text;
                string password = EpasswordTextBox.Text;
                string gender = (EmaleRadioButton.Checked) ? "Male" : "Female";
                string region = EregionComboBox.SelectedItem?.ToString() ?? "DefaultRegion";
                string city = EareaComboBox.SelectedItem?.ToString() ?? "DefaultCity";
                string product = EproductComboBox.SelectedItem?.ToString() ?? "DefaultProduct";


                string query = "INSERT INTO farmerCreateAccountt (firstName, lastName, dateOfBirth, phoneNumber, emailAddress, password, gender, region, city, Product) " +
                               "VALUES (@firstName, @lastName, @dateOfBirth, @phoneNumber, @emailAddress, @password, @gender, @region, @city, @Product)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@emailAddress", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@region", region);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@Product", product);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");

                    Farmer_Create_account_Step2 farmer_Create_Account_Step2 = new Farmer_Create_account_Step2();
                    farmer_Create_Account_Step2.Show();
                    


                }
            }


        }







        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
