using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste.Models;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult BuscarPesoItens(/*int mov_malote_englobador_id, int tp_movimento, int controle_id*/)
        {
            List<ItemModel> lstItemModel = new List<ItemModel>();
            List<PesoItemModel> lstPesoItens = new List<PesoItemModel>();

            #region Itens
            lstItemModel.Add(new ItemModel(1, "ITEM1"));
            lstItemModel.Add(new ItemModel(1, "ITEM1"));
            lstItemModel.Add(new ItemModel(1, "ITEM1"));
            lstItemModel.Add(new ItemModel(1, "ITEM1"));
            lstItemModel.Add(new ItemModel(1, "ITEM1"));
            lstItemModel.Add(new ItemModel(2, "ITEM2"));
            lstItemModel.Add(new ItemModel(2, "ITEM2"));
            lstItemModel.Add(new ItemModel(2, "ITEM2"));
            lstItemModel.Add(new ItemModel(3, "ITEM3"));
            #endregion

            #region Peso Itens
            lstPesoItens.Add(new PesoItemModel(1, 2.5));
            lstPesoItens.Add(new PesoItemModel(1, 1.2));
            lstPesoItens.Add(new PesoItemModel(1, 0.3));
            lstPesoItens.Add(new PesoItemModel(1, 3.3));
            lstPesoItens.Add(new PesoItemModel(1, 1.8));
            lstPesoItens.Add(new PesoItemModel(2, 1.1));
            lstPesoItens.Add(new PesoItemModel(2, 2.3));
            lstPesoItens.Add(new PesoItemModel(2, null));
            lstPesoItens.Add(new PesoItemModel(3, 0));
            #endregion

            foreach(var item in lstItemModel)
            {
                item.Peso = lstPesoItens.Where(x => x.ItemId == item.ItemId).Sum(x => x.PesoItem);
            }

            return PartialView("PaginaTeste", lstItemModel);
        }
    }
}