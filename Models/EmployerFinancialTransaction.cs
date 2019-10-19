using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class EmployerFinancialTransaction
    {
        public int Id { get; set; }
        public int? TransactionType { get; set; }
        public int? EmployerPackage { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? EmployerId { get; set; }
        public double? AmountPaid { get; set; }
        public double? TaxRate { get; set; }
        public double? Net { get; set; }
        public double? Gross { get; set; }
        public int? AdminTellerId { get; set; }
        public int? CreditsExchanged { get; set; }
        public string WechatOutTradeNo { get; set; }
        public string AliPayOutTradeNo { get; set; }
        public string AliPayTradeNo { get; set; }
        public string PaypalInvoiceNo { get; set; }
        public long? EccInvoiceNo { get; set; }
        public string PaymentType { get; set; }
        public int? CreditsAfterTransaction { get; set; }
        public int? CvCreditsAfterTransaction { get; set; }
        public int? CvCreditsExchanged { get; set; }
        public string YeePayTrackingId { get; set; }
        public int? ContactCreditsExchanged { get; set; }
        public int? ContactCreditsAfterTransaction { get; set; }
    }
}
