
namespace Etudiants
{
    partial class Form
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
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom1 = new System.Windows.Forms.TextBox();
            this.lbl_prenom1 = new System.Windows.Forms.Label();
            this.txtPrenom2 = new System.Windows.Forms.TextBox();
            this.lbl_prenom2 = new System.Windows.Forms.Label();
            this.txtNationalite = new System.Windows.Forms.TextBox();
            this.lbl_nationalite = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lbl_adresse = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.lbl_pays = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(37, 47);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Info;
            this.txtNom.Location = new System.Drawing.Point(91, 44);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // txtPrenom1
            // 
            this.txtPrenom1.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrenom1.Location = new System.Drawing.Point(91, 97);
            this.txtPrenom1.Name = "txtPrenom1";
            this.txtPrenom1.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom1.TabIndex = 5;
            this.txtPrenom1.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lbl_prenom1
            // 
            this.lbl_prenom1.AutoSize = true;
            this.lbl_prenom1.Location = new System.Drawing.Point(37, 104);
            this.lbl_prenom1.Name = "lbl_prenom1";
            this.lbl_prenom1.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom1.TabIndex = 4;
            this.lbl_prenom1.Text = "Prenom";
            // 
            // txtPrenom2
            // 
            this.txtPrenom2.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrenom2.Location = new System.Drawing.Point(91, 163);
            this.txtPrenom2.Name = "txtPrenom2";
            this.txtPrenom2.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom2.TabIndex = 7;
            this.txtPrenom2.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lbl_prenom2
            // 
            this.lbl_prenom2.AutoSize = true;
            this.lbl_prenom2.Location = new System.Drawing.Point(37, 170);
            this.lbl_prenom2.Name = "lbl_prenom2";
            this.lbl_prenom2.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom2.TabIndex = 6;
            this.lbl_prenom2.Text = "Prenom";
            // 
            // txtNationalite
            // 
            this.txtNationalite.BackColor = System.Drawing.SystemColors.Info;
            this.txtNationalite.Location = new System.Drawing.Point(298, 44);
            this.txtNationalite.Name = "txtNationalite";
            this.txtNationalite.Size = new System.Drawing.Size(100, 20);
            this.txtNationalite.TabIndex = 9;
            this.txtNationalite.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lbl_nationalite
            // 
            this.lbl_nationalite.AutoSize = true;
            this.lbl_nationalite.Location = new System.Drawing.Point(235, 51);
            this.lbl_nationalite.Name = "lbl_nationalite";
            this.lbl_nationalite.Size = new System.Drawing.Size(57, 13);
            this.lbl_nationalite.TabIndex = 8;
            this.lbl_nationalite.Text = "Nationalite";
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdresse.Location = new System.Drawing.Point(298, 101);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 11;
            this.txtAdresse.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lbl_adresse
            // 
            this.lbl_adresse.AutoSize = true;
            this.lbl_adresse.Location = new System.Drawing.Point(244, 108);
            this.lbl_adresse.Name = "lbl_adresse";
            this.lbl_adresse.Size = new System.Drawing.Size(45, 13);
            this.lbl_adresse.TabIndex = 10;
            this.lbl_adresse.Text = "Adresse";
            // 
            // txtVille
            // 
            this.txtVille.BackColor = System.Drawing.SystemColors.Info;
            this.txtVille.Location = new System.Drawing.Point(298, 163);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 13;
            this.txtVille.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(244, 170);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(26, 13);
            this.lbl_ville.TabIndex = 12;
            this.lbl_ville.Text = "Ville";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(217, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancel.Location = new System.Drawing.Point(337, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Info;
            this.txtAge.Location = new System.Drawing.Point(91, 225);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 18;
            this.txtAge.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(37, 232);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 17;
            this.lbl_age.Text = "Age";
            // 
            // txtPays
            // 
            this.txtPays.BackColor = System.Drawing.SystemColors.Info;
            this.txtPays.Location = new System.Drawing.Point(298, 225);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(100, 20);
            this.txtPays.TabIndex = 20;
            this.txtPays.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lbl_pays
            // 
            this.lbl_pays.AutoSize = true;
            this.lbl_pays.Location = new System.Drawing.Point(244, 232);
            this.lbl_pays.Name = "lbl_pays";
            this.lbl_pays.Size = new System.Drawing.Size(30, 13);
            this.lbl_pays.TabIndex = 19;
            this.lbl_pays.Text = "Pays";
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelephone.Location = new System.Drawing.Point(91, 282);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 22;
            this.txtTelephone.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telephone";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.Info;
            this.listView.Location = new System.Drawing.Point(443, 47);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(345, 375);
            this.listView.TabIndex = 23;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lbl_pays);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lbl_adresse);
            this.Controls.Add(this.txtNationalite);
            this.Controls.Add(this.lbl_nationalite);
            this.Controls.Add(this.txtPrenom2);
            this.Controls.Add(this.lbl_prenom2);
            this.Controls.Add(this.txtPrenom1);
            this.Controls.Add(this.lbl_prenom1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lbl_nom);
            this.Name = "Form";
            this.Text = "Informations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom1;
        private System.Windows.Forms.Label lbl_prenom1;
        private System.Windows.Forms.TextBox txtPrenom2;
        private System.Windows.Forms.Label lbl_prenom2;
        private System.Windows.Forms.TextBox txtNationalite;
        private System.Windows.Forms.Label lbl_nationalite;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lbl_adresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label lbl_pays;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView;
    }
}

