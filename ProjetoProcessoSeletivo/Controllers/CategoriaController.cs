using ProjetoProcessoSeletivo.NhibernateMappingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProcessoSeletivo.Controllers
{
    public class CategoriaController : Controller
    {
        ProjetoProcessoSeletivo.DataAccessLayer.ICategoriaDao _categoriaDao;

        public CategoriaController()
        {
            _categoriaDao = new ProjetoProcessoSeletivo.DataAccessLayer.CategoriaDaoImp();
        }

        public JsonResult GeProdutoCategoriaId(String Id)
        {
            List<string> produtoCategoriasId = _categoriaDao.GetProdutoCategoriaById(Id);
            return Json(produtoCategoriasId, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Index()
        {
            var categorias = _categoriaDao.GetProdutoCategoriaAll();
            var categoriaListItem = (from Categoria in categorias
                                     select new SelectListItem
                                     {
                                         Text = Categoria,
                                         Value = Categoria
                                     }).ToList();
            return View(categoriaListItem);
        }

   }
}