//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ProductTypes
    {
        private int m_TypeId;
        private string m_TypeName;
        private string m_Remark;
        private int m_ShopId;

        public Vshop_ProductTypes()
        {
        }

        public int TypeId
        {
            get{ return m_TypeId; }
            set{ m_TypeId = value; }
        }

        public string TypeName
        {
            get{ return m_TypeName; }
            set{ m_TypeName = value; }
        }

        public string Remark
        {
            get{ return m_Remark; }
            set{ m_Remark = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

