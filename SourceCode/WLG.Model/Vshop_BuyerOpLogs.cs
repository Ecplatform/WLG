//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_BuyerOpLogs
    {
        private int m_LogId;
        private string m_PageUrl;
        private DateTime m_AddedTime;
        private string m_OPName;
        private string m_IPAddress;
        private int m_Privilege;
        private string m_Description;
        private int m_ShopId;

        public Vshop_BuyerOpLogs()
        {
        }

        public int LogId
        {
            get{ return m_LogId; }
            set{ m_LogId = value; }
        }

        public string PageUrl
        {
            get{ return m_PageUrl; }
            set{ m_PageUrl = value; }
        }

        public DateTime AddedTime
        {
            get{ return m_AddedTime; }
            set{ m_AddedTime = value; }
        }

        public string OPName
        {
            get{ return m_OPName; }
            set{ m_OPName = value; }
        }

        public string IPAddress
        {
            get{ return m_IPAddress; }
            set{ m_IPAddress = value; }
        }

        public int Privilege
        {
            get{ return m_Privilege; }
            set{ m_Privilege = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

