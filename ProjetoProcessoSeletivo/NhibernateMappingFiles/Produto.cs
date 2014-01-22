using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProcessoSeletivo.NhibernateMappingFiles
{
    public class Produto
    {
        public virtual Int64 idProduto { get; set; }
        public virtual string DescricaoProduto { get; set; }
        public virtual decimal Preco { get; set; }
    }
}