//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_UserInRoles
    {
        private int m_UserId;
        private int m_RoleId;

        public Vshop_UserInRoles()
        {
        }

        public int UserId
        {
            get{ return m_UserId; }
            set{ m_UserId = value; }
        }

        public int RoleId
        {
            get{ return m_RoleId; }
            set{ m_RoleId = value; }
        }

    }
}

