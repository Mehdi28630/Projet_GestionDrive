
namespace Gestion_Drive
{
    partial class AjoutPrdt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BoxLibelle = new System.Windows.Forms.TextBox();
            this.BoxQuantite = new System.Windows.Forms.TextBox();
            this.BoxCategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter le produit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxLibelle
            // 
            this.BoxLibelle.Location = new System.Drawing.Point(131, 260);
            this.BoxLibelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxLibelle.Name = "BoxLibelle";
            this.BoxLibelle.Size = new System.Drawing.Size(148, 26);
            this.BoxLibelle.TabIndex = 1;
            // 
            // BoxQuantite
            // 
            this.BoxQuantite.Location = new System.Drawing.Point(363, 260);
            this.BoxQuantite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxQuantite.Name = "BoxQuantite";
            this.BoxQuantite.Size = new System.Drawing.Size(148, 26);
            this.BoxQuantite.TabIndex = 2;
            // 
            // BoxCategorie
            // 
            this.BoxCategorie.FormattingEnabled = true;
            this.BoxCategorie.Items.AddRange(new object[] {
            "Conserves",
            "Apéritifs",
            "Produits Ménagers",
            "Biscuits"});
            this.BoxCategorie.Location = new System.Drawing.Point(630, 258);
            this.BoxCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxCategorie.Name = "BoxCategorie";
            this.BoxCategorie.Size = new System.Drawing.Size(180, 28);
            this.BoxCategorie.TabIndex = 3;
            this.BoxCategorie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categorie";
            // 
            // AjoutPrdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxCategorie);
            this.Controls.Add(this.BoxQuantite);
            this.Controls.Add(this.BoxLibelle);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AjoutPrdt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BoxLibelle;
        private System.Windows.Forms.TextBox BoxQuantite;
        private System.Windows.Forms.ComboBox BoxCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}