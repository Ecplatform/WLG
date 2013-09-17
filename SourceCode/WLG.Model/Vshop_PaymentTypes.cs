//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_PaymentTypes
    {
        private int m_ModeId;
        private string m_Name;
        private string m_Description;
        private string m_Gateway;
        private int m_DisplaySequence;
        private Decimal m_Charge;
        private int m_IsPercent;
        private string m_Settings;
        private string m_ShopId;

        public Vshop_PaymentTypes()
        {
        }

        public int ModeId
        {
            get{ return m_ModeId; }
            set{ m_ModeId = value; }
        }

        public string Name
        {
            get{ return m_Name; }
            set{ m_Name = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public string Gateway
        {
            get{ return m_Gateway; }
            set{ m_Gateway = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

        public Decimal Charge
        {
            get{ return m_Charge; }
            set{ m_Charge = value; }
        }

        public int IsPercent
        {
            get{ return m_IsPercent; }
            set{ m_IsPercent = value; }
        }

        public string Settings
        {
            get{ return m_Settings; }
            set{ m_Settings = value; }
        }

        public string ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

