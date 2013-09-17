//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Roles
    {
        private int m_RoleId;
        private string m_RoleName;
        private string m_Description;

        public Vshop_Roles()
        {
        }

        public int RoleId
        {
            get{ return m_RoleId; }
            set{ m_RoleId = value; }
        }

        public string RoleName
        {
            get{ return m_RoleName; }
            set{ m_RoleName = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

    }
}

