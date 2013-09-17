//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Buyer
    {
        private int m_BuyerId;
        private int m_UserId;
        private string m_Password;
        private string m_BuyerName;
        private string m_TelPhone;
        private string m_Email;

        public Vshop_Buyer()
        {
        }

        public int BuyerId
        {
            get{ return m_BuyerId; }
            set{ m_BuyerId = value; }
        }

        public int UserId
        {
            get{ return m_UserId; }
            set{ m_UserId = value; }
        }

        public string Password
        {
            get{ return m_Password; }
            set{ m_Password = value; }
        }

        public string BuyerName
        {
            get{ return m_BuyerName; }
            set{ m_BuyerName = value; }
        }

        public string TelPhone
        {
            get{ return m_TelPhone; }
            set{ m_TelPhone = value; }
        }

        public string Email
        {
            get{ return m_Email; }
            set{ m_Email = value; }
        }

    }
}

