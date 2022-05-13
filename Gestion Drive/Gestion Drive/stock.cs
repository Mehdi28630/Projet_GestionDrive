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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password='' ; database=projet2");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void stock_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            con.Open();
            dataGridView1.Show();
            dataGridView1.ColumnCount = 4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].Name = "Id produit";
            dataGridView1.Columns[1].Name = "Id Categorie";
            dataGridView1.Columns[2].Name = "Libelle";
            dataGridView1.Columns[3].Name = "Quantité";
            string commande = "select produit.ID_PRODUIT, categorie.ID_CATEGORIE, produit.LIBELLE, produit.QUANTITÉ from produit INNER JOIN categorie on produit.ID_CATEGORIE = categorie.ID_CATEGORIE";
            MySqlCommand Afficher = new MySqlCommand(commande, con);
            MySqlDataReader reader;
            reader = Afficher.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AjoutPrdt().Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            new Supprimer().Show();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            new Modifier().Show();
        }
    }
}
