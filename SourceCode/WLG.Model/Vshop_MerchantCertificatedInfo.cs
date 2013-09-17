//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_MerchantCertificatedInfo
    {
        private int m_MerchantId;
        private int m_EnterpriseType;
        private string m_EnterpriseName;
        private string m_ShopKeeper;
        private string m_ShopName;
        private string m_IdCard;
        private string m_Area;
        private string m_Address;
        private string m_ZipCode;
        private string m_Phone;
        private string m_BrandDesc;
        private string m_AuthenticationDesc;
        private string m_IdCardUrl;
        private string m_LicenseUrl;
        private DateTime m_ApplyDate;
        private int m_ShopId;

        public Vshop_MerchantCertificatedInfo()
        {
        }

        public int MerchantId
        {
            get{ return m_MerchantId; }
            set{ m_MerchantId = value; }
        }

        public int EnterpriseType
        {
            get{ return m_EnterpriseType; }
            set{ m_EnterpriseType = value; }
        }

        public string EnterpriseName
        {
            get{ return m_EnterpriseName; }
            set{ m_EnterpriseName = value; }
        }

        public string ShopKeeper
        {
            get{ return m_ShopKeeper; }
            set{ m_ShopKeeper = value; }
        }

        public string ShopName
        {
            get{ return m_ShopName; }
            set{ m_ShopName = value; }
        }

        public string IdCard
        {
            get{ return m_IdCard; }
            set{ m_IdCard = value; }
        }

        public string Area
        {
            get{ return m_Area; }
            set{ m_Area = value; }
        }

        public string Address
        {
            get{ return m_Address; }
            set{ m_Address = value; }
        }

        public string ZipCode
        {
            get{ return m_ZipCode; }
            set{ m_ZipCode = value; }
        }

        public string Phone
        {
            get{ return m_Phone; }
            set{ m_Phone = value; }
        }

        public string BrandDesc
        {
            get{ return m_BrandDesc; }
            set{ m_BrandDesc = value; }
        }

        public string AuthenticationDesc
        {
            get{ return m_AuthenticationDesc; }
            set{ m_AuthenticationDesc = value; }
        }

        public string IdCardUrl
        {
            get{ return m_IdCardUrl; }
            set{ m_IdCardUrl = value; }
        }

        public string LicenseUrl
        {
            get{ return m_LicenseUrl; }
            set{ m_LicenseUrl = value; }
        }

        public DateTime ApplyDate
        {
            get{ return m_ApplyDate; }
            set{ m_ApplyDate = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

