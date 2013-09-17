//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Categories
    {
        private int m_CategoryId;
        private string m_Name;
        private int m_ParentCategoryId;
        private int m_Depth;
        private string m_Path;
        private string m_Description;
        private int m_DisplaySequence;
        private string m_SKUPrefix;
        private string m_ImageUrl;
        private int m_ShopId;

        public Vshop_Categories()
        {
        }



         //EasyUi DataTree¹Ì¶¨×Ö¶Î
        public int _parentId
        {
            get { return m_ParentCategoryId; }
            set { m_ParentCategoryId = value; }
        }

        public int CategoryId
        {
            get{ return m_CategoryId; }
            set{ m_CategoryId = value; }
        }

        public string Name
        {
            get{ return m_Name; }
            set{ m_Name = value; }
        }

        public int ParentCategoryId
        {
            get{ return m_ParentCategoryId; }
            set{ m_ParentCategoryId = value; }
        }

        public int Depth
        {
            get{ return m_Depth; }
            set{ m_Depth = value; }
        }

        public string Path
        {
            get{ return m_Path; }
            set{ m_Path = value; }
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

        public string SKUPrefix
        {
            get{ return m_SKUPrefix; }
            set{ m_SKUPrefix = value; }
        }

        public string ImageUrl
        {
            get{ return m_ImageUrl; }
            set{ m_ImageUrl = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

