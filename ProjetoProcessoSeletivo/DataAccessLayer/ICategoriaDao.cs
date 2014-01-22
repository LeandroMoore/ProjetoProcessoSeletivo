using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProcessoSeletivo.DataAccessLayer
{
    public interface ICategoriaDao
    {
        List<string> GetProdutoCategoriaById(string id);
        List<string> GetProdutoCategoriaAll();
    }
}
