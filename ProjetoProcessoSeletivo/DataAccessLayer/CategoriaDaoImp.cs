using NHibernate;
using NHibernate.Criterion;
using ProjetoProcessoSeletivo.NhibernateMappingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProcessoSeletivo.DataAccessLayer
{
    public class CategoriaDaoImp : DaoProviderBase<Categoria, long>,
                                   ICategoriaDao
    {
        public List<string> GetProdutoCategoriaById(string id)
        {
            ICriteria ProdutoCategoriaSearchCriteria = base.CurrentNhibernateSession.CreateCriteria(typeof(Categoria));
            ProdutoCategoriaSearchCriteria.SetProjection(Projections.Distinct(Projections.Property("idcategoria")));
            var list = ProdutoCategoriaSearchCriteria.List();
            return list.Cast<string>().ToList();

        }

        public List<string> GetProdutoCategoriaAll()
        {
            ICriteria ProdutoCategoriaSearchCriteria = base.CurrentNhibernateSession.CreateCriteria(typeof(Categoria));
            ProdutoCategoriaSearchCriteria.SetProjection(Projections.Distinct(Projections.Property("idcategoria")));
            var list = ProdutoCategoriaSearchCriteria.List();
            return list.Cast<string>().ToList();

        }
    }
}