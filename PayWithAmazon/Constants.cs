﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PayWithAmazon
{
    public static class Constants
    {
        public static readonly string MWSClientVersion = "2.0.0";
        public static readonly string PaymentsServiceVersion = "2013-01-01";
        public static readonly int MaxErrorRetry = 3;
        
        /// <summary>
        /// common parameters for all API calls
        /// </summary>
        public static readonly string SellerId = "SellerId";
        public static readonly string MWSAuthToken = "MWSAuthToken";
        public static readonly string AmazonOrderReferenceId = "AmazonOrderReferenceId";
        public static readonly string AddressConsentToken = "AddressConsentToken";
        public static readonly string OrderReferenceAttributes_OrderTotal_Amount = "OrderReferenceAttributes.OrderTotal.Amount";
        public static readonly string OrderReferenceAttributes_OrderTotal_CurrencyCode = "OrderReferenceAttributes.OrderTotal.CurrencyCode";

        public static readonly string OrderReferenceAttributes_PlatformId = "OrderReferenceAttributes.PlatformId";
        public static readonly string OrderReferenceAttributes_SellerNote = "OrderReferenceAttributes.SellerNote";
        public static readonly string OrderReferenceAttributes_SellerOrderAttributes_SellerOrderId = "OrderReferenceAttributes.SellerOrderAttributes.SellerOrderId";
        public static readonly string OrderReferenceAttributes_SellerOrderAttributes_StoreName = "OrderReferenceAttributes.SellerOrderAttributes.StoreName";


        public static readonly string OrderReferenceAttributes_SellerOrderAttributes_CustomInformation = "OrderReferenceAttributes.SellerOrderAttributes.CustomInformation";
        public static readonly string AuthorizationAmount_Amount = "AuthorizationAmount.Amount";

        public static readonly string AuthorizationAmount_CurrencyCode = "AuthorizationAmount.CurrencyCode";
        public static readonly string AuthorizationReferenceId = "AuthorizationReferenceId";
        public static readonly string CaptureNow = "CaptureNow";
        public static readonly string ProviderId = "ProviderId";
        public static readonly string CreditAmount_Amount = "CreditAmount.Amount";
        public static readonly string CreditAmount_CurrencyCode = "CreditAmount.CurrencyCode";
        public static readonly string provider_credit_details = "provider_credit_details";
        public static readonly string provider_credit_reversal_details = "provider_credit_reversal_details";
        public static readonly string SellerAuthorizationNote = "SellerAuthorizationNote";
        public static readonly string TransactionTimeout = "TransactionTimeout";
        public static readonly string SoftDescriptor = "SoftDescriptor";
        public static readonly string AmazonAuthorizationId = "AmazonAuthorizationId";
        public static readonly string CaptureAmount_Amount = "CaptureAmount.Amount";
        public static readonly string CaptureAmount_CurrencyCode = "CaptureAmount.CurrencyCode";

        public static readonly string CaptureReferenceId = "CaptureReferenceId";
        public static readonly string SellerCaptureNote = "SellerCaptureNote";
        public static readonly string AmazonCaptureId = "AmazonCaptureId";
        public static readonly string RefundAmount_Amount = "RefundAmount.Amount";
        public static readonly string RefundAmount_CurrencyCode = "RefundAmount.CurrencyCode";
        public static readonly string RefundReferenceId = "RefundReferenceId";
        public static readonly string CreditReversalAmount_Amount = "CreditReversalAmount.Amount";
        public static readonly string CreditReversalAmount_CurrencyCode = "CreditReversalAmount.CurrencyCode";
        public static readonly string SellerRefundNote = "SellerRefundNote";
        public static readonly string ClosureReason = "ClosureReason";
        public static readonly string CancelationReason = "CancelationReason";
        public static readonly string ChargeType_OrderReference = "OrderReference";
        public static readonly string ChargeType_BillingAgreement = "BillingAgreement";
        public static readonly string AmazonRefundId = "AmazonRefundId";
        public static readonly string AmazonBillingAgreementId = "AmazonBillingAgreementId";
        public static readonly string BillingAgreementAttributes_PlatformId = "BillingAgreementAttributes.PlatformId";
        public static readonly string BillingAgreementAttributes_SellerNote = "BillingAgreementAttributes.SellerNote";
        public static readonly string BillingAgreementAttributes_SellerBillingAgreementAttributes_SellerBillingAgreementId = "BillingAgreementAttributes.SellerBillingAgreementAttributes.SellerBillingAgreementId";
        public static readonly string BillingAgreementAttributes_SellerBillingAgreementAttributes_StoreName = "BillingAgreementAttributes.SellerBillingAgreementAttributes.StoreName";
        public static readonly string BillingAgreementAttributes_SellerBillingAgreementAttributes_CustomInformation = "BillingAgreementAttributes.SellerBillingAgreementAttributes.CustomInformation";
        public static readonly string Id = "Id";
        public static readonly string IdType = "IdType";
        public static readonly string InheritShippingAddress = "InheritShippingAddress";
        public static readonly string ConfirmNow = "ConfirmNow";

        public static readonly string SellerOrderAttributes_CustomInformation = "SellerOrderAttributes.CustomInformation";
        public static readonly string SellerOrderAttributes_StoreName = "SellerOrderAttributes.StoreName";
        public static readonly string SellerOrderAttributes_SellerOrderId = "SellerOrderAttributes.SellerOrderId";
        public static readonly string SellerNote = "SellerNote";
        public static readonly string PlatformId = "PlatformId";

        public static readonly string AmazonProviderCreditId = "AmazonProviderCreditId";
        public static readonly string AmazonProviderCreditReversalId = "AmazonProviderCreditReversalId";
        public static readonly string CreditReversalReferenceId = "CreditReversalReferenceId";
        public static readonly string CreditReversalNote = "CreditReversalNote";


        /// <summary>
        /// API call MWS Action name Definitions
        /// </summary>
        public static readonly string Action = "Action";
        public static readonly string GetOrderReferenceDetails = "GetOrderReferenceDetails";
        public static readonly string SetOrderReferenceDetails = "SetOrderReferenceDetails";
        public static readonly string ConfirmOrderReference = "ConfirmOrderReference";
        public static readonly string CancelOrderReference = "CancelOrderReference";
        public static readonly string CloseOrderReference = "CloseOrderReference";
        public static readonly string CloseAuthorization = "CloseAuthorization";
        public static readonly string Authorize = "Authorize";
        public static readonly string GetAuthorizationDetails = "GetAuthorizationDetails";
        public static readonly string Capture = "Capture";
        public static readonly string GetCaptureDetails = "GetCaptureDetails";
        public static readonly string Refund = "Refund";
        public static readonly string GetRefundDetails = "GetRefundDetails";
        public static readonly string GetServiceStatus = "GetServiceStatus";
        public static readonly string CreateOrderReferenceForId = "CreateOrderReferenceForId";
        public static readonly string GetBillingAgreementDetails = "GetBillingAgreementDetails";
        public static readonly string SetBillingAgreementDetails = "SetBillingAgreementDetails";
        public static readonly string ConfirmBillingAgreement = "ConfirmBillingAgreement";
        public static readonly string ValidateBillingAgreement = "ValidateBillingAgreement";
        public static readonly string AuthorizeOnBillingAgreement = "AuthorizeOnBillingAgreement";
        public static readonly string CloseBillingAgreement = "CloseBillingAgreement";
        public static readonly string GetProviderCreditDetails = "GetProviderCreditDetails";
        public static readonly string GetProviderCreditReversalDetails = "GetProviderCreditReversalDetails";
        public static readonly string ReverseProviderCredit = "ReverseProviderCredit";

        /// <summary>
        /// OrderReference/BillingAgreement state
        /// </summary>
        public static readonly string Open = "Open";
        public static readonly string Draft = "Draft";

        /// <summary>
        /// IPN Handler
        /// </summary>
        public static readonly string CertCN = "sns.amazonaws.com";

        // Cache key format string to avoid conflicts with other items in the application cache
        public static readonly string CacheKey = "PayWithAmazonNotification";

        // Format string for ipn timestamps, in ISO8601 format with millseconds, in UTC
        public static readonly string Iso8601UTCDateWithMillisecondsFormatString = @"yyyy-MM-ddTHH:mm:ss.fffZ";

    }
}