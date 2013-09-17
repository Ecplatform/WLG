//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_SKUItems
    {
        private string m_SkuId;
        private int m_AttributeId;
        private int m_ValueId;

        public Vshop_SKUItems()
        {
        }

        public string SkuId
        {
            get{ return m_SkuId; }
            set{ m_SkuId = value; }
        }

        public int AttributeId
        {
            get{ return m_AttributeId; }
            set{ m_AttributeId = value; }
        }

        public int ValueId
        {
            get{ return m_ValueId; }
            set{ m_ValueId = value; }
        }

    }
}

