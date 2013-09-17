//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_UserShop
    {
        private int m_ShopId;
        private int m_UserId;

        public Vshop_UserShop()
        {
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

        public int UserId
        {
            get{ return m_UserId; }
            set{ m_UserId = value; }
        }

    }
}

