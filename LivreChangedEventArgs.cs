using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLivre
{
    // classe permettant de transmettre les paramètres de l'événement
    public class LivreChangedEventArgs
    {
        decimal nouveauPrix;
        decimal ancienPrix;
        decimal nouveauPrixTtc;

        public LivreChangedEventArgs(decimal nouveauPrix, decimal ancienPrix, decimal nouveauPrixTtc)
        {
            this.nouveauPrix = nouveauPrix;
            this.ancienPrix = ancienPrix;
            this.nouveauPrixTtc = nouveauPrixTtc;
        }

        public decimal NouveauPrix { get { return nouveauPrix; } }
        public decimal AncienPrix { get { return ancienPrix; } }
        public decimal NouveauPrixTtc { get { return nouveauPrixTtc; } }
    }
}
