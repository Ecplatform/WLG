//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ProductTag
    {
        private int m_TagId;
        private int m_ProductId;

        public Vshop_ProductTag()
        {
        }

        public int TagId
        {
            get{ return m_TagId; }
            set{ m_TagId = value; }
        }

        public int ProductId
        {
            get{ return m_ProductId; }
            set{ m_ProductId = value; }
        }

    }
}

