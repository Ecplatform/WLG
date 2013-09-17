//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Tags
    {
        private int m_TagId;
        private string m_TagName;
        private int m_ShopId;

        public Vshop_Tags()
        {
        }

        public int TagId
        {
            get{ return m_TagId; }
            set{ m_TagId = value; }
        }

        public string TagName
        {
            get{ return m_TagName; }
            set{ m_TagName = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

