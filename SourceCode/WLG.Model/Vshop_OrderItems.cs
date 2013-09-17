//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_OrderItems
    {
        private string m_OrderId;
        private int m_SkuId;
        private int m_ProductId;
        private string m_SKU;
        private int m_Quantity;
        private int m_ShipmentQuantity;
        private Decimal m_CostPrice;
        private Decimal m_ItemListPrice;
        private Decimal m_ItemAdjustedPrice;
        private string m_ItemDescription;
        private string m_ThumbnailsUrl;
        private int m_Weight;

        public Vshop_OrderItems()
        {
        }

        public string OrderId
        {
            get{ return m_OrderId; }
            set{ m_OrderId = value; }
        }

        public int SkuId
        {
            get{ return m_SkuId; }
            set{ m_SkuId = value; }
        }

        public int ProductId
        {
            get{ return m_ProductId; }
            set{ m_ProductId = value; }
        }

        public string SKU
        {
            get{ return m_SKU; }
            set{ m_SKU = value; }
        }

        public int Quantity
        {
            get{ return m_Quantity; }
            set{ m_Quantity = value; }
        }

        public int ShipmentQuantity
        {
            get{ return m_ShipmentQuantity; }
            set{ m_ShipmentQuantity = value; }
        }

        public Decimal CostPrice
        {
            get{ return m_CostPrice; }
            set{ m_CostPrice = value; }
        }

        public Decimal ItemListPrice
        {
            get{ return m_ItemListPrice; }
            set{ m_ItemListPrice = value; }
        }

        public Decimal ItemAdjustedPrice
        {
            get{ return m_ItemAdjustedPrice; }
            set{ m_ItemAdjustedPrice = value; }
        }

        public string ItemDescription
        {
            get{ return m_ItemDescription; }
            set{ m_ItemDescription = value; }
        }

        public string ThumbnailsUrl
        {
            get{ return m_ThumbnailsUrl; }
            set{ m_ThumbnailsUrl = value; }
        }

        public int Weight
        {
            get{ return m_Weight; }
            set{ m_Weight = value; }
        }

    }
}

