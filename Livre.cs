using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ModelLivre
{
    //déclaration d'un délégué et son prototype pour stocker toutes les méthodes abonnées à notre événement
    public delegate void LivreChangedPrototype(object sender,LivreChangedEventArgs e);

    public class Livre
    {
         string titre;
        decimal prixHt;
        decimal tauxTva;
        public event LivreChangedPrototype livreChanged; // déclaration de l'événement 

        public Livre(string titre, decimal prix, decimal tauxTva)
        {
            this.titre = titre;
            this.prixHt = prix;
            this.tauxTva = tauxTva;
        }

        /// <summary>
        /// déclanche l'appel du délégué qui va invoquer toutes les méthodes abonnées
        /// </summary>
        /// <param name="ancienPrix"></param>
        protected void OnChangementLivre(decimal ancienPrix)
        {
            this.livreChanged(this, new LivreChangedEventArgs(this.prixHt,ancienPrix,this.PrixTtc)); 
        }

        public decimal PrixHt
        {
            get { return prixHt; }
            set 
            {
                decimal ancienPrix;
                if (this.prixHt != value)
                {
                    ancienPrix = this.prixHt;
                    this.prixHt = value;
                    OnChangementLivre(ancienPrix);
                }
            }
        }

        public void HausseAnnuelle()
        {  
            this.PrixHt = prixHt * (decimal)1.1; 
        }

        public decimal PrixTtc { get { return (1 + this.tauxTva / 100) * this.prixHt; } }

        public override string ToString()
        {
            return this.titre;
        }
    }
}
