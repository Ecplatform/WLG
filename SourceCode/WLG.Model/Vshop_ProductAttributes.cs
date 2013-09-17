//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ProductAttributes
    {
        private int m_ProductId;
        private int m_AttributeId;
        private int m_ValueId;

        public Vshop_ProductAttributes()
        {
        }

        public int ProductId
        {
            get{ return m_ProductId; }
            set{ m_ProductId = value; }
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

