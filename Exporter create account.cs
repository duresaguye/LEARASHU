using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace LEARASHU
{
    public partial class create_account : Form
    {










        private string connectionString = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True";
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();





        public create_account()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }





        private void button2_Click(object sender, EventArgs e)
        {
           Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Close();
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EpasswordTextBox.PasswordChar = showPasswordCheckBox1.Checked ? '\0' : '*';
        }







        private void EregionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] afar = { "Aba’ala", "Afambo", "Asaita", "Berhale", "Chifra", "Dewe", "Dubti", "Erebti", "Gewane", "Gulina", "Harshin", "Hemedti", "Kori", "Mille", "Serdo", "Yalo" };
            string[] amhara = { "Bahir Dar", "Gondar", "Dessie", "Debre Markos", "Debre Berhan", "Woldiya", "Kombelcha", "Lalibela", "Mekane Selam", "Injibara", "Finote Selam", "Debre Tabor", "Bure", "Debre Sina", "Debre Werk" };
            string[] benishangul = { "Assosa", "Kumruk", "Bambasi", "Guba", "Dibate", "Sherkole", "Pawe", "Mandura", "Homosha", "Belo Jegonfoy", "Wenbera" };
            string[] central_region_ethiopia = { "Butajira", "Welkite", "Hosaena", "Halaba Kulito", "Durame", "Worabe", "Saja", "Wosherbe", "Koshe", "Mudula" };
            string[] gambela = { "Gambela ", "Abobo", "Itang", "Jikawo", "Dimma", "Lare", "Mengesh", "Gog", "Akobo" };
            string[] harari = { "Harari ", "Jagol" };
            string[] oromia = { "Adama (Nazret)", "Jimma", "Nekemte", "Bishoftu (Debre Zeyit)", "Shashamane", "Ambo", "Bule Hora", "Robe", "Asella", "Goba", "Bale Robe", "Negele Boran", "Guder", "Burayu", "Mojo" };
            string[] sidama = { "Hawassa", "Leku", "Yirgalem", "Dilla", "Aleta Wendo", "Bensa", "Wondo Genet", "Yirgacheffe", "Arbegona", "Chuko", "Hula" };
            string[] somali = { "Jijiga (capital)", "Gode", "Dire Dawa", "Kebri Dahar", "Degehabur", "Fiiq", "Dhagahbur", "Wardheer", "Qabridahare", "Kelafo", "Mustahil", "Shilavo", "Danan", "Fiqi", "Qoraxay" };
            string[] south_Eth = { "Wolaita Sodo", "Arba Minch", "Sawla", "Dilla", "Dimeka", "Jinka", "Karati", "Gidole", "Soyama", "Kelle", "Laska", "Kolango" };
            string[] tigray = { "Mekelle", "Adigrat", "Axum (Aksum)", "Adwa", "Shire", "Humera", "Wukro", "Alamata", "Abiy Addi", "Maychew" };
            string[] diredaw = { "DireDawa" };
            string[] addisabab = { "Addis Ketema", "Akaky Kaliti", "Arada", "Nifas Silk-Lafto", "Bole", "Gulele", "Kolfe Keranio", "Lideta", "Yeka", "Kirkos" };

            EareaComboBox.Items.Clear();
            if (EregionComboBox.SelectedIndex == 0)
            {
                EareaComboBox.Items.AddRange(afar);
            }
            else if (EregionComboBox.SelectedIndex == 1)
            {
                EareaComboBox.Items.AddRange(amhara);
            }
            else if (EregionComboBox.SelectedIndex == 2)
            {
                EareaComboBox.Items.AddRange(benishangul);
            }
            else if (EregionComboBox.SelectedIndex == 3)
            {
                EareaComboBox.Items.AddRange(central_region_ethiopia);
            }
            else if (EregionComboBox.SelectedIndex == 4)
            {
                EareaComboBox.Items.AddRange(gambela);
            }
            else if (EregionComboBox.SelectedIndex == 5)
            {
                EareaComboBox.Items.AddRange(harari);
            }
            else if (EregionComboBox.SelectedIndex == 6)
            {
                EareaComboBox.Items.AddRange(oromia);
            }
            else if (EregionComboBox.SelectedIndex == 7)
            {
                EareaComboBox.Items.AddRange(sidama);
            }
            else if (EregionComboBox.SelectedIndex == 8)
            {
                EareaComboBox.Items.AddRange(somali);
            }
            else if (EregionComboBox.SelectedIndex == 9)
            {
                EareaComboBox.Items.AddRange(south_Eth);
            }
            else if (EregionComboBox.SelectedIndex == 10)
            {
                EareaComboBox.Items.AddRange(tigray);
            }
            else if (EregionComboBox.SelectedIndex == 11)
            {
                EareaComboBox.Items.AddRange(diredaw);
            }
            else if (EregionComboBox.SelectedIndex == 12)
            {
                EareaComboBox.Items.AddRange(addisabab);
            }
        }











        private void button1_Click(object sender, EventArgs e)
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


                    string query = "INSERT INTO exporterCreateAccountt (firstName, lastName, dateOfBirth, phoneNumber, emailAddress, password, gender, region, city, exportingProduct) " +
                                   "VALUES (@firstName, @lastName, @dateOfBirth, @phoneNumber, @emailAddress, @password, @gender, @region, @city, @exportingProduct)";

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
                        command.Parameters.AddWithValue("@exportingProduct", product);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                        



                    create_account_step2 create_Account_Step2 = new create_account_step2();
                    create_Account_Step2.Show();
                    create_Account_Step2.AccessPhoneNumberTextBox.Text = EphoneNumTextBox.Text;

                }
                }
        }












        

        

        

        private void create_account_Load(object sender, EventArgs e)
        {
            // You can add any additional initialization code here
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void filePathTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
