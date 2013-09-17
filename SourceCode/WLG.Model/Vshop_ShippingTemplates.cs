//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShippingTemplates
    {
        private int m_TemplateId;
        private string m_TemplateName;
        private int m_Weight;
        private Decimal m_Price;
        private int m_AddWeight;
        private Decimal m_AddPrice;

        public Vshop_ShippingTemplates()
        {
        }

        public int TemplateId
        {
            get{ return m_TemplateId; }
            set{ m_TemplateId = value; }
        }

        public string TemplateName
        {
            get{ return m_TemplateName; }
            set{ m_TemplateName = value; }
        }

        public int Weight
        {
            get{ return m_Weight; }
            set{ m_Weight = value; }
        }

        public Decimal Price
        {
            get{ return m_Price; }
            set{ m_Price = value; }
        }

        public int AddWeight
        {
            get{ return m_AddWeight; }
            set{ m_AddWeight = value; }
        }

        public Decimal AddPrice
        {
            get{ return m_AddPrice; }
            set{ m_AddPrice = value; }
        }

    }
}

