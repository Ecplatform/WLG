//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShippingTypes
    {
        private int m_ModeId;
        private int m_ShopId;
        private int m_TemplateId;
        private string m_Name;
        private string m_Description;
        private int m_DisplaySequence;
        private string m_ExpressCompanyCode;

        public Vshop_ShippingTypes()
        {
        }

        public int ModeId
        {
            get{ return m_ModeId; }
            set{ m_ModeId = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

        public int TemplateId
        {
            get{ return m_TemplateId; }
            set{ m_TemplateId = value; }
        }

        public string Name
        {
            get{ return m_Name; }
            set{ m_Name = value; }
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

        public string ExpressCompanyCode
        {
            get{ return m_ExpressCompanyCode; }
            set{ m_ExpressCompanyCode = value; }
        }

    }
}

