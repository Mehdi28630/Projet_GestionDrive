
namespace Gestion_Drive
{
    partial class Modifier
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
            this.BoxId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BoxQuantite = new System.Windows.Forms.TextBox();
            this.BoxLibelle = new System.Windows.Forms.TextBox();
            this.BoxCategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxId
            // 
            this.BoxId.Location = new System.Drawing.Point(64, 177);
            this.BoxId.Name = "BoxId";
            this.BoxId.Size = new System.Drawing.Size(100, 26);
            this.BoxId.TabIndex = 0;
            this.BoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxQuantite
            // 
            this.BoxQuantite.Location = new System.Drawing.Point(460, 177);
            this.BoxQuantite.Name = "BoxQuantite";
            this.BoxQuantite.Size = new System.Drawing.Size(100, 26);
            this.BoxQuantite.TabIndex = 2;
            // 
            // BoxLibelle
            // 
            this.BoxLibelle.Location = new System.Drawing.Point(262, 177);
            this.BoxLibelle.Name = "BoxLibelle";
            this.BoxLibelle.Size = new System.Drawing.Size(100, 26);
            this.BoxLibelle.TabIndex = 3;
            // 
            // BoxCategorie
            // 
            this.BoxCategorie.FormattingEnabled = true;
            this.BoxCategorie.Items.AddRange(new object[] {
            "Conserves",
            "Apéritifs",
            "Produits Ménagers",
            "Biscuits"});
            this.BoxCategorie.Location = new System.Drawing.Point(607, 175);
            this.BoxCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxCategorie.Name = "BoxCategorie";
            this.BoxCategorie.Size = new System.Drawing.Size(180, 28);
            this.BoxCategorie.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID du produit à modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Catégorie";
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxCategorie);
            this.Controls.Add(this.BoxLibelle);
            this.Controls.Add(this.BoxQuantite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxId);
            this.Name = "Modifier";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BoxQuantite;
        private System.Windows.Forms.TextBox BoxLibelle;
        private System.Windows.Forms.ComboBox BoxCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}