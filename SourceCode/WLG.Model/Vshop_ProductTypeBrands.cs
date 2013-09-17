//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ProductTypeBrands
    {
        private int m_TypeId;
        private int m_BrandId;

        public Vshop_ProductTypeBrands()
        {
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

    }
}

