using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.Models
{
    public class ItemModel
    {
        private int itemId;
        private string itemNome;
        private double? peso;

        public ItemModel()
        {

        }

        public ItemModel(int itemId, string itemNome)
        {
            this.ItemId = itemId;
            this.ItemNome = itemNome;
        }

        public int ItemId { get => itemId; set => itemId = value; }
        public string ItemNome { get => itemNome; set => itemNome = value; }
        public double? Peso { get => peso; set => peso = value; }
    }
}