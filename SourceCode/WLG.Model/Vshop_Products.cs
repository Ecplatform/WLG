//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Products
    {
        private int m_ProductId;
        private int m_CategoryId;
        private int m_TypeId;
        private int m_BrandId;
        private string m_ProductName;
        private string m_Unit;
        private Decimal m_MarketPrice;
        private string m_ShortDescription;
        private string m_Description;
        private int m_SaleStatus;
        private DateTime m_AddedDate;
        private int m_VisitCounts;
        private int m_SaleCounts;
        private int m_DisplaySequence;
        private string m_ImageUrl1;
        private string m_ImageUrl2;
        private string m_ImageUrl3;
        private string m_ThumbnailUrl;
        private int m_ShopId;

        public Vshop_Products()
        {
        }

        public int ProductId
        {
            get{ return m_ProductId; }
            set{ m_ProductId = value; }
        }

        public int CategoryId
        {
            get{ return m_CategoryId; }
            set{ m_CategoryId = value; }
        }

        public int TypeId
        {
            get{ return m_TypeId; }
            set{ m_TypeId = value; }
        }

        public int BrandId
        {
            get{ return m_BrandId; }
            set{ m_BrandId = value; }
        }

        public string ProductName
        {
            get{ return m_ProductName; }
            set{ m_ProductName = value; }
        }

        public string Unit
        {
            get{ return m_Unit; }
            set{ m_Unit = value; }
        }

        public Decimal MarketPrice
        {
            get{ return m_MarketPrice; }
            set{ m_MarketPrice = value; }
        }

        public string ShortDescription
        {
            get{ return m_ShortDescription; }
            set{ m_ShortDescription = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public int SaleStatus
        {
            get{ return m_SaleStatus; }
            set{ m_SaleStatus = value; }
        }

        public DateTime AddedDate
        {
            get{ return m_AddedDate; }
            set{ m_AddedDate = value; }
        }

        public int VisitCounts
        {
            get{ return m_VisitCounts; }
            set{ m_VisitCounts = value; }
        }

        public int SaleCounts
        {
            get{ return m_SaleCounts; }
            set{ m_SaleCounts = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

        public string ImageUrl1
        {
            get{ return m_ImageUrl1; }
            set{ m_ImageUrl1 = value; }
        }

        public string ImageUrl2
        {
            get{ return m_ImageUrl2; }
            set{ m_ImageUrl2 = value; }
        }

        public string ImageUrl3
        {
            get{ return m_ImageUrl3; }
            set{ m_ImageUrl3 = value; }
        }

        public string ThumbnailUrl
        {
            get{ return m_ThumbnailUrl; }
            set{ m_ThumbnailUrl = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

