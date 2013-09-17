//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Attributes
    {
        private int m_AttributeId;
        private string m_AttributeName;
        private int m_DisplaySequence;
        private int m_TypeId;
        private int m_UsageMode;
        private int m_UseAttributeImage;

        public Vshop_Attributes()
        {
        }

        public int AttributeId
        {
            get{ return m_AttributeId; }
            set{ m_AttributeId = value; }
        }

        public string AttributeName
        {
            get{ return m_AttributeName; }
            set{ m_AttributeName = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

        public int TypeId
        {
            get{ return m_TypeId; }
            set{ m_TypeId = value; }
        }

        public int UsageMode
        {
            get{ return m_UsageMode; }
            set{ m_UsageMode = value; }
        }

        public int UseAttributeImage
        {
            get{ return m_UseAttributeImage; }
            set{ m_UseAttributeImage = value; }
        }

    }
}

