//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShippingRegions
    {
        private int m_TemplateId;
        private int m_GroupId;
        private int m_RegionId;

        public Vshop_ShippingRegions()
        {
        }

        public int TemplateId
        {
            get{ return m_TemplateId; }
            set{ m_TemplateId = value; }
        }

        public int GroupId
        {
            get{ return m_GroupId; }
            set{ m_GroupId = value; }
        }

        public int RegionId
        {
            get{ return m_RegionId; }
            set{ m_RegionId = value; }
        }

    }
}

