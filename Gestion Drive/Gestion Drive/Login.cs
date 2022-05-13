using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net;
using MySql.Data.MySqlClient;

namespace Gestion_Drive
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password='' ; database=projet2");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        private void btnconnexion_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "Select * FROM user where identifiant = '"+ txtusername.Text + "'";
            cmd = new MySqlCommand(login, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<string> user = new List<string>();
            /**
             * permet de lire les informations de la bdd
             * 
            */

            while (reader.Read())
            {
                user.Add(reader["ID_USER"].ToString());
                user.Add(reader["ID_ROLE"].ToString());
                user.Add(reader["IDENTIFIANT"].ToString());
                user.Add(reader["motdepasse"].ToString());

            }
            

            con.Close();

            if (BC.BCrypt.Verify(txtpassword.Text, user[3]) && user[1]=="1")
            {
                new stock().Show();
                this.Hide();

            }
            else if (BC.BCrypt.Verify(txtpassword.Text, user[3]) && user[1] == "2")
            {
                new voirproduit().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("L'identifiant ou le mot de passe saisi est incorrect, veuillez réessayer");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();

        }
    }
}
