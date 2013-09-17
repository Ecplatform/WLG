//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_AttributeValues
    {
        private int m_ValueId;
        private int m_AttributeId;
        private int m_DisplaySequence;
        private string m_ValueStr;
        private string m_ImageUrl;

        public Vshop_AttributeValues()
        {
        }

        public int ValueId
        {
            get{ return m_ValueId; }
            set{ m_ValueId = value; }
        }

        public int AttributeId
        {
            get{ return m_AttributeId; }
            set{ m_AttributeId = value; }
        }

        public int DisplaySequence
        {
            get{ return m_DisplaySequence; }
            set{ m_DisplaySequence = value; }
        }

        public string ValueStr
        {
            get{ return m_ValueStr; }
            set{ m_ValueStr = value; }
        }

        public string ImageUrl
        {
            get{ return m_ImageUrl; }
            set{ m_ImageUrl = value; }
        }

    }
}

