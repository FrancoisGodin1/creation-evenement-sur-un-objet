using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModelLivre;

namespace tpEvenement
{
    public partial class fLivre : Form
    { 
        Livre livre;

        public fLivre(Livre l)
        {
            InitializeComponent();
            this.Show();
            this.tbPrix.Text = l.PrixHt.ToString();
            this.tbTitre.Text = l.ToString();
            this.tbPrixTtc.Text = l.PrixTtc.ToString();
            this.livre = l;
            this.livre.livreChanged += ChangementLivre;
            btnModifierPrix.Click += new EventHandler(btnModifierPrix_Click);
            btnHausse.Click += new EventHandler(btnHausse_Click);
        }

        void btnHausse_Click(object sender, EventArgs e)
        {
            this.livre.HausseAnnuelle();
        }

        void btnModifierPrix_Click(object sender, EventArgs e)
        {
            this.livre.PrixHt = Convert.ToDecimal(tbPrix.Text);
        }

        void ChangementLivre(object sender, LivreChangedEventArgs e)
        {
            this.tbPrix.Text = e.NouveauPrix.ToString();
            this.tbPrixTtc.Text = e.NouveauPrixTtc.ToString();
        }      
    }
}
