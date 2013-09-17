//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_WXMaterial
    {
        private int m_MaterialId;
        private int m_ParentMaterialId;
        private string m_Title;
        private string m_Description;
        private string m_Picurl;
        private string m_WebUrl;
        private int m_DisplaySequence;
        private int m_ShopId;

        public Vshop_WXMaterial()
        {
        }

        public int MaterialId
        {
            get{ return m_MaterialId; }
            set{ m_MaterialId = value; }
        }

        public int ParentMaterialId
        {
            get{ return m_ParentMaterialId; }
            set{ m_ParentMaterialId = value; }
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

        public string Picurl
        {
            get{ return m_Picurl; }
            set{ m_Picurl = value; }
        }

        public string WebUrl
        {
            get{ return m_WebUrl; }
            set{ m_WebUrl = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

