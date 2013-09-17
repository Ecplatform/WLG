//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Menu
    {
        private int m_MenuId;
        private int m_MenuParentId;
        private string m_MenuName;
        private string m_Title;
        private string m_Description;
        private string m_URL;

        public Vshop_Menu()
        {
        }

        public int MenuId
        {
            get{ return m_MenuId; }
            set{ m_MenuId = value; }
        }

        public int MenuParentId
        {
            get{ return m_MenuParentId; }
            set{ m_MenuParentId = value; }
        }

        public string MenuName
        {
            get{ return m_MenuName; }
            set{ m_MenuName = value; }
        }

        public string Title
        {
            get{ return m_Title; }
            set{ m_Title = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public string URL
        {
            get{ return m_URL; }
            set{ m_URL = value; }
        }

    }
}

