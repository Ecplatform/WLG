//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Users
    {
        private int m_UserId;
        private string m_UserName;
        private string m_NickName;
        private DateTime m_LastActivityDate;
        private string m_Password;
        private string m_PasswordSlat;
        private string m_Email;
        private int m_Gender;
        private DateTime m_BirthDate;
        private string m_PasswordQuestion;
        private string m_PasswordAnswer;
        private int m_IsLockedOut;
        private DateTime m_CreateDate;
        private DateTime m_LastLoginDate;
        private string m_LastLoginIP;
        private DateTime m_LastPasswordChangeDate;
        private DateTime m_LastLockoutDate;
        private int m_FailedPasswordAttemptCount;
        private DateTime m_FailedPasswordAttemptWindowStart;
        private int m_FailedPasswordAnswerAttemptCount;
        private DateTime m_FailedPasswordAnswerAttemptWindowStart;
        private string m_Description;

        public Vshop_Users()
        {
        }

        public int UserId
        {
            get{ return m_UserId; }
            set{ m_UserId = value; }
        }

        public string UserName
        {
            get{ return m_UserName; }
            set{ m_UserName = value; }
        }

        public string NickName
        {
            get{ return m_NickName; }
            set{ m_NickName = value; }
        }

        public DateTime LastActivityDate
        {
            get{ return m_LastActivityDate; }
            set{ m_LastActivityDate = value; }
        }

        public string Password
        {
            get{ return m_Password; }
            set{ m_Password = value; }
        }

        public string PasswordSlat
        {
            get{ return m_PasswordSlat; }
            set{ m_PasswordSlat = value; }
        }

        public string Email
        {
            get{ return m_Email; }
            set{ m_Email = value; }
        }

        public int Gender
        {
            get{ return m_Gender; }
            set{ m_Gender = value; }
        }

        public DateTime BirthDate
        {
            get{ return m_BirthDate; }
            set{ m_BirthDate = value; }
        }

        public string PasswordQuestion
        {
            get{ return m_PasswordQuestion; }
            set{ m_PasswordQuestion = value; }
        }

        public string PasswordAnswer
        {
            get{ return m_PasswordAnswer; }
            set{ m_PasswordAnswer = value; }
        }

        public int IsLockedOut
        {
            get{ return m_IsLockedOut; }
            set{ m_IsLockedOut = value; }
        }

        public DateTime CreateDate
        {
            get{ return m_CreateDate; }
            set{ m_CreateDate = value; }
        }

        public DateTime LastLoginDate
        {
            get{ return m_LastLoginDate; }
            set{ m_LastLoginDate = value; }
        }

        public string LastLoginIP
        {
            get{ return m_LastLoginIP; }
            set{ m_LastLoginIP = value; }
        }

        public DateTime LastPasswordChangeDate
        {
            get{ return m_LastPasswordChangeDate; }
            set{ m_LastPasswordChangeDate = value; }
        }

        public DateTime LastLockoutDate
        {
            get{ return m_LastLockoutDate; }
            set{ m_LastLockoutDate = value; }
        }

        public int FailedPasswordAttemptCount
        {
            get{ return m_FailedPasswordAttemptCount; }
            set{ m_FailedPasswordAttemptCount = value; }
        }

        public DateTime FailedPasswordAttemptWindowStart
        {
            get{ return m_FailedPasswordAttemptWindowStart; }
            set{ m_FailedPasswordAttemptWindowStart = value; }
        }

        public int FailedPasswordAnswerAttemptCount
        {
            get{ return m_FailedPasswordAnswerAttemptCount; }
            set{ m_FailedPasswordAnswerAttemptCount = value; }
        }

        public DateTime FailedPasswordAnswerAttemptWindowStart
        {
            get{ return m_FailedPasswordAnswerAttemptWindowStart; }
            set{ m_FailedPasswordAnswerAttemptWindowStart = value; }
        }

        public string Description
        {
            get{ return m_Description; }
            set{ m_Description = value; }
        }

    }
}

