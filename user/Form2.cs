using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace user
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            string connectionString = "datasource = 127.0.0.1;port = 3306; username = root; database = csharapp;";
            string query = "SELECT * FROM verification WHERE username='" + username + "' AND password='" + password + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            reader = commandDatabase.ExecuteReader();

            if (reader.Read())
            {
                var Form = new Form4();
                Form.Show();
                this.Close();
                databaseConnection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '•';
            }
        }
    }
}
