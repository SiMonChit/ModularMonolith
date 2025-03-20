using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Modules.Domain.Entities
{
    public sealed class Items
    {
        public int ItemId { get; private set; }
        public string ItemCode { get; private set; }
        public string ItemName { get; private set; }
        public int? Qty { get; private set; }
        public int SellPrice { get; private set; }
        public int? PurchasePrice { get; private set; }
        public bool? IsInventory { get; private set; }
        public bool? IsActive { get; private set; }
        public short? ShopId { get; private set; }

        // Constructor
        public Items(string itemCode, string itemName, int sellPrice, bool? isInventory, short? shopId)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            Qty = 0;
            SellPrice = sellPrice;
            PurchasePrice = 0;
            IsInventory = isInventory;
            IsActive = true;
            ShopId = shopId;
        }

        // Update method
        public void Update(string itemCode, string itemName, int sellPrice, int? purchasePrice, bool? isInventory, short? shopId)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            SellPrice = sellPrice;
            PurchasePrice = purchasePrice;
            IsInventory = isInventory;
            ShopId = shopId;
        }
    }

}
