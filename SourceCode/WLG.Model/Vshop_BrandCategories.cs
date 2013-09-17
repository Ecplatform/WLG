//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_BrandCategories
    {
        private int m_BrandId;
        private string m_BrandName;
        private string m_Logo;
        private string m_CompanyUrl;
        private string m_Description;
        private int m_DisplaySequence;
        private int m_ShopId;

        public Vshop_BrandCategories()
        {
        }

        public int BrandId
        {
            get{ return m_BrandId; }
            set{ m_BrandId = value; }
        }

        public string BrandName
        {
            get{ return m_BrandName; }
            set{ m_BrandName = value; }
        }

        public string Logo
        {
            get{ return m_Logo; }
            set{ m_Logo = value; }
        }

        public string CompanyUrl
        {
            get{ return m_CompanyUrl; }
            set{ m_CompanyUrl = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

