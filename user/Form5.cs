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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;
            String title = textBox5.Text;
            String author = textBox3.Text;
            String db = textBox2.Text;
            String dr = textBox4.Text;


            string query = $"INSERT INTO `books`(`ID`, `Title`, `Author`, `DB`, `DR`) VALUES('{ID}', '{title}', '{author}', '{db}', '{dr}')";

            string connectionString = "datasource = 127.0.0.1;port = 3306; username = root; database = csharapp;";
           
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            reader = commandDatabase.ExecuteReader();
            MessageBox.Show($"Successfully Added {title} to Database");
            databaseConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;
            String title = textBox5.Text;
            String author = textBox3.Text;
            String db = textBox2.Text;
            String dr = textBox4.Text;

            String query = $"UPDATE `books` SET `Title`= '{title}',`Author`= '{author}',`DB`= '{db}',`DR`= '{dr}' WHERE ID='{ID}'";

            string connectionString = "datasource = 127.0.0.1;port = 3306; username = root; database = csharapp;";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            reader = commandDatabase.ExecuteReader();
            MessageBox.Show($"Successfully Updated {title} in Database");
            databaseConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;
            String title = textBox5.Text;
            String author = textBox3.Text;
            String db = textBox2.Text;
            String dr = textBox4.Text;

            String query = $"DELETE FROM `books` WHERE ID={ID}";
            string connectionString = "datasource = 127.0.0.1;port = 3306; username = root; database = csharapp;";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            reader = commandDatabase.ExecuteReader();
            MessageBox.Show($"Successfully Deleted {title} to Database");
            databaseConnection.Close();
        }
    }
}
