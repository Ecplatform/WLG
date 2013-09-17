//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShopNavigation
    {
        private int m_ShopId;
        private string m_NavigationName;
        private string m_NavigationLink;
        private int m_Enabled;
        private string m_NavThumbnailUrl;
        private int m_DisplaySequence;

        public Vshop_ShopNavigation()
        {
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

        public string NavigationName
        {
            get{ return m_NavigationName; }
            set{ m_NavigationName = value; }
        }

        public string NavigationLink
        {
            get{ return m_NavigationLink; }
            set{ m_NavigationLink = value; }
        }

        public int Enabled
        {
            get{ return m_Enabled; }
            set{ m_Enabled = value; }
        }

        public string NavThumbnailUrl
        {
            get{ return m_NavThumbnailUrl; }
            set{ m_NavThumbnailUrl = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

    }
}

