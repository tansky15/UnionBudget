using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionBudget.Domain.Entities
{
    public  class Budget
    {
        public List<Depense> ListDesDepenses { get;set; }
        public void AjouterDepense(Depense Depense)
        {
            ListDesDepenses.Add(Depense);
        }
    }
}
