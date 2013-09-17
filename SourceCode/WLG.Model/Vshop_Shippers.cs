//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Shippers
    {
        private int m_ShipperId;
        private string m_ShipperName;
        private int m_RegionId;
        private string m_Address;
        private string m_CellPhone;
        private string m_TelPhone;
        private string m_ZipCode;
        private string m_Remark;
        private int m_ShopId;

        public Vshop_Shippers()
        {
        }

        public int ShipperId
        {
            get{ return m_ShipperId; }
            set{ m_ShipperId = value; }
        }

        public string ShipperName
        {
            get{ return m_ShipperName; }
            set{ m_ShipperName = value; }
        }

        public int RegionId
        {
            get{ return m_RegionId; }
            set{ m_RegionId = value; }
        }

        public string Address
        {
            get{ return m_Address; }
            set{ m_Address = value; }
        }

        public string CellPhone
        {
            get{ return m_CellPhone; }
            set{ m_CellPhone = value; }
        }

        public string TelPhone
        {
            get{ return m_TelPhone; }
            set{ m_TelPhone = value; }
        }

        public string ZipCode
        {
            get{ return m_ZipCode; }
            set{ m_ZipCode = value; }
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

