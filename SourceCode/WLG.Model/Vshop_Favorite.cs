//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Favorite
    {
        private int m_ProductId;
        private int m_BuyerId;
        private string m_Tags;
        private string m_Remark;

        public Vshop_Favorite()
        {
        }

        public int ProductId
        {
            get{ return m_ProductId; }
            set{ m_ProductId = value; }
        }

        public int BuyerId
        {
            get{ return m_BuyerId; }
            set{ m_BuyerId = value; }
        }

        public string Tags
        {
            get{ return m_Tags; }
            set{ m_Tags = value; }
        }

        public string Remark
        {
            get{ return m_Remark; }
            set{ m_Remark = value; }
        }

    }
}

