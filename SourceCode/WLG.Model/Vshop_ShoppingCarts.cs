//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShoppingCarts
    {
        private int m_BuyerId;
        private int m_ProductId;
        private int m_SkuId;
        private int m_Quantity;
        private DateTime m_AddTime;

        public Vshop_ShoppingCarts()
        {
        }

        public int BuyerId
        {
            get{ return m_BuyerId; }
            set{ m_BuyerId = value; }
        }

        public int ProductId
        {
            get{ return m_ProductId; }
            set{ m_ProductId = value; }
        }

        public int SkuId
        {
            get{ return m_SkuId; }
            set{ m_SkuId = value; }
        }

        public int Quantity
        {
            get{ return m_Quantity; }
            set{ m_Quantity = value; }
        }

        public DateTime AddTime
        {
            get{ return m_AddTime; }
            set{ m_AddTime = value; }
        }

    }
}

