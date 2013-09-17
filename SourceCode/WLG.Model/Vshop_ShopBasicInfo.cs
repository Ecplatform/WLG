//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShopBasicInfo
    {
        private int m_ShopId;
        private string m_ShopName;
        private string m_ShopLogo;
        private string m_Description;
        private int m_ThemeId;
        private int m_IsApproved;
        private DateTime m_PassDate;
        private DateTime m_OpenDate;
        private DateTime m_DueDate;
        private DateTime m_CreateDate;
        private string m_CanUseTheme;
        private Decimal m_ShopFee;

        public Vshop_ShopBasicInfo()
        {
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

        public string ShopName
        {
            get{ return m_ShopName; }
            set{ m_ShopName = value; }
        }

        public string ShopLogo
        {
            get{ return m_ShopLogo; }
            set{ m_ShopLogo = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public int ThemeId
        {
            get{ return m_ThemeId; }
            set{ m_ThemeId = value; }
        }

        public int IsApproved
        {
            get{ return m_IsApproved; }
            set{ m_IsApproved = value; }
        }

        public DateTime PassDate
        {
            get{ return m_PassDate; }
            set{ m_PassDate = value; }
        }

        public DateTime OpenDate
        {
            get{ return m_OpenDate; }
            set{ m_OpenDate = value; }
        }

        public DateTime DueDate
        {
            get{ return m_DueDate; }
            set{ m_DueDate = value; }
        }

        public DateTime CreateDate
        {
            get{ return m_CreateDate; }
            set{ m_CreateDate = value; }
        }

        public string CanUseTheme
        {
            get{ return m_CanUseTheme; }
            set{ m_CanUseTheme = value; }
        }

        public Decimal ShopFee
        {
            get{ return m_ShopFee; }
            set{ m_ShopFee = value; }
        }

    }
}

