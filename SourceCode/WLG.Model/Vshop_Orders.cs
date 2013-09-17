//Create By CodeFactory
using System;
using System.Collections.Generic;
using System.Text;

namespace WLG.Model
{
     [Serializable]
    public class Vshop_Orders
    {
        private string m_OrderId;
        private string m_Remark;
        private int m_OrderStatus;
        private string m_CloseReason;
        private DateTime m_OrderDate;
        private DateTime m_PayDate;
        private DateTime m_ShippingDate;
        private DateTime m_FinishDate;
        private int m_BuyerId;
        private string m_BuyerName;
        private string m_ShippingRegion;
        private string m_Address;
        private string m_ZipCode;
        private string m_TelPhone;
        private int m_ShippingModeId;
        private string m_ShippingModeName;
        private Decimal m_Freight;
        private Decimal m_AdjustedFreight;
        private string m_ShipOrderNumber;
        private int m_Weigth;
        private int m_PaymentModeId;
        private string m_PaymentModeName;
        private Decimal m_PayCharge;
        private Decimal m_AdjustedPayCharge;
        private int m_RefundStatus;
        private Decimal m_RefundAmount;
        private string m_RefundRemark;
        private Decimal m_OrderTotal;
        private Decimal m_OrderCostPrice;
        private Decimal m_OrderProfit;
        private Decimal m_OtherCost;
        private DateTime m_LastRemindDeliverDate;
        private int m_RemindCount;
        private int m_ShopId;

        public Vshop_Orders()
        {
        }

        public string OrderId
        {
            get{ return m_OrderId; }
            set{ m_OrderId = value; }
        }

        public string Remark
        {
            get{ return m_Remark; }
            set{ m_Remark = value; }
        }

        public int OrderStatus
        {
            get{ return m_OrderStatus; }
            set{ m_OrderStatus = value; }
        }

        public string CloseReason
        {
            get{ return m_CloseReason; }
            set{ m_CloseReason = value; }
        }

        public DateTime OrderDate
        {
            get{ return m_OrderDate; }
            set{ m_OrderDate = value; }
        }

        public DateTime PayDate
        {
            get{ return m_PayDate; }
            set{ m_PayDate = value; }
        }

        public DateTime ShippingDate
        {
            get{ return m_ShippingDate; }
            set{ m_ShippingDate = value; }
        }

        public DateTime FinishDate
        {
            get{ return m_FinishDate; }
            set{ m_FinishDate = value; }
        }

        public int BuyerId
        {
            get{ return m_BuyerId; }
            set{ m_BuyerId = value; }
        }

        public string BuyerName
        {
            get{ return m_BuyerName; }
            set{ m_BuyerName = value; }
        }

        public string ShippingRegion
        {
            get{ return m_ShippingRegion; }
            set{ m_ShippingRegion = value; }
        }

        public string Address
        {
            get{ return m_Address; }
            set{ m_Address = value; }
        }

        public string ZipCode
        {
            get{ return m_ZipCode; }
            set{ m_ZipCode = value; }
        }

        public string TelPhone
        {
            get{ return m_TelPhone; }
            set{ m_TelPhone = value; }
        }

        public int ShippingModeId
        {
            get{ return m_ShippingModeId; }
            set{ m_ShippingModeId = value; }
        }

        public string ShippingModeName
        {
            get{ return m_ShippingModeName; }
            set{ m_ShippingModeName = value; }
        }

        public Decimal Freight
        {
            get{ return m_Freight; }
            set{ m_Freight = value; }
        }

        public Decimal AdjustedFreight
        {
            get{ return m_AdjustedFreight; }
            set{ m_AdjustedFreight = value; }
        }

        public string ShipOrderNumber
        {
            get{ return m_ShipOrderNumber; }
            set{ m_ShipOrderNumber = value; }
        }

        public int Weigth
        {
            get{ return m_Weigth; }
            set{ m_Weigth = value; }
        }

        public int PaymentModeId
        {
            get{ return m_PaymentModeId; }
            set{ m_PaymentModeId = value; }
        }

        public string PaymentModeName
        {
            get{ return m_PaymentModeName; }
            set{ m_PaymentModeName = value; }
        }

        public Decimal PayCharge
        {
            get{ return m_PayCharge; }
            set{ m_PayCharge = value; }
        }

        public Decimal AdjustedPayCharge
        {
            get{ return m_AdjustedPayCharge; }
            set{ m_AdjustedPayCharge = value; }
        }

        public int RefundStatus
        {
            get{ return m_RefundStatus; }
            set{ m_RefundStatus = value; }
        }

        public Decimal RefundAmount
        {
            get{ return m_RefundAmount; }
            set{ m_RefundAmount = value; }
        }

        public string RefundRemark
        {
            get{ return m_RefundRemark; }
            set{ m_RefundRemark = value; }
        }

        public Decimal OrderTotal
        {
            get{ return m_OrderTotal; }
            set{ m_OrderTotal = value; }
        }

        public Decimal OrderCostPrice
        {
            get{ return m_OrderCostPrice; }
            set{ m_OrderCostPrice = value; }
        }

        public Decimal OrderProfit
        {
            get{ return m_OrderProfit; }
            set{ m_OrderProfit = value; }
        }

        public Decimal OtherCost
        {
            get{ return m_OtherCost; }
            set{ m_OtherCost = value; }
        }

        public DateTime LastRemindDeliverDate
        {
            get{ return m_LastRemindDeliverDate; }
            set{ m_LastRemindDeliverDate = value; }
        }

        public int RemindCount
        {
            get{ return m_RemindCount; }
            set{ m_RemindCount = value; }
        }

        public int ShopId
        {
            get{ return m_ShopId; }
            set{ m_ShopId = value; }
        }

    }
}

