//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_WXReply
    {
        private int m_ReplyId;
        private string m_RuleName;
        private int m_InteractiveType;
        private string m_KeyWord;
        private int m_ReplyType;
        private string m_Content;
        private int m_ShopId;

        public Vshop_WXReply()
        {
        }

        public int ReplyId
        {
            get{ return m_ReplyId; }
            set{ m_ReplyId = value; }
        }

        public string RuleName
        {
            get{ return m_RuleName; }
            set{ m_RuleName = value; }
        }

        public int InteractiveType
        {
            get{ return m_InteractiveType; }
            set{ m_InteractiveType = value; }
        }

        public string KeyWord
        {
            get{ return m_KeyWord; }
            set{ m_KeyWord = value; }
        }

        public int ReplyType
        {
            get{ return m_ReplyType; }
            set{ m_ReplyType = value; }
        }

        public string Content
        {
            get{ return m_Content; }
            set{ m_Content = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

