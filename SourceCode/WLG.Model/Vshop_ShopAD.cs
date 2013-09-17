//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShopAD
    {
        private int m_ShopId;
        private string m_ADName;
        private string m_ADLink;
        private string m_ADThumbnaiUrl;
        private string m_Description;
        private int m_DisplaySequence;

        public Vshop_ShopAD()
        {
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

        public string ADName
        {
            get{ return m_ADName; }
            set{ m_ADName = value; }
        }

        public string ADLink
        {
            get{ return m_ADLink; }
            set{ m_ADLink = value; }
        }

        public string ADThumbnaiUrl
        {
            get{ return m_ADThumbnaiUrl; }
            set{ m_ADThumbnaiUrl = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

    }
}

