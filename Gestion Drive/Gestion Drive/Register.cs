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
using BC = BCrypt.Net;

namespace Gestion_Drive
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password='' ; database=projet2");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        private void btnenregistrement_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || txtconfirmpassword.Text == "")
            {
                MessageBox.Show("Les champs identifiant et/ou mot de passe sont vides", "L'enregistrement a échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtpassword.Text == txtconfirmpassword.Text)
            {
                con.Open();
                string hashedPassword = BC.BCrypt.HashPassword(txtpassword.Text);
                string register = "INSERT INTO user (identifiant, motdepasse, id_role) VALUES ('" + txtusername.Text + "', '" + hashedPassword + "', 2)";
                cmd = new MySqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtusername.Text = "";
                txtpassword.Text = "";
                txtconfirmpassword.Text = "";

                MessageBox.Show("Votre compte a bien été créé", "Enregistrement confirmé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Le mot de passe ne correspond pas, Reessayez", "L'enregistrement a échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtconfirmpassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void checkboxpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtconfirmpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtconfirmpassword.PasswordChar = '•';
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
