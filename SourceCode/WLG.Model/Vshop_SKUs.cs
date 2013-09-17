//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_SKUs
    {
        private string m_SkuId;
        private int m_ProductId;
        private string m_SKU;
        private int m_Weight;
        private int m_Stock;
        private Double m_CostPrice;
        private Double m_SalePrice;

        public Vshop_SKUs()
        {
        }

        public string SkuId
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

        public int Weight
        {
            get{ return m_Weight; }
            set{ m_Weight = value; }
        }

        public int Stock
        {
            get{ return m_Stock; }
            set{ m_Stock = value; }
        }

        public Double CostPrice
        {
            get{ return m_CostPrice; }
            set{ m_CostPrice = value; }
        }

        public Double SalePrice
        {
            get{ return m_SalePrice; }
            set{ m_SalePrice = value; }
        }

    }
}

