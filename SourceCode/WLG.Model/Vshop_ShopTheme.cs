//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_ShopTheme
    {
        private int m_ThemeId;
        private string m_ThemeName;
        private string m_ThemeSourcePath;
        private string m_ThumbnailUrl;
        private string m_Description;

        public Vshop_ShopTheme()
        {
        }

        public int ThemeId
        {
            get{ return m_ThemeId; }
            set{ m_ThemeId = value; }
        }

        public string ThemeName
        {
            get{ return m_ThemeName; }
            set{ m_ThemeName = value; }
        }

        public string ThemeSourcePath
        {
            get{ return m_ThemeSourcePath; }
            set{ m_ThemeSourcePath = value; }
        }

        public string ThumbnailUrl
        {
            get{ return m_ThumbnailUrl; }
            set{ m_ThumbnailUrl = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

    }
}

