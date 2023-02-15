using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionBudget.Domain.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnionBudget
{
    public partial class UnionBudget : Form
    {
        public static List<string> listCategories = new List<string>();
        public static List<string> listSousCategories = new List<string>();
        public static List<Depense> listDesDespenses = new List<Depense>();
        public static List<Revenu> listeDesRevenu = new List<Revenu>();
        public static Double Reste = 0;
        public UnionBudget()
        {
            InitializeComponent();
        }
        private void GenererFichierCsv(List<Depense> les_depenses,List<Revenu> les_revenus,Double Reste)
        {
            // Définir le nom du fichier CSV à générer
            string fileName = "sommaire.csv";

            // Créer une chaîne contenant toutes les lignes CSV
            StringBuilder csv = new StringBuilder();
            csv.AppendLine(string.Join(",", DateTime.Now));
            csv.AppendLine("LISTE DES DEPENSES");
            foreach ( Depense depense in les_depenses)
            {
                csv.AppendLine(string.Join(",", depense.titre+" Montant:"+ depense.montant));
            }
            csv.AppendLine("LISTE DES REVENUS");
            foreach (Revenu revenu in les_revenus)
            {
                csv.AppendLine(string.Join(",", revenu.titre + " Montant:" + revenu.montant));
            }

            // Écrire la chaîne CSV dans le fichier
            File.WriteAllText(fileName, csv.ToString());

            // Afficher un message de confirmation
            MessageBox.Show("Le fichier CSV a été généré.");
        }

        private void UnionBudget_Load(object sender, EventArgs e)
        {
            RemplirCBoxCategorie();
            
        }

        private void RemplirCBoxSousCategorie()
        {
            if (cBoxCategories.Text == Convert.ToString((enumBudget)enumBudget.Revenu))
            {
                cBoxSousCategories.Items.Add(Convert.ToString((enumBudget)enumBudget.Salaire));

                foreach (string s_category in listSousCategories)
                {
                    cBoxSousCategories.Items.Add(s_category);
                    cBoxSousCategories.SelectedIndex = 0;
                }
            }
            else
            {
                //Ajout des sous catgorie si l'utilisateur choisi depense
                listSousCategories.Add(Convert.ToString((enumBudget)enumBudget.Logement));

                listSousCategories.Add(Convert.ToString((enumBudget)enumBudget.Telephone));
                listSousCategories.Add(Convert.ToString((enumBudget)enumBudget.Beaute));
                listSousCategories.Add(Convert.ToString((enumBudget)enumBudget.Chauffage));
                listSousCategories.Add(Convert.ToString((enumBudget)enumBudget.Sante));
                listSousCategories.Add(Convert.ToString((enumBudget)enumBudget.Autres));
                foreach (string s_category in listSousCategories)
                {
                    cBoxSousCategories.Items.Add(s_category);
                    cBoxSousCategories.SelectedIndex = 0;
                }
            }
        }

        private void RemplirCBoxCategorie()
        {
            //Remplir liste categorie
            listCategories.Add(Convert.ToString((enumBudget)enumBudget.Depense));
            listCategories.Add(Convert.ToString((enumBudget)enumBudget.Revenu));

            foreach (string category in listCategories)
            {
                cBoxCategories.Items.Add(category);
                cBoxCategories.SelectedIndex= 0;
            }


        }

        private void mnuNouveauDepense_Click(object sender, EventArgs e)
        {
            
        }
        private void mnuAjouterRevenu_Click(object sender, EventArgs e)
        {
            //Afficher_Panel();
        }

        private void cBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSousCategories.Clear();
            cBoxSousCategories.Items.Clear();
            RemplirCBoxSousCategorie();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtTitre.Text.Length <= 0)
            {
                txtTitre.Focus();
            }else if (numMontant.Text.Length <= 0)
            {
                numMontant.Text = "0";
                numMontant.Focus();
            }
            else
            {
                string titre = txtTitre.Text;
                string categorie = cBoxCategories.SelectedItem.ToString();
                double montant = Convert.ToDouble(numMontant.Text);
                if (cBoxCategories.Text == Convert.ToString((enumBudget)enumBudget.Depense))
                {
                    Depense nouveauDepense = new Depense(titre, categorie, montant);
                    listDesDespenses.Add(nouveauDepense);
                }
                else
                {
                    Revenu nouvelleRevenu = new Revenu(titre, categorie, montant);
                    listeDesRevenu.Add(nouvelleRevenu);
                }
                MettreaJourListeBox();
            }

           
        }

        private void MettreaJourListeBox()
        {
            listDepenses.Items.Clear();
            listRevenus.Items.Clear();

            double TotalDepenses = 0;
            double TotalRevenus = 0;
            foreach (Depense item in listDesDespenses)
            {
                listDepenses.Items.Add( item.titre + "--- (" + item.categorie + ") Montant : " + item.montant);
                TotalDepenses += item.montant;
            }
            foreach (Revenu item in listeDesRevenu)
            {
                listRevenus.Items.Add( item.titre + "--- (" + item.categorie + ") Montant : " + item.montant);
                TotalRevenus+= item.montant;
            }
            //calcul du total des depense
            lblTotalDepense.Text = "$ "+TotalDepenses.ToString();
            lblTotalRevenu.Text = "$ "+TotalRevenus.ToString();

            if(TotalDepenses> 0 && TotalRevenus > 0)
            {
                if (Convert.ToDouble(TotalRevenus) > Convert.ToDouble(TotalDepenses))
                    {
                        double reste = TotalRevenus - TotalDepenses;
                        lblResultat.Text = "Vous pouvez epargner ou depenser dans le loisir les " + reste + " qui reste";
                    }
                    else if (TotalDepenses > TotalRevenus)
                    {
                        double reste = TotalDepenses - TotalRevenus;
                        
                        lblResultat.Text = "Votre budget est plus elever a vos revenus. et la difference est " + reste;
                        lblResultat.BackColor = Color.Red;
                    }
                    else
                    {
                        lblResultat.Text = "Le total de votre revenu est egale aux totals des depenses ";
                    }
            }

            

            txtTitre.Text = "";
            numMontant.Text = "0";
            MettreAjourStatusbar("Liste a jour ...",false);
        }

        private void MettreAjourStatusbar(string message,bool isError)
        {
            statusBarFooter.Text = message;
            if (isError == true)
            {
                statusBarFooter.BackColor = Color.Red;
            }
            else
            {
                statusBarFooter.BackColor = Color.Green;
            }
            for (int i = 0; i <= 100; i++)
            {
                progBar.Value = i;
            }
        }

        private void btnSuppressionSelectionDepense_Click(object sender, EventArgs e)
        {
            if(listDepenses.SelectedIndex < 0)
            {
                MessageBox.Show("Vueillez selectionner d'abord la transaction a effacer","Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
                MettreAjourStatusbar("Error de suppresion", true);
            }
            else
            {
                listDesDespenses.Remove(listDesDespenses[listDepenses.SelectedIndex]);
                MettreaJourListeBox();
                MettreAjourStatusbar("Suppression apporter avec success", false);
                MettreAjourStatusbar("Mise a jour des donnees", false);

            }

        }

        private void btnSuppressionSelectionRevenu_Click(object sender, EventArgs e)
        {
            if (listRevenus.SelectedIndex < 0)
            {
                MessageBox.Show("Vueillez selectionner d'abord la transaction a effacer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listeDesRevenu.Remove(listeDesRevenu[listRevenus.SelectedIndex]);
                MettreaJourListeBox();
            }
        }

        private void numMontant_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(numMontant.Text, out int result))
            {
                MessageBox.Show("Veuillez entrer un nombre valide.","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            var Quitter = MessageBox.Show("Etes vous sure de voiloir quitter","Confirmations",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(Quitter == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnuReinitialiser_Click(object sender, EventArgs e)
        {

            listDesDespenses.Clear();
            listeDesRevenu.Clear();
            MettreaJourListeBox();
            statusBarFooter.Text = "Mise a jour ...";
            statusBarFooter.BackColor = Color.Red;

        }

        private void mnuImprimer_Click(object sender, EventArgs e)
        {
            GenererFichierCsv(listDesDespenses,listeDesRevenu,Reste);
        }
    }
}
