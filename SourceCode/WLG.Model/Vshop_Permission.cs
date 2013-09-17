//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Permission
    {
        private int m_PermissionId;
        private string m_PermissionName;
        private string m_Description;
        private int m_ApplicationId;
        private int m_MenuId;

        public Vshop_Permission()
        {
        }

        public int PermissionId
        {
            get{ return m_PermissionId; }
            set{ m_PermissionId = value; }
        }

        public string PermissionName
        {
            get{ return m_PermissionName; }
            set{ m_PermissionName = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

        public int ApplicationId
        {
            get{ return m_ApplicationId; }
            set{ m_ApplicationId = value; }
        }

        public int MenuId
        {
            get{ return m_MenuId; }
            set{ m_MenuId = value; }
        }

    }
}

