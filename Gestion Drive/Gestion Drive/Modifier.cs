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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password='' ; database=projet2");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int IdCategorie = 1;

            switch (BoxCategorie.SelectedItem)
            {
                case "Conserves":
                    IdCategorie = 1;
                    break;
                case "Apéritifs":
                    IdCategorie = 2;
                    break;
                case "Produits Ménagers":
                    IdCategorie = 3;
                    break;
                case "Biscuits":
                    IdCategorie = 4;
                    break;
            }
            string modifier = "UPDATE produit SET LIBELLE = '"+ BoxLibelle.Text + "', QUANTITÉ = '"+ BoxQuantite.Text +"', ID_CATEGORIE = '"+ IdCategorie +"' WHERE ID_PRODUIT ='" + BoxId.Text +"' ";
                MySqlCommand Delete = new MySqlCommand(modifier, con);
                Delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Le produit a été modifié dans la base de données.");
                this.Close();
        }
    }
}
