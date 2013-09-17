//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_RolesPermissions
    {
        private int m_RoleId;
        private int m_PermissionId;

        public Vshop_RolesPermissions()
        {
        }

        public int RoleId
        {
            get{ return m_RoleId; }
            set{ m_RoleId = value; }
        }

        public int PermissionId
        {
            get{ return m_PermissionId; }
            set{ m_PermissionId = value; }
        }

    }
}

