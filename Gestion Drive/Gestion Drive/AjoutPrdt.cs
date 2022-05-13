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
    public partial class AjoutPrdt : Form
    {
        public AjoutPrdt()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password='' ; database=projet2");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int IdCategorie = 1;
            
            switch (BoxCategorie.SelectedItem)
            {
                case "Conserves": IdCategorie = 1;
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

            string ajout = "insert into produit (Libelle, Quantité, ID_CATEGORIE) values ('" + BoxLibelle.Text + "', '" + BoxQuantite.Text +"', '" + IdCategorie +"');" ;
            MySqlCommand Ajouter = new MySqlCommand(ajout, con);
            Ajouter.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Les données ont bien été envoyées à la base de données.");
            BoxLibelle.Clear();
            BoxQuantite.Clear();
            this.Close();
            new stock().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
