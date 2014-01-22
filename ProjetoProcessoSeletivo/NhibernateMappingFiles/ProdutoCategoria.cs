using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProcessoSeletivo.NhibernateMappingFiles
{
    public class ProdutoCategoria
    {
        public virtual Int64 idProdCat { get; set; }
        public virtual Int64 idProduto { get; set; }
        public virtual Int64 idCategoria { get; set; }
    }
}