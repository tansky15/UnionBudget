using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionBudget.Domain.Entities
{
    public class Depense:Transaction
    {
        public Depense(string titre, string categorie, double montant)
        {
            this.titre = titre;
            this.categorie = categorie;
            this.montant = montant;
        }
    }
}
