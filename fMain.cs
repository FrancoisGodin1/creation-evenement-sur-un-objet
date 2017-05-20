using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ModelLivre;
using System.Windows.Forms;


namespace tpEvenement
{
    public partial class fMain : Form
    {

        fLivre flivre;
        fHistorique fHistorique;
        public fMain()
        {
            InitializeComponent();
            btnNewLivre.Click += new EventHandler(btnNewLivre_Click);

        }

        void btnNewLivre_Click(object sender, EventArgs e)
        {
            Livre l = new Livre("new", 100, 10);
            flivre = new fLivre(l);
            fHistorique = new fHistorique(l);
        }
    }
}
