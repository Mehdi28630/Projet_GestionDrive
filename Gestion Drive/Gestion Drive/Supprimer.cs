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

namespace Gestion_Drive
{
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password='' ; database=projet2");

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                con.Open();
                string supprimerproduit = "delete produit from produit where ID_PRODUIT = '" + textBox1.Text + "';";
                MySqlCommand Delete = new MySqlCommand(supprimerproduit, con);
                Delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Les données ont bien été supprimées de la base de données.");
                this.Close();

            }
        }
    }
}
