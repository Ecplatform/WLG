//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{ 
     [Serializable]
    public class Vshop_Application
    {
        private int m_ApplicationId;
        private string m_ApplicationName;
        private string m_Description;

        public Vshop_Application()
        {
        }

        public int ApplicationId
        {
            get{ return m_ApplicationId; }
            set{ m_ApplicationId = value; }
        }

        public string ApplicationName
        {
            get{ return m_ApplicationName; }
            set{ m_ApplicationName = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

    }
}

