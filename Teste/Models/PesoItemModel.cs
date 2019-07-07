using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.Models
{
    public class PesoItemModel
    {
        private int itemId;
        private double? pesoItem;

        public PesoItemModel()
        {

        }

        public PesoItemModel(int itemId, double? pesoItem)
        {
            this.ItemId = itemId;
            this.PesoItem = pesoItem;
        }

        public int ItemId { get => itemId; set => itemId = value; }
        public double? PesoItem { get => pesoItem; set => pesoItem = value; }
    }
}