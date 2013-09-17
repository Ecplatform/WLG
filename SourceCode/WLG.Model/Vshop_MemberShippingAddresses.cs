//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_BuyerShippingAddresses
    {
        private int m_ShippingId;
        private int m_RegionId;
        private int m_BuyerId;
        private string m_Adderss;
        private string m_ZipCode;
        private string m_TelPhone;
        private int m_IsDefault;

        public Vshop_BuyerShippingAddresses()
        {
        }

        public int ShippingId
        {
            get{ return m_ShippingId; }
            set{ m_ShippingId = value; }
        }

        public int RegionId
        {
            get{ return m_RegionId; }
            set{ m_RegionId = value; }
        }

        public int BuyerId
        {
            get{ return m_BuyerId; }
            set{ m_BuyerId = value; }
        }

        public string Adderss
        {
            get{ return m_Adderss; }
            set{ m_Adderss = value; }
        }

        public string ZipCode
        {
            get{ return m_ZipCode; }
            set{ m_ZipCode = value; }
        }

        public string TelPhone
        {
            get{ return m_TelPhone; }
            set{ m_TelPhone = value; }
        }

        public int IsDefault
        {
            get{ return m_IsDefault; }
            set{ m_IsDefault = value; }
        }

    }
}

