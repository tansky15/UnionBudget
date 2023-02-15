namespace UnionBudget
{
    partial class UnionBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnionBudget));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReinitialiser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNouvelleCategorie = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalRevenu = new System.Windows.Forms.Label();
            this.btnSuppressionSelectionRevenu = new System.Windows.Forms.Button();
            this.listRevenus = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalDepense = new System.Windows.Forms.Label();
            this.btnSuppressionSelectionDepense = new System.Windows.Forms.Button();
            this.listDepenses = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panFormAjout = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cBoxSousCategories = new System.Windows.Forms.ComboBox();
            this.numMontant = new System.Windows.Forms.TextBox();
            this.cBoxCategories = new System.Windows.Forms.ComboBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.panResultat = new System.Windows.Forms.Panel();
            this.lblResultat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panFormAjout.SuspendLayout();
            this.panResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuNouvelleCategorie});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "mnuStripHeader";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImprimer,
            this.mnuReinitialiser,
            this.mnuQuitter});
            this.mnuFichier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuFichier.Image = global::UnionBudget.Properties.Resources.copy_paste_document_file_1557;
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(102, 29);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuImprimer
            // 
            this.mnuImprimer.Image = global::UnionBudget.Properties.Resources.printer_78349;
            this.mnuImprimer.Name = "mnuImprimer";
            this.mnuImprimer.Size = new System.Drawing.Size(306, 34);
            this.mnuImprimer.Text = "Imprimer mes donees";
            this.mnuImprimer.Click += new System.EventHandler(this.mnuImprimer_Click);
            // 
            // mnuReinitialiser
            // 
            this.mnuReinitialiser.Image = global::UnionBudget.Properties.Resources.emblemsynchronizing_93485;
            this.mnuReinitialiser.Name = "mnuReinitialiser";
            this.mnuReinitialiser.Size = new System.Drawing.Size(306, 34);
            this.mnuReinitialiser.Text = "Reinisialier mes donnees";
            this.mnuReinitialiser.Click += new System.EventHandler(this.mnuReinitialiser_Click);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Image = global::UnionBudget.Properties.Resources.vcsconflicting_93497;
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(306, 34);
            this.mnuQuitter.Text = "Quitter";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // mnuNouvelleCategorie
            // 
            this.mnuNouvelleCategorie.ForeColor = System.Drawing.Color.White;
            this.mnuNouvelleCategorie.Image = global::UnionBudget.Properties.Resources.document_add_256_icon_icons_com_75994;
            this.mnuNouvelleCategorie.Name = "mnuNouvelleCategorie";
            this.mnuNouvelleCategorie.Size = new System.Drawing.Size(199, 29);
            this.mnuNouvelleCategorie.Text = "Nouvelle categorie";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.lblTotalRevenu);
            this.panel1.Controls.Add(this.btnSuppressionSelectionRevenu);
            this.panel1.Controls.Add(this.listRevenus);
            this.panel1.Location = new System.Drawing.Point(891, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 635);
            this.panel1.TabIndex = 3;
            // 
            // lblTotalRevenu
            // 
            this.lblTotalRevenu.AutoSize = true;
            this.lblTotalRevenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenu.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenu.Location = new System.Drawing.Point(59, 597);
            this.lblTotalRevenu.Name = "lblTotalRevenu";
            this.lblTotalRevenu.Size = new System.Drawing.Size(0, 29);
            this.lblTotalRevenu.TabIndex = 4;
            // 
            // btnSuppressionSelectionRevenu
            // 
            this.btnSuppressionSelectionRevenu.Image = global::UnionBudget.Properties.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361;
            this.btnSuppressionSelectionRevenu.Location = new System.Drawing.Point(410, 575);
            this.btnSuppressionSelectionRevenu.Name = "btnSuppressionSelectionRevenu";
            this.btnSuppressionSelectionRevenu.Size = new System.Drawing.Size(52, 57);
            this.btnSuppressionSelectionRevenu.TabIndex = 3;
            this.btnSuppressionSelectionRevenu.UseVisualStyleBackColor = true;
            this.btnSuppressionSelectionRevenu.Click += new System.EventHandler(this.btnSuppressionSelectionRevenu_Click);
            // 
            // listRevenus
            // 
            this.listRevenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.listRevenus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listRevenus.FormattingEnabled = true;
            this.listRevenus.ItemHeight = 20;
            this.listRevenus.Location = new System.Drawing.Point(4, 5);
            this.listRevenus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listRevenus.Name = "listRevenus";
            this.listRevenus.Size = new System.Drawing.Size(458, 562);
            this.listRevenus.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.lblTotalDepense);
            this.panel2.Controls.Add(this.btnSuppressionSelectionDepense);
            this.panel2.Controls.Add(this.listDepenses);
            this.panel2.Location = new System.Drawing.Point(414, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 635);
            this.panel2.TabIndex = 4;
            // 
            // lblTotalDepense
            // 
            this.lblTotalDepense.AutoSize = true;
            this.lblTotalDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepense.ForeColor = System.Drawing.Color.White;
            this.lblTotalDepense.Location = new System.Drawing.Point(83, 590);
            this.lblTotalDepense.Name = "lblTotalDepense";
            this.lblTotalDepense.Size = new System.Drawing.Size(0, 29);
            this.lblTotalDepense.TabIndex = 3;
            // 
            // btnSuppressionSelectionDepense
            // 
            this.btnSuppressionSelectionDepense.Image = global::UnionBudget.Properties.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361;
            this.btnSuppressionSelectionDepense.Location = new System.Drawing.Point(410, 575);
            this.btnSuppressionSelectionDepense.Name = "btnSuppressionSelectionDepense";
            this.btnSuppressionSelectionDepense.Size = new System.Drawing.Size(52, 57);
            this.btnSuppressionSelectionDepense.TabIndex = 2;
            this.btnSuppressionSelectionDepense.UseVisualStyleBackColor = true;
            this.btnSuppressionSelectionDepense.Click += new System.EventHandler(this.btnSuppressionSelectionDepense_Click);
            // 
            // listDepenses
            // 
            this.listDepenses.BackColor = System.Drawing.Color.MistyRose;
            this.listDepenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDepenses.FormattingEnabled = true;
            this.listDepenses.ItemHeight = 20;
            this.listDepenses.Location = new System.Drawing.Point(4, 5);
            this.listDepenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listDepenses.Name = "listDepenses";
            this.listDepenses.Size = new System.Drawing.Size(458, 562);
            this.listDepenses.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarFooter,
            this.progBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 793);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1376, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBarFooter
            // 
            this.statusBarFooter.Name = "statusBarFooter";
            this.statusBarFooter.Size = new System.Drawing.Size(24, 25);
            this.statusBarFooter.Text = "...";
            // 
            // progBar
            // 
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(150, 24);
            // 
            // panFormAjout
            // 
            this.panFormAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.panFormAjout.Controls.Add(this.label4);
            this.panFormAjout.Controls.Add(this.label3);
            this.panFormAjout.Controls.Add(this.label2);
            this.panFormAjout.Controls.Add(this.label1);
            this.panFormAjout.Controls.Add(this.btnAjouter);
            this.panFormAjout.Controls.Add(this.cBoxSousCategories);
            this.panFormAjout.Controls.Add(this.numMontant);
            this.panFormAjout.Controls.Add(this.cBoxCategories);
            this.panFormAjout.Controls.Add(this.txtTitre);
            this.panFormAjout.Location = new System.Drawing.Point(18, 83);
            this.panFormAjout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panFormAjout.Name = "panFormAjout";
            this.panFormAjout.Size = new System.Drawing.Size(392, 635);
            this.panFormAjout.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Montant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sous-Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titre";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(33, 522);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(328, 46);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cBoxSousCategories
            // 
            this.cBoxSousCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSousCategories.FormattingEnabled = true;
            this.cBoxSousCategories.Location = new System.Drawing.Point(32, 363);
            this.cBoxSousCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxSousCategories.Name = "cBoxSousCategories";
            this.cBoxSousCategories.Size = new System.Drawing.Size(326, 37);
            this.cBoxSousCategories.TabIndex = 3;
            // 
            // numMontant
            // 
            this.numMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMontant.Location = new System.Drawing.Point(33, 446);
            this.numMontant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMontant.Name = "numMontant";
            this.numMontant.Size = new System.Drawing.Size(326, 35);
            this.numMontant.TabIndex = 2;
            this.numMontant.Validating += new System.ComponentModel.CancelEventHandler(this.numMontant_Validating);
            // 
            // cBoxCategories
            // 
            this.cBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCategories.FormattingEnabled = true;
            this.cBoxCategories.Location = new System.Drawing.Point(32, 266);
            this.cBoxCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxCategories.Name = "cBoxCategories";
            this.cBoxCategories.Size = new System.Drawing.Size(326, 37);
            this.cBoxCategories.TabIndex = 1;
            this.cBoxCategories.SelectedIndexChanged += new System.EventHandler(this.cBoxCategories_SelectedIndexChanged);
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(32, 186);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(326, 35);
            this.txtTitre.TabIndex = 0;
            // 
            // panResultat
            // 
            this.panResultat.Controls.Add(this.lblResultat);
            this.panResultat.Location = new System.Drawing.Point(417, 727);
            this.panResultat.Name = "panResultat";
            this.panResultat.Size = new System.Drawing.Size(942, 42);
            this.panResultat.TabIndex = 7;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(29, 11);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 20);
            this.lblResultat.TabIndex = 0;
            // 
            // UnionBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1376, 825);
            this.Controls.Add(this.panResultat);
            this.Controls.Add(this.panFormAjout);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UnionBudget";
            this.Text = "Union Budget";
            this.Load += new System.EventHandler(this.UnionBudget_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panFormAjout.ResumeLayout(false);
            this.panFormAjout.PerformLayout();
            this.panResultat.ResumeLayout(false);
            this.panResultat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuImprimer;
        private System.Windows.Forms.ToolStripMenuItem mnuReinitialiser;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuNouvelleCategorie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listRevenus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarFooter;
        private System.Windows.Forms.ToolStripProgressBar progBar;
        private System.Windows.Forms.ListBox listDepenses;
        private System.Windows.Forms.Panel panFormAjout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cBoxSousCategories;
        private System.Windows.Forms.TextBox numMontant;
        private System.Windows.Forms.ComboBox cBoxCategories;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Button btnSuppressionSelectionRevenu;
        private System.Windows.Forms.Button btnSuppressionSelectionDepense;
        private System.Windows.Forms.Label lblTotalDepense;
        private System.Windows.Forms.Label lblTotalRevenu;
        private System.Windows.Forms.Panel panResultat;
        private System.Windows.Forms.Label lblResultat;
    }
}

