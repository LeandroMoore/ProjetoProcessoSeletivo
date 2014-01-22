using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoProcessoSeletivo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjetoProcessoSeletivo
{
    class UnitTestListaCategoriaById
    {
        public void GeProdutoByCategoriaById()
        {
            var CategoriaController = new CategoriaController();
            var retorno = CategoriaController.Index();
            Assert.AreEqual(1, retorno);

        }
    }
}
