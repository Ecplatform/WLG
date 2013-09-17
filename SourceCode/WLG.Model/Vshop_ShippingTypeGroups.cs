//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShippingTypeGroups
    {
        private int m_GroupId;
        private int m_TemplateId;
        private Decimal m_Price;
        private Decimal m_AddPrice;

        public Vshop_ShippingTypeGroups()
        {
        }

        public int GroupId
        {
            get{ return m_GroupId; }
            set{ m_GroupId = value; }
        }

        public int TemplateId
        {
            get{ return m_TemplateId; }
            set{ m_TemplateId = value; }
        }

        public Decimal Price
        {
            get{ return m_Price; }
            set{ m_Price = value; }
        }

        public Decimal AddPrice
        {
            get{ return m_AddPrice; }
            set{ m_AddPrice = value; }
        }

    }
}

