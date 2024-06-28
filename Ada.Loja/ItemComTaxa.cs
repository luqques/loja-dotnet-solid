using Ada.Loja.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public abstract class ItemComTaxa : Item
    {
        protected ItemComTaxa(ECategoriaItem categoria, string descricao, decimal valor) : base(categoria, descricao, valor)
        {
        }

        public abstract decimal ObterTaxa();

        public decimal ObterValorTotalComTaxas()
        {
            return Valor * ObterTaxa();
        }
    }
}
