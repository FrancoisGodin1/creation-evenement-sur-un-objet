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
    public partial class fHistorique : Form
    {
        public fHistorique(Livre unLivre)
        {
            InitializeComponent();
            this.Show();
            unLivre.livreChanged += ChangementLivre;
        }

        void ChangementLivre(object sender, LivreChangedEventArgs e)
        {
            this.lbHistorique.Items.Add(e.AncienPrix);
        }
    }
}
