//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace ServiceReferenc22
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant", ConfigurationName="ServiceReferenc22.MerchantService")]
    public interface MerchantService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> refundOrderAsync(ServiceReferenc22.refundOrderParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.createBindingNoPaymentResponse> createBindingNoPaymentAsync(ServiceReferenc22.createBindingNoPaymentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> unBindCardAsync(string bindingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.androidPayPaymentResponse> androidPayAsync(ServiceReferenc22.androidPayPaymentRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.registerOrderResponse> registerOrderAsync(ServiceReferenc22.orderParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.applePayPaymentResponse> applePayDirectAsync(ServiceReferenc22.applePayDirectPaymentRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderResult> paymentOrderBindingAsync(ServiceReferenc22.paymentOrderBindingParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.applePayPaymentResponse> applePayAsync(ServiceReferenc22.applePayPaymentRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> addParamsAsync(ServiceReferenc22.addParamsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.getBindingsResponse> getBindingsAsync(ServiceReferenc22.getBindingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        System.Threading.Tasks.Task<ServiceReferenc22.getLastOrdersResponse> getLastOrdersAsync(ServiceReferenc22.getLastOrders request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.getOrderStatusExtendedResponse> getOrderStatusExtendedAsync(ServiceReferenc22.getOrderStatusExtendedRequest order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderCardPresentResult> paymentOrderCardPresentAsync(ServiceReferenc22.paymentOrderCardPresentParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.registerOrderResponse> registerOrderPreAuthAsync(ServiceReferenc22.orderParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.extendBindingResponse> extendBindingAsync(ServiceReferenc22.extendBindingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.verifyEnrollmentResponse> verifyEnrollmentAsync(string pan);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.getLastOrdersForMerchantsResponse> getLastOrdersForMerchantsAsync(ServiceReferenc22.getLastOrdersForMerchantsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> updateSSLCardListAsync(string mdorder);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.getBindingsResponse> getBindingsByCardOrIdAsync(ServiceReferenc22.getBindingsByCardOrIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.googlePayResponse> googlePayAsync(ServiceReferenc22.googlePayRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> processRawSumOrderRefundAsync(ServiceReferenc22.rawSumRefundRequest order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.googlePayResponse> googlePayDirectAsync(ServiceReferenc22.googlePayDirectRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> processRawPositionOrderRefundAsync(ServiceReferenc22.rawPositionRefundRequest order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> reverseOrderAsync(ServiceReferenc22.reversalOrderParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> bindCardAsync(string bindingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.finishThreeDSResponse> finishThreeDsAsync(ServiceReferenc22.finishThreeDSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> updateBlackCardListAsync(string mdorder);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.finishThreeDSResponse> finishThreeDsVer2Async(ServiceReferenc22.finishThreeDSVer2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.recurrentPaymentResponse> recurrentPaymentAsync(ServiceReferenc22.recurrentPaymentRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderOtherWayResult> paymentOrderOtherWayAsync(ServiceReferenc22.paymentOrderOtherWayParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> checkAuthenticateAsync(ServiceReferenc22.loginParams login);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.samsungPayPaymentResponse> samsungPayAsync(ServiceReferenc22.samsungPayPaymentRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> updateWhiteCardListAsync(string mdorder);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderResult> depositOrderAsync(ServiceReferenc22.depositOrderParams order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.orderStatusResponse> getOrderStatusAsync(ServiceReferenc22.orderStatusRequest order);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractServiceRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(binding[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderResult> paymentOrderAsync(ServiceReferenc22.paymentOrderParams order);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class refundOrderParams : abstractServiceRequest
    {
        
        private item[] refundItemsField;
        
        private serviceParam[] paramsField;
        
        private long expectedDepositedAmountField;
        
        private bool expectedDepositedAmountFieldSpecified;
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        private string orderIdField;
        
        private long refundAmountField;
        
        private bool refundAmountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("items", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public item[] refundItems
        {
            get
            {
                return this.refundItemsField;
            }
            set
            {
                this.refundItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long expectedDepositedAmount
        {
            get
            {
                return this.expectedDepositedAmountField;
            }
            set
            {
                this.expectedDepositedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedDepositedAmountSpecified
        {
            get
            {
                return this.expectedDepositedAmountFieldSpecified;
            }
            set
            {
                this.expectedDepositedAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long refundAmount
        {
            get
            {
                return this.refundAmountField;
            }
            set
            {
                this.refundAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refundAmountSpecified
        {
            get
            {
                return this.refundAmountFieldSpecified;
            }
            set
            {
                this.refundAmountFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class item
    {
        
        private string nameField;
        
        private itemDetailsParam[] itemDetailsField;
        
        private quantity quantityField;
        
        private long itemAmountField;
        
        private long depositedItemAmountField;
        
        private bool depositedItemAmountFieldSpecified;
        
        private int itemCurrencyField;
        
        private bool itemCurrencyFieldSpecified;
        
        private string itemCodeField;
        
        private discount discountField;
        
        private agentInterest agentInterestField;
        
        private tax taxField;
        
        private long itemPriceField;
        
        private bool itemPriceFieldSpecified;
        
        private itemAttribute[] itemAttributesField;
        
        private string positionIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("itemDetailsParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemDetailsParam[] itemDetails
        {
            get
            {
                return this.itemDetailsField;
            }
            set
            {
                this.itemDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public quantity quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long itemAmount
        {
            get
            {
                return this.itemAmountField;
            }
            set
            {
                this.itemAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public long depositedItemAmount
        {
            get
            {
                return this.depositedItemAmountField;
            }
            set
            {
                this.depositedItemAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositedItemAmountSpecified
        {
            get
            {
                return this.depositedItemAmountFieldSpecified;
            }
            set
            {
                this.depositedItemAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int itemCurrency
        {
            get
            {
                return this.itemCurrencyField;
            }
            set
            {
                this.itemCurrencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCurrencySpecified
        {
            get
            {
                return this.itemCurrencyFieldSpecified;
            }
            set
            {
                this.itemCurrencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string itemCode
        {
            get
            {
                return this.itemCodeField;
            }
            set
            {
                this.itemCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public discount discount
        {
            get
            {
                return this.discountField;
            }
            set
            {
                this.discountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public agentInterest agentInterest
        {
            get
            {
                return this.agentInterestField;
            }
            set
            {
                this.agentInterestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public tax tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public long itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemPriceSpecified
        {
            get
            {
                return this.itemPriceFieldSpecified;
            }
            set
            {
                this.itemPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("attributes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public itemAttribute[] itemAttributes
        {
            get
            {
                return this.itemAttributesField;
            }
            set
            {
                this.itemAttributesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string positionId
        {
            get
            {
                return this.positionIdField;
            }
            set
            {
                this.positionIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class itemDetailsParam
    {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentOrderParams
    {
        
        private serviceParam[] paramsField;
        
        private string orderIdField;
        
        private string yearField;
        
        private string monthField;
        
        private string panField;
        
        private string cvcField;
        
        private string cardholderNameField;
        
        private string languageField;
        
        private string ipField;
        
        private string emailField;
        
        private string postAddressField;
        
        private string pointsAmountField;
        
        private string loyaltyIdField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSVer2FinishUrlField;
        
        private string seTokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cvc
        {
            get
            {
                return this.cvcField;
            }
            set
            {
                this.cvcField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cardholderName
        {
            get
            {
                return this.cardholderNameField;
            }
            set
            {
                this.cardholderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pointsAmount
        {
            get
            {
                return this.pointsAmountField;
            }
            set
            {
                this.pointsAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string loyaltyId
        {
            get
            {
                return this.loyaltyIdField;
            }
            set
            {
                this.loyaltyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string threeDSVer2FinishUrl
        {
            get
            {
                return this.threeDSVer2FinishUrlField;
            }
            set
            {
                this.threeDSVer2FinishUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string seToken
        {
            get
            {
                return this.seTokenField;
            }
            set
            {
                this.seTokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class serviceParam
    {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class samsungError
    {
        
        private string codeField;
        
        private string descriptionField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class samsungData
    {
        
        private string orderIdField;
        
        private string bindingIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class samsungPayPaymentResponse
    {
        
        private bool successField;
        
        private samsungData dataField;
        
        private samsungError errorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public samsungData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public samsungError error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class samsungPayPaymentRequest
    {
        
        private string merchantField;
        
        private string orderNumberField;
        
        private string languageField;
        
        private bool preAuthField;
        
        private string descriptionField;
        
        private samsungPayPaymentRequestEntry[] additionalParametersField;
        
        private string paymentTokenField;
        
        private string ipField;
        
        private orderBundle orderBundleField;
        
        private int taxSystemField;
        
        private bool taxSystemFieldSpecified;
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string merchant
        {
            get
            {
                return this.merchantField;
            }
            set
            {
                this.merchantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool preAuth
        {
            get
            {
                return this.preAuthField;
            }
            set
            {
                this.preAuthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public samsungPayPaymentRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string paymentToken
        {
            get
            {
                return this.paymentTokenField;
            }
            set
            {
                this.paymentTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int taxSystem
        {
            get
            {
                return this.taxSystemField;
            }
            set
            {
                this.taxSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSystemSpecified
        {
            get
            {
                return this.taxSystemFieldSpecified;
            }
            set
            {
                this.taxSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class samsungPayPaymentRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class orderBundle
    {
        
        private System.DateTime orderCreationDateField;
        
        private bool orderCreationDateFieldSpecified;
        
        private customerDetails customerDetailsField;
        
        private item[] cartItemsField;
        
        private loyalty[] loyaltiesField;
        
        private agent agentField;
        
        private string supplierPhonesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime orderCreationDate
        {
            get
            {
                return this.orderCreationDateField;
            }
            set
            {
                this.orderCreationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderCreationDateSpecified
        {
            get
            {
                return this.orderCreationDateFieldSpecified;
            }
            set
            {
                this.orderCreationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public customerDetails customerDetails
        {
            get
            {
                return this.customerDetailsField;
            }
            set
            {
                this.customerDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("items", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public item[] cartItems
        {
            get
            {
                return this.cartItemsField;
            }
            set
            {
                this.cartItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("loyalties", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public loyalty[] loyalties
        {
            get
            {
                return this.loyaltiesField;
            }
            set
            {
                this.loyaltiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public agent agent
        {
            get
            {
                return this.agentField;
            }
            set
            {
                this.agentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string supplierPhones
        {
            get
            {
                return this.supplierPhonesField;
            }
            set
            {
                this.supplierPhonesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class customerDetails
    {
        
        private string emailField;
        
        private string phoneField;
        
        private string contactField;
        
        private deliveryInfo deliveryInfoField;
        
        private string fullNameField;
        
        private string passportField;
        
        private string innField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public deliveryInfo deliveryInfo
        {
            get
            {
                return this.deliveryInfoField;
            }
            set
            {
                this.deliveryInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string fullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string passport
        {
            get
            {
                return this.passportField;
            }
            set
            {
                this.passportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string inn
        {
            get
            {
                return this.innField;
            }
            set
            {
                this.innField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class deliveryInfo
    {
        
        private string deliveryTypeField;
        
        private string countryField;
        
        private string cityField;
        
        private string postAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class loyalty
    {
        
        private long bonusAmountForDebitField;
        
        private long bonusAmountForCreditField;
        
        private string loyaltyProgramNameField;
        
        private string positionIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long bonusAmountForDebit
        {
            get
            {
                return this.bonusAmountForDebitField;
            }
            set
            {
                this.bonusAmountForDebitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long bonusAmountForCredit
        {
            get
            {
                return this.bonusAmountForCreditField;
            }
            set
            {
                this.bonusAmountForCreditField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string loyaltyProgramName
        {
            get
            {
                return this.loyaltyProgramNameField;
            }
            set
            {
                this.loyaltyProgramNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string positionId
        {
            get
            {
                return this.positionIdField;
            }
            set
            {
                this.positionIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class agent
    {
        
        private int agentTypeField;
        
        private bool agentTypeFieldSpecified;
        
        private string payingOperationField;
        
        private string payingPhonesField;
        
        private string paymentsOperatorPhonesField;
        
        private string mtOperatorPhonesField;
        
        private string mtOperatorNameField;
        
        private string mtOperatorAddressField;
        
        private string mtOperatorInnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int agentType
        {
            get
            {
                return this.agentTypeField;
            }
            set
            {
                this.agentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool agentTypeSpecified
        {
            get
            {
                return this.agentTypeFieldSpecified;
            }
            set
            {
                this.agentTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string payingOperation
        {
            get
            {
                return this.payingOperationField;
            }
            set
            {
                this.payingOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string payingPhones
        {
            get
            {
                return this.payingPhonesField;
            }
            set
            {
                this.payingPhonesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string paymentsOperatorPhones
        {
            get
            {
                return this.paymentsOperatorPhonesField;
            }
            set
            {
                this.paymentsOperatorPhonesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string mtOperatorPhones
        {
            get
            {
                return this.mtOperatorPhonesField;
            }
            set
            {
                this.mtOperatorPhonesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string mtOperatorName
        {
            get
            {
                return this.mtOperatorNameField;
            }
            set
            {
                this.mtOperatorNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string mtOperatorAddress
        {
            get
            {
                return this.mtOperatorAddressField;
            }
            set
            {
                this.mtOperatorAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string mtOperatorInn
        {
            get
            {
                return this.mtOperatorInnField;
            }
            set
            {
                this.mtOperatorInnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class additionalOfdParam
    {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class recurrentPaymentError
    {
        
        private string codeField;
        
        private string descriptionField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class recurrentPaymentData
    {
        
        private string orderIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class recurrentPaymentResponse
    {
        
        private bool successField;
        
        private recurrentPaymentData dataField;
        
        private recurrentPaymentError errorField;
        
        private getOrderStatusExtendedResponse orderStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public recurrentPaymentData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public recurrentPaymentError error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public getOrderStatusExtendedResponse orderStatus
        {
            get
            {
                return this.orderStatusField;
            }
            set
            {
                this.orderStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class getOrderStatusExtendedResponse : abstractServiceResponse
    {
        
        private serviceParam[] merchantOrderParamsField;
        
        private serviceParam[] attributesField;
        
        private cardAuthInfo cardAuthInfoField;
        
        private cardBindingInfo bindingInfoField;
        
        private System.DateTime authDateTimeField;
        
        private bool authDateTimeFieldSpecified;
        
        private string terminalIdField;
        
        private string authRefNumField;
        
        private paymentAmountInfo paymentAmountInfoField;
        
        private bankInfo bankInfoField;
        
        private payerData payerDataField;
        
        private orderBundle orderBundleField;
        
        private loyaltyInfo loyaltyInfoField;
        
        private refund[] refundsField;
        
        private bool chargebackField;
        
        private bool chargebackFieldSpecified;
        
        private processingOperation[] operationsField;
        
        private string paymentWayField;
        
        private string orderNumberField;
        
        private int orderStatusField;
        
        private bool orderStatusFieldSpecified;
        
        private int actionCodeField;
        
        private bool actionCodeFieldSpecified;
        
        private string actionCodeDescriptionField;
        
        private string originalActionCodeField;
        
        private long amountField;
        
        private bool amountFieldSpecified;
        
        private string currencyField;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private System.DateTime depositedDateField;
        
        private bool depositedDateFieldSpecified;
        
        private System.DateTime refundedDateField;
        
        private bool refundedDateFieldSpecified;
        
        private System.DateTime reversedDateField;
        
        private bool reversedDateFieldSpecified;
        
        private string orderDescriptionField;
        
        private string ipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("merchantOrderParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public serviceParam[] merchantOrderParams
        {
            get
            {
                return this.merchantOrderParamsField;
            }
            set
            {
                this.merchantOrderParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attributes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public serviceParam[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public cardAuthInfo cardAuthInfo
        {
            get
            {
                return this.cardAuthInfoField;
            }
            set
            {
                this.cardAuthInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public cardBindingInfo bindingInfo
        {
            get
            {
                return this.bindingInfoField;
            }
            set
            {
                this.bindingInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime authDateTime
        {
            get
            {
                return this.authDateTimeField;
            }
            set
            {
                this.authDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool authDateTimeSpecified
        {
            get
            {
                return this.authDateTimeFieldSpecified;
            }
            set
            {
                this.authDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string terminalId
        {
            get
            {
                return this.terminalIdField;
            }
            set
            {
                this.terminalIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string authRefNum
        {
            get
            {
                return this.authRefNumField;
            }
            set
            {
                this.authRefNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public paymentAmountInfo paymentAmountInfo
        {
            get
            {
                return this.paymentAmountInfoField;
            }
            set
            {
                this.paymentAmountInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public bankInfo bankInfo
        {
            get
            {
                return this.bankInfoField;
            }
            set
            {
                this.bankInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public payerData payerData
        {
            get
            {
                return this.payerDataField;
            }
            set
            {
                this.payerDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public loyaltyInfo loyaltyInfo
        {
            get
            {
                return this.loyaltyInfoField;
            }
            set
            {
                this.loyaltyInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("refunds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public refund[] refunds
        {
            get
            {
                return this.refundsField;
            }
            set
            {
                this.refundsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public bool chargeback
        {
            get
            {
                return this.chargebackField;
            }
            set
            {
                this.chargebackField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chargebackSpecified
        {
            get
            {
                return this.chargebackFieldSpecified;
            }
            set
            {
                this.chargebackFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("operations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public processingOperation[] operations
        {
            get
            {
                return this.operationsField;
            }
            set
            {
                this.operationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string paymentWay
        {
            get
            {
                return this.paymentWayField;
            }
            set
            {
                this.paymentWayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int orderStatus
        {
            get
            {
                return this.orderStatusField;
            }
            set
            {
                this.orderStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderStatusSpecified
        {
            get
            {
                return this.orderStatusFieldSpecified;
            }
            set
            {
                this.orderStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int actionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionCodeSpecified
        {
            get
            {
                return this.actionCodeFieldSpecified;
            }
            set
            {
                this.actionCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actionCodeDescription
        {
            get
            {
                return this.actionCodeDescriptionField;
            }
            set
            {
                this.actionCodeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string originalActionCode
        {
            get
            {
                return this.originalActionCodeField;
            }
            set
            {
                this.originalActionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime depositedDate
        {
            get
            {
                return this.depositedDateField;
            }
            set
            {
                this.depositedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositedDateSpecified
        {
            get
            {
                return this.depositedDateFieldSpecified;
            }
            set
            {
                this.depositedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime refundedDate
        {
            get
            {
                return this.refundedDateField;
            }
            set
            {
                this.refundedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refundedDateSpecified
        {
            get
            {
                return this.refundedDateFieldSpecified;
            }
            set
            {
                this.refundedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime reversedDate
        {
            get
            {
                return this.reversedDateField;
            }
            set
            {
                this.reversedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reversedDateSpecified
        {
            get
            {
                return this.reversedDateFieldSpecified;
            }
            set
            {
                this.reversedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderDescription
        {
            get
            {
                return this.orderDescriptionField;
            }
            set
            {
                this.orderDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class cardAuthInfo
    {
        
        private secureAuthInfo secureAuthInfoField;
        
        private string maskedPanField;
        
        private string expirationField;
        
        private string cardholderNameField;
        
        private string approvalCodeField;
        
        private string paymentSystemField;
        
        private string productField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public secureAuthInfo secureAuthInfo
        {
            get
            {
                return this.secureAuthInfoField;
            }
            set
            {
                this.secureAuthInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maskedPan
        {
            get
            {
                return this.maskedPanField;
            }
            set
            {
                this.maskedPanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiration
        {
            get
            {
                return this.expirationField;
            }
            set
            {
                this.expirationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cardholderName
        {
            get
            {
                return this.cardholderNameField;
            }
            set
            {
                this.cardholderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string approvalCode
        {
            get
            {
                return this.approvalCodeField;
            }
            set
            {
                this.approvalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paymentSystem
        {
            get
            {
                return this.paymentSystemField;
            }
            set
            {
                this.paymentSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class secureAuthInfo
    {
        
        private int eciField;
        
        private string paResCheckStatusField;
        
        private string paResStatusField;
        
        private threeDSInfo threeDSInfoField;
        
        private string veResStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int eci
        {
            get
            {
                return this.eciField;
            }
            set
            {
                this.eciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string paResCheckStatus
        {
            get
            {
                return this.paResCheckStatusField;
            }
            set
            {
                this.paResCheckStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string paResStatus
        {
            get
            {
                return this.paResStatusField;
            }
            set
            {
                this.paResStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public threeDSInfo threeDSInfo
        {
            get
            {
                return this.threeDSInfoField;
            }
            set
            {
                this.threeDSInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string veResStatus
        {
            get
            {
                return this.veResStatusField;
            }
            set
            {
                this.veResStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class threeDSInfo
    {
        
        private string cavvField;
        
        private string xidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cavv
        {
            get
            {
                return this.cavvField;
            }
            set
            {
                this.cavvField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string xid
        {
            get
            {
                return this.xidField;
            }
            set
            {
                this.xidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class cardBindingInfo
    {
        
        private string clientIdField;
        
        private string bindingIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentAmountInfo
    {
        
        private transactionState paymentStateField;
        
        private bool paymentStateFieldSpecified;
        
        private long approvedAmountField;
        
        private long depositedAmountField;
        
        private long refundedAmountField;
        
        private long feeAmountField;
        
        private bool feeAmountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public transactionState paymentState
        {
            get
            {
                return this.paymentStateField;
            }
            set
            {
                this.paymentStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentStateSpecified
        {
            get
            {
                return this.paymentStateFieldSpecified;
            }
            set
            {
                this.paymentStateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long approvedAmount
        {
            get
            {
                return this.approvedAmountField;
            }
            set
            {
                this.approvedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long depositedAmount
        {
            get
            {
                return this.depositedAmountField;
            }
            set
            {
                this.depositedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long refundedAmount
        {
            get
            {
                return this.refundedAmountField;
            }
            set
            {
                this.refundedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long feeAmount
        {
            get
            {
                return this.feeAmountField;
            }
            set
            {
                this.feeAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool feeAmountSpecified
        {
            get
            {
                return this.feeAmountFieldSpecified;
            }
            set
            {
                this.feeAmountFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public enum transactionState
    {
        
        /// <remarks/>
        CREATED,
        
        /// <remarks/>
        APPROVED,
        
        /// <remarks/>
        DECLINED,
        
        /// <remarks/>
        REVERSED,
        
        /// <remarks/>
        DEPOSITED,
        
        /// <remarks/>
        REFUNDED,
        
        /// <remarks/>
        PENDING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class bankInfo
    {
        
        private string bankNameField;
        
        private string bankCountryCodeField;
        
        private string bankCountryNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankName
        {
            get
            {
                return this.bankNameField;
            }
            set
            {
                this.bankNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankCountryCode
        {
            get
            {
                return this.bankCountryCodeField;
            }
            set
            {
                this.bankCountryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankCountryName
        {
            get
            {
                return this.bankCountryNameField;
            }
            set
            {
                this.bankCountryNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class payerData
    {
        
        private string emailField;
        
        private string phoneField;
        
        private string postAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class loyaltyInfo
    {
        
        private paymentBonus paymentBonusField;
        
        private awardBonus awardBonusField;
        
        private string loyaltyNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public paymentBonus paymentBonus
        {
            get
            {
                return this.paymentBonusField;
            }
            set
            {
                this.paymentBonusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public awardBonus awardBonus
        {
            get
            {
                return this.awardBonusField;
            }
            set
            {
                this.awardBonusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string loyaltyName
        {
            get
            {
                return this.loyaltyNameField;
            }
            set
            {
                this.loyaltyNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentBonus
    {
        
        private int approvedAmountBonusField;
        
        private bool approvedAmountBonusFieldSpecified;
        
        private int depositedAmountBonusField;
        
        private bool depositedAmountBonusFieldSpecified;
        
        private int refundedAmountBonusField;
        
        private bool refundedAmountBonusFieldSpecified;
        
        private string pcIdField;
        
        private bool successfulField;
        
        private bool successfulFieldSpecified;
        
        private operation paymentOperationField;
        
        private bool paymentOperationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int approvedAmountBonus
        {
            get
            {
                return this.approvedAmountBonusField;
            }
            set
            {
                this.approvedAmountBonusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvedAmountBonusSpecified
        {
            get
            {
                return this.approvedAmountBonusFieldSpecified;
            }
            set
            {
                this.approvedAmountBonusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int depositedAmountBonus
        {
            get
            {
                return this.depositedAmountBonusField;
            }
            set
            {
                this.depositedAmountBonusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositedAmountBonusSpecified
        {
            get
            {
                return this.depositedAmountBonusFieldSpecified;
            }
            set
            {
                this.depositedAmountBonusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int refundedAmountBonus
        {
            get
            {
                return this.refundedAmountBonusField;
            }
            set
            {
                this.refundedAmountBonusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refundedAmountBonusSpecified
        {
            get
            {
                return this.refundedAmountBonusFieldSpecified;
            }
            set
            {
                this.refundedAmountBonusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pcId
        {
            get
            {
                return this.pcIdField;
            }
            set
            {
                this.pcIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool successful
        {
            get
            {
                return this.successfulField;
            }
            set
            {
                this.successfulField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool successfulSpecified
        {
            get
            {
                return this.successfulFieldSpecified;
            }
            set
            {
                this.successfulFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public operation paymentOperation
        {
            get
            {
                return this.paymentOperationField;
            }
            set
            {
                this.paymentOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentOperationSpecified
        {
            get
            {
                return this.paymentOperationFieldSpecified;
            }
            set
            {
                this.paymentOperationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public enum operation
    {
        
        /// <remarks/>
        PAYMENT,
        
        /// <remarks/>
        AWARD,
        
        /// <remarks/>
        REVERSE,
        
        /// <remarks/>
        REFUND_PAYMENT,
        
        /// <remarks/>
        REFUND_AWARD,
        
        /// <remarks/>
        VERIFY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class awardBonus
    {
        
        private int approvedAmountAwardField;
        
        private bool approvedAmountAwardFieldSpecified;
        
        private int depositedAmountAwardField;
        
        private bool depositedAmountAwardFieldSpecified;
        
        private int refundedAmountAwardField;
        
        private bool refundedAmountAwardFieldSpecified;
        
        private string pcIdField;
        
        private bool successfulField;
        
        private bool successfulFieldSpecified;
        
        private operation paymentOperationField;
        
        private bool paymentOperationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int approvedAmountAward
        {
            get
            {
                return this.approvedAmountAwardField;
            }
            set
            {
                this.approvedAmountAwardField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvedAmountAwardSpecified
        {
            get
            {
                return this.approvedAmountAwardFieldSpecified;
            }
            set
            {
                this.approvedAmountAwardFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int depositedAmountAward
        {
            get
            {
                return this.depositedAmountAwardField;
            }
            set
            {
                this.depositedAmountAwardField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositedAmountAwardSpecified
        {
            get
            {
                return this.depositedAmountAwardFieldSpecified;
            }
            set
            {
                this.depositedAmountAwardFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int refundedAmountAward
        {
            get
            {
                return this.refundedAmountAwardField;
            }
            set
            {
                this.refundedAmountAwardField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refundedAmountAwardSpecified
        {
            get
            {
                return this.refundedAmountAwardFieldSpecified;
            }
            set
            {
                this.refundedAmountAwardFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pcId
        {
            get
            {
                return this.pcIdField;
            }
            set
            {
                this.pcIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool successful
        {
            get
            {
                return this.successfulField;
            }
            set
            {
                this.successfulField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool successfulSpecified
        {
            get
            {
                return this.successfulFieldSpecified;
            }
            set
            {
                this.successfulFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public operation paymentOperation
        {
            get
            {
                return this.paymentOperationField;
            }
            set
            {
                this.paymentOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentOperationSpecified
        {
            get
            {
                return this.paymentOperationFieldSpecified;
            }
            set
            {
                this.paymentOperationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class refund
    {
        
        private string referenceNumberField;
        
        private string actionCodeField;
        
        private long amountField;
        
        private string approvalCodeField;
        
        private string dateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string approvalCode
        {
            get
            {
                return this.approvalCodeField;
            }
            set
            {
                this.approvalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class processingOperation
    {
        
        private System.DateTime operationDateField;
        
        private bool operationDateFieldSpecified;
        
        private processingOperationType operationTypeField;
        
        private bool operationTypeFieldSpecified;
        
        private long amountField;
        
        private bool amountFieldSpecified;
        
        private string panField;
        
        private string cardHolderField;
        
        private string expirationField;
        
        private int processingResultCodeField;
        
        private bool processingResultCodeFieldSpecified;
        
        private string currencyCodeField;
        
        private string successField;
        
        private string referenceNumberField;
        
        private string authCodeField;
        
        private string externalIdField;
        
        private string terminalIdField;
        
        private string paresResultField;
        
        private string paresMessageField;
        
        private string paresStatusField;
        
        private string veresEnrolledField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime operationDate
        {
            get
            {
                return this.operationDateField;
            }
            set
            {
                this.operationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationDateSpecified
        {
            get
            {
                return this.operationDateFieldSpecified;
            }
            set
            {
                this.operationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public processingOperationType operationType
        {
            get
            {
                return this.operationTypeField;
            }
            set
            {
                this.operationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationTypeSpecified
        {
            get
            {
                return this.operationTypeFieldSpecified;
            }
            set
            {
                this.operationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cardHolder
        {
            get
            {
                return this.cardHolderField;
            }
            set
            {
                this.cardHolderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiration
        {
            get
            {
                return this.expirationField;
            }
            set
            {
                this.expirationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int processingResultCode
        {
            get
            {
                return this.processingResultCodeField;
            }
            set
            {
                this.processingResultCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool processingResultCodeSpecified
        {
            get
            {
                return this.processingResultCodeFieldSpecified;
            }
            set
            {
                this.processingResultCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string authCode
        {
            get
            {
                return this.authCodeField;
            }
            set
            {
                this.authCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId
        {
            get
            {
                return this.externalIdField;
            }
            set
            {
                this.externalIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string terminalId
        {
            get
            {
                return this.terminalIdField;
            }
            set
            {
                this.terminalIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paresResult
        {
            get
            {
                return this.paresResultField;
            }
            set
            {
                this.paresResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paresMessage
        {
            get
            {
                return this.paresMessageField;
            }
            set
            {
                this.paresMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paresStatus
        {
            get
            {
                return this.paresStatusField;
            }
            set
            {
                this.paresStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string veresEnrolled
        {
            get
            {
                return this.veresEnrolledField;
            }
            set
            {
                this.veresEnrolledField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public enum processingOperationType
    {
        
        /// <remarks/>
        PRE_AUTH,
        
        /// <remarks/>
        COMPLETION,
        
        /// <remarks/>
        REVERSAL_FOR_PRE_AUTH,
        
        /// <remarks/>
        REVERSAL_FOR_COMPLETION,
        
        /// <remarks/>
        REFUND,
        
        /// <remarks/>
        PURCHASE,
        
        /// <remarks/>
        REVERSAL_FOR_PURCHASE,
        
        /// <remarks/>
        COMMUNICATION_REVERSAL,
        
        /// <remarks/>
        REVERSAL_FOR_REFUND,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(extendBindingResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getBindingsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getOrderStatusExtendedResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public abstract partial class abstractServiceResponse
    {
        
        private string errorCodeField;
        
        private string errorMessageField;
        
        private string userMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string errorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string userMessage
        {
            get
            {
                return this.userMessageField;
            }
            set
            {
                this.userMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class extendBindingResponse : abstractServiceResponse
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class getBindingsResponse : abstractServiceResponse
    {
        
        private binding[] bindingsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public binding[] bindings
        {
            get
            {
                return this.bindingsField;
            }
            set
            {
                this.bindingsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class binding
    {
        
        private string bindingIdField;
        
        private string maskedPanField;
        
        private string expiryDateField;
        
        private string clientIdField;
        
        private string paymentWayField;
        
        private string paymentSystemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maskedPan
        {
            get
            {
                return this.maskedPanField;
            }
            set
            {
                this.maskedPanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paymentWay
        {
            get
            {
                return this.paymentWayField;
            }
            set
            {
                this.paymentWayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paymentSystem
        {
            get
            {
                return this.paymentSystemField;
            }
            set
            {
                this.paymentSystemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class recurrentPaymentRequest
    {
        
        private string orderNumberField;
        
        private string languageField;
        
        private string bindingIdField;
        
        private long amountField;
        
        private string currencyField;
        
        private string descriptionField;
        
        private bool preAuthField;
        
        private recurrentPaymentRequestEntry[] additionalParametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool preAuth
        {
            get
            {
                return this.preAuthField;
            }
            set
            {
                this.preAuthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public recurrentPaymentRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class recurrentPaymentRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class googlePayDirectRequest
    {
        
        private string orderNumberField;
        
        private string descriptionField;
        
        private string languageField;
        
        private googlePayDirectRequestEntry[] additionalParametersField;
        
        private bool preAuthField;
        
        private string paymentTokenField;
        
        private string ipField;
        
        private long amountField;
        
        private bool amountFieldSpecified;
        
        private string currencyCodeField;
        
        private string clientIdField;
        
        private string returnUrlField;
        
        private string failUrlField;
        
        private string phoneField;
        
        private string emailField;
        
        private string postAddressField;
        
        private orderBundle orderBundleField;
        
        private int taxSystemField;
        
        private bool taxSystemFieldSpecified;
        
        private string merchantField;
        
        private System.Nullable<orderFeature>[] featuresField;
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSVer2FinishUrlField;
        
        private string threeDSVer2MdOrderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public googlePayDirectRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool preAuth
        {
            get
            {
                return this.preAuthField;
            }
            set
            {
                this.preAuthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string paymentToken
        {
            get
            {
                return this.paymentTokenField;
            }
            set
            {
                this.paymentTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string returnUrl
        {
            get
            {
                return this.returnUrlField;
            }
            set
            {
                this.returnUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string failUrl
        {
            get
            {
                return this.failUrlField;
            }
            set
            {
                this.failUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int taxSystem
        {
            get
            {
                return this.taxSystemField;
            }
            set
            {
                this.taxSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSystemSpecified
        {
            get
            {
                return this.taxSystemFieldSpecified;
            }
            set
            {
                this.taxSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string merchant
        {
            get
            {
                return this.merchantField;
            }
            set
            {
                this.merchantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=18)]
        public System.Nullable<orderFeature>[] features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string threeDSVer2FinishUrl
        {
            get
            {
                return this.threeDSVer2FinishUrlField;
            }
            set
            {
                this.threeDSVer2FinishUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string threeDSVer2MdOrder
        {
            get
            {
                return this.threeDSVer2MdOrderField;
            }
            set
            {
                this.threeDSVer2MdOrderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class googlePayDirectRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public enum orderFeature
    {
        
        /// <remarks/>
        FIXED_BINDING,
        
        /// <remarks/>
        BINDING_NOT_NEEDED,
        
        /// <remarks/>
        FIXED_BONUS_AMOUNT,
        
        /// <remarks/>
        FORCE_TDS,
        
        /// <remarks/>
        FORCE_SSL,
        
        /// <remarks/>
        FRAUD_FORCE_TDS,
        
        /// <remarks/>
        FRAUD_FORCE_SSL,
        
        /// <remarks/>
        AUTO_PAYMENT,
        
        /// <remarks/>
        FORCE_NO_CVC,
        
        /// <remarks/>
        FORCE_FULL_TDS,
        
        /// <remarks/>
        VERIFY,
        
        /// <remarks/>
        SKIP_PAYER_EMAIL_NOTIFY,
        
        /// <remarks/>
        SKIP_PAYER_PHONE_NOTIFY,
        
        /// <remarks/>
        FORCE_GENERATE_ORDERNUMBER,
        
        /// <remarks/>
        PAY_BY_CLIENT,
        
        /// <remarks/>
        WITHOUT_FROM_CARD,
        
        /// <remarks/>
        WITHOUT_TO_CARD,
        
        /// <remarks/>
        REVERSE_AFTER_RECURRENT_INITIALIZE,
        
        /// <remarks/>
        SBOL_PAYMENT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class googlePayError
    {
        
        private string codeField;
        
        private string descriptionField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class googlePayData
    {
        
        private string orderIdField;
        
        private string bindingIdField;
        
        private string redirectUrlField;
        
        private string acsUrlField;
        
        private string paReqField;
        
        private string termUrlField;
        
        private bool is3DSVer2Field;
        
        private bool is3DSVer2FieldSpecified;
        
        private string packedCReqField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSMethodURLField;
        
        private string threeDSMethodURLServerField;
        
        private string threeDSMethodDataPackedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string redirectUrl
        {
            get
            {
                return this.redirectUrlField;
            }
            set
            {
                this.redirectUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string acsUrl
        {
            get
            {
                return this.acsUrlField;
            }
            set
            {
                this.acsUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string paReq
        {
            get
            {
                return this.paReqField;
            }
            set
            {
                this.paReqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string termUrl
        {
            get
            {
                return this.termUrlField;
            }
            set
            {
                this.termUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool is3DSVer2
        {
            get
            {
                return this.is3DSVer2Field;
            }
            set
            {
                this.is3DSVer2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is3DSVer2Specified
        {
            get
            {
                return this.is3DSVer2FieldSpecified;
            }
            set
            {
                this.is3DSVer2FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string packedCReq
        {
            get
            {
                return this.packedCReqField;
            }
            set
            {
                this.packedCReqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string threeDSMethodURL
        {
            get
            {
                return this.threeDSMethodURLField;
            }
            set
            {
                this.threeDSMethodURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string threeDSMethodURLServer
        {
            get
            {
                return this.threeDSMethodURLServerField;
            }
            set
            {
                this.threeDSMethodURLServerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string threeDSMethodDataPacked
        {
            get
            {
                return this.threeDSMethodDataPackedField;
            }
            set
            {
                this.threeDSMethodDataPackedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class googlePayResponse
    {
        
        private bool successField;
        
        private googlePayData dataField;
        
        private googlePayError errorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public googlePayData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public googlePayError error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class googlePayRequest
    {
        
        private string merchantField;
        
        private string orderNumberField;
        
        private string descriptionField;
        
        private string languageField;
        
        private googlePayRequestEntry[] additionalParametersField;
        
        private bool preAuthField;
        
        private string paymentTokenField;
        
        private string ipField;
        
        private long amountField;
        
        private bool amountFieldSpecified;
        
        private string currencyCodeField;
        
        private string clientIdField;
        
        private string returnUrlField;
        
        private string failUrlField;
        
        private string phoneField;
        
        private string emailField;
        
        private string postAddressField;
        
        private System.Nullable<orderFeature>[] featuresField;
        
        private orderBundle orderBundleField;
        
        private int taxSystemField;
        
        private bool taxSystemFieldSpecified;
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSVer2FinishUrlField;
        
        private string threeDSVer2MdOrderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string merchant
        {
            get
            {
                return this.merchantField;
            }
            set
            {
                this.merchantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public googlePayRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool preAuth
        {
            get
            {
                return this.preAuthField;
            }
            set
            {
                this.preAuthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string paymentToken
        {
            get
            {
                return this.paymentTokenField;
            }
            set
            {
                this.paymentTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string returnUrl
        {
            get
            {
                return this.returnUrlField;
            }
            set
            {
                this.returnUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string failUrl
        {
            get
            {
                return this.failUrlField;
            }
            set
            {
                this.failUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=16)]
        public System.Nullable<orderFeature>[] features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public int taxSystem
        {
            get
            {
                return this.taxSystemField;
            }
            set
            {
                this.taxSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSystemSpecified
        {
            get
            {
                return this.taxSystemFieldSpecified;
            }
            set
            {
                this.taxSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string threeDSVer2FinishUrl
        {
            get
            {
                return this.threeDSVer2FinishUrlField;
            }
            set
            {
                this.threeDSVer2FinishUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string threeDSVer2MdOrder
        {
            get
            {
                return this.threeDSVer2MdOrderField;
            }
            set
            {
                this.threeDSVer2MdOrderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class googlePayRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class getBindingsByCardOrIdRequest
    {
        
        private string panField;
        
        private string bindingIdField;
        
        private bool showExpiredField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showExpired
        {
            get
            {
                return this.showExpiredField;
            }
            set
            {
                this.showExpiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentOrderCardPresentResult
    {
        
        private string approvalCodeField;
        
        private int errorCodeField;
        
        private string errorMessageField;
        
        private string refNumField;
        
        private int responseCodeField;
        
        private bool responseCodeFieldSpecified;
        
        private string responseCodeDescriptionField;
        
        private string responseEMVDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string approvalCode
        {
            get
            {
                return this.approvalCodeField;
            }
            set
            {
                this.approvalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string errorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string refNum
        {
            get
            {
                return this.refNumField;
            }
            set
            {
                this.refNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int responseCode
        {
            get
            {
                return this.responseCodeField;
            }
            set
            {
                this.responseCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool responseCodeSpecified
        {
            get
            {
                return this.responseCodeFieldSpecified;
            }
            set
            {
                this.responseCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string responseCodeDescription
        {
            get
            {
                return this.responseCodeDescriptionField;
            }
            set
            {
                this.responseCodeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string responseEMVData
        {
            get
            {
                return this.responseEMVDataField;
            }
            set
            {
                this.responseEMVDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentOrderCardPresentParams
    {
        
        private int inputModeField;
        
        private int authMethodField;
        
        private string track2DataField;
        
        private string pinBlockField;
        
        private string emvdataField;
        
        private serviceParam[] paramsField;
        
        private string terminalIdField;
        
        private string orderIdField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int inputMode
        {
            get
            {
                return this.inputModeField;
            }
            set
            {
                this.inputModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int authMethod
        {
            get
            {
                return this.authMethodField;
            }
            set
            {
                this.authMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string track2Data
        {
            get
            {
                return this.track2DataField;
            }
            set
            {
                this.track2DataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string pinBlock
        {
            get
            {
                return this.pinBlockField;
            }
            set
            {
                this.pinBlockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string emvdata
        {
            get
            {
                return this.emvdataField;
            }
            set
            {
                this.emvdataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string terminalId
        {
            get
            {
                return this.terminalIdField;
            }
            set
            {
                this.terminalIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getOrderStatusExtendedRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class orderStatusRequest
    {
        
        private string orderIdField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class getOrderStatusExtendedRequest : orderStatusRequest
    {
        
        private string merchantOrderNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string merchantOrderNumber
        {
            get
            {
                return this.merchantOrderNumberField;
            }
            set
            {
                this.merchantOrderNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class orderInfo
    {
        
        private serviceParam[] paramsField;
        
        private string ordernumberField;
        
        private long amountField;
        
        private long approvedAmountField;
        
        private long depositedAmountField;
        
        private short currencyCodeField;
        
        private transactionState stateField;
        
        private bool stateFieldSpecified;
        
        private int fraudLevelField;
        
        private string cardholderField;
        
        private string panMaskedField;
        
        private string ipField;
        
        private string actionCodeField;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private string bankNameField;
        
        private string approvalCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ordernumber
        {
            get
            {
                return this.ordernumberField;
            }
            set
            {
                this.ordernumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long approvedAmount
        {
            get
            {
                return this.approvedAmountField;
            }
            set
            {
                this.approvedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long depositedAmount
        {
            get
            {
                return this.depositedAmountField;
            }
            set
            {
                this.depositedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public transactionState state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stateSpecified
        {
            get
            {
                return this.stateFieldSpecified;
            }
            set
            {
                this.stateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int fraudLevel
        {
            get
            {
                return this.fraudLevelField;
            }
            set
            {
                this.fraudLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cardholder
        {
            get
            {
                return this.cardholderField;
            }
            set
            {
                this.cardholderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string panMasked
        {
            get
            {
                return this.panMaskedField;
            }
            set
            {
                this.panMaskedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankName
        {
            get
            {
                return this.bankNameField;
            }
            set
            {
                this.bankNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string approvalCode
        {
            get
            {
                return this.approvalCodeField;
            }
            set
            {
                this.approvalCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class getBindingsRequest
    {
        
        private string clientIdField;
        
        private string bindingIdField;
        
        private bool showExpiredField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showExpired
        {
            get
            {
                return this.showExpiredField;
            }
            set
            {
                this.showExpiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class addParamsRequest
    {
        
        private serviceParam[] paramsField;
        
        private string orderIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class applePayPaymentRequest
    {
        
        private string merchantField;
        
        private string orderNumberField;
        
        private string descriptionField;
        
        private string paymentTokenField;
        
        private string languageField;
        
        private applePayPaymentRequestEntry[] additionalParametersField;
        
        private bool preAuthField;
        
        private string clientIdField;
        
        private bool recurrentField;
        
        private bool recurrentInitializeField;
        
        private string ipField;
        
        private string phoneField;
        
        private string emailField;
        
        private string postAddressField;
        
        private System.Nullable<orderFeature>[] featuresField;
        
        private orderBundle orderBundleField;
        
        private int taxSystemField;
        
        private bool taxSystemFieldSpecified;
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string merchant
        {
            get
            {
                return this.merchantField;
            }
            set
            {
                this.merchantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string paymentToken
        {
            get
            {
                return this.paymentTokenField;
            }
            set
            {
                this.paymentTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public applePayPaymentRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool preAuth
        {
            get
            {
                return this.preAuthField;
            }
            set
            {
                this.preAuthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public bool recurrent
        {
            get
            {
                return this.recurrentField;
            }
            set
            {
                this.recurrentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public bool recurrentInitialize
        {
            get
            {
                return this.recurrentInitializeField;
            }
            set
            {
                this.recurrentInitializeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=14)]
        public System.Nullable<orderFeature>[] features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int taxSystem
        {
            get
            {
                return this.taxSystemField;
            }
            set
            {
                this.taxSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSystemSpecified
        {
            get
            {
                return this.taxSystemFieldSpecified;
            }
            set
            {
                this.taxSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class applePayPaymentRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentOrderBindingParams
    {
        
        private serviceParam[] paramsField;
        
        private string mdOrderField;
        
        private string bindingIdField;
        
        private string languageField;
        
        private string ipField;
        
        private string cvcField;
        
        private string emailField;
        
        private string postAddressField;
        
        private string pointsAmountField;
        
        private string loyaltyIdField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSVer2FinishUrlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mdOrder
        {
            get
            {
                return this.mdOrderField;
            }
            set
            {
                this.mdOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cvc
        {
            get
            {
                return this.cvcField;
            }
            set
            {
                this.cvcField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pointsAmount
        {
            get
            {
                return this.pointsAmountField;
            }
            set
            {
                this.pointsAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string loyaltyId
        {
            get
            {
                return this.loyaltyIdField;
            }
            set
            {
                this.loyaltyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string threeDSVer2FinishUrl
        {
            get
            {
                return this.threeDSVer2FinishUrlField;
            }
            set
            {
                this.threeDSVer2FinishUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class error
    {
        
        private string codeField;
        
        private string descriptionField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class data
    {
        
        private string orderIdField;
        
        private string bindingIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class applePayPaymentResponse
    {
        
        private bool successField;
        
        private data dataField;
        
        private error errorField;
        
        private getOrderStatusExtendedResponse orderStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public data data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public error error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public getOrderStatusExtendedResponse orderStatus
        {
            get
            {
                return this.orderStatusField;
            }
            set
            {
                this.orderStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class applePayDirectPaymentRequest
    {
        
        private string orderNumberField;
        
        private string descriptionField;
        
        private string paymentTokenField;
        
        private string languageField;
        
        private applePayDirectPaymentRequestEntry[] additionalParametersField;
        
        private bool preAuthField;
        
        private string clientIdField;
        
        private string ipField;
        
        private string phoneField;
        
        private string emailField;
        
        private string postAddressField;
        
        private orderBundle orderBundleField;
        
        private int taxSystemField;
        
        private bool taxSystemFieldSpecified;
        
        private string merchantField;
        
        private System.Nullable<orderFeature>[] featuresField;
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string paymentToken
        {
            get
            {
                return this.paymentTokenField;
            }
            set
            {
                this.paymentTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public applePayDirectPaymentRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool preAuth
        {
            get
            {
                return this.preAuthField;
            }
            set
            {
                this.preAuthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int taxSystem
        {
            get
            {
                return this.taxSystemField;
            }
            set
            {
                this.taxSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSystemSpecified
        {
            get
            {
                return this.taxSystemFieldSpecified;
            }
            set
            {
                this.taxSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string merchant
        {
            get
            {
                return this.merchantField;
            }
            set
            {
                this.merchantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=14)]
        public System.Nullable<orderFeature>[] features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class applePayDirectPaymentRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class orderParams
    {
        
        private string returnUrlField;
        
        private string failUrlField;
        
        private string merchantLoginField;
        
        private string emailField;
        
        private string postAddressField;
        
        private serviceParam[] paramsField;
        
        private string clientIdField;
        
        private orderBundle orderBundleField;
        
        private orderFeature[] featuresField;
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        private string merchantOrderNumberField;
        
        private string descriptionField;
        
        private long amountField;
        
        private bool amountFieldSpecified;
        
        private string currencyField;
        
        private string languageField;
        
        private string pageViewField;
        
        private int sessionTimeoutSecsField;
        
        private bool sessionTimeoutSecsFieldSpecified;
        
        private int taxSystemField;
        
        private bool taxSystemFieldSpecified;
        
        private string bindingIdField;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        private System.DateTime autocompletionDateField;
        
        private bool autocompletionDateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string returnUrl
        {
            get
            {
                return this.returnUrlField;
            }
            set
            {
                this.returnUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string failUrl
        {
            get
            {
                return this.failUrlField;
            }
            set
            {
                this.failUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string merchantLogin
        {
            get
            {
                return this.merchantLoginField;
            }
            set
            {
                this.merchantLoginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string postAddress
        {
            get
            {
                return this.postAddressField;
            }
            set
            {
                this.postAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("feature", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public orderFeature[] features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string merchantOrderNumber
        {
            get
            {
                return this.merchantOrderNumberField;
            }
            set
            {
                this.merchantOrderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pageView
        {
            get
            {
                return this.pageViewField;
            }
            set
            {
                this.pageViewField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sessionTimeoutSecs
        {
            get
            {
                return this.sessionTimeoutSecsField;
            }
            set
            {
                this.sessionTimeoutSecsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sessionTimeoutSecsSpecified
        {
            get
            {
                return this.sessionTimeoutSecsFieldSpecified;
            }
            set
            {
                this.sessionTimeoutSecsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int taxSystem
        {
            get
            {
                return this.taxSystemField;
            }
            set
            {
                this.taxSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSystemSpecified
        {
            get
            {
                return this.taxSystemFieldSpecified;
            }
            set
            {
                this.taxSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified
        {
            get
            {
                return this.expirationDateFieldSpecified;
            }
            set
            {
                this.expirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime autocompletionDate
        {
            get
            {
                return this.autocompletionDateField;
            }
            set
            {
                this.autocompletionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autocompletionDateSpecified
        {
            get
            {
                return this.autocompletionDateFieldSpecified;
            }
            set
            {
                this.autocompletionDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class androidError
    {
        
        private string codeField;
        
        private string descriptionField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class androidData
    {
        
        private string orderIdField;
        
        private string bindingIdField;
        
        private string acsUrlField;
        
        private string paReqField;
        
        private string termUrlField;
        
        private bool is3DSVer2Field;
        
        private bool is3DSVer2FieldSpecified;
        
        private string packedCReqField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSMethodURLField;
        
        private string threeDSMethodURLServerField;
        
        private string threeDSMethodDataPackedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string acsUrl
        {
            get
            {
                return this.acsUrlField;
            }
            set
            {
                this.acsUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string paReq
        {
            get
            {
                return this.paReqField;
            }
            set
            {
                this.paReqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string termUrl
        {
            get
            {
                return this.termUrlField;
            }
            set
            {
                this.termUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool is3DSVer2
        {
            get
            {
                return this.is3DSVer2Field;
            }
            set
            {
                this.is3DSVer2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is3DSVer2Specified
        {
            get
            {
                return this.is3DSVer2FieldSpecified;
            }
            set
            {
                this.is3DSVer2FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string packedCReq
        {
            get
            {
                return this.packedCReqField;
            }
            set
            {
                this.packedCReqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string threeDSMethodURL
        {
            get
            {
                return this.threeDSMethodURLField;
            }
            set
            {
                this.threeDSMethodURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string threeDSMethodURLServer
        {
            get
            {
                return this.threeDSMethodURLServerField;
            }
            set
            {
                this.threeDSMethodURLServerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string threeDSMethodDataPacked
        {
            get
            {
                return this.threeDSMethodDataPackedField;
            }
            set
            {
                this.threeDSMethodDataPackedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class androidPayPaymentResponse
    {
        
        private bool successField;
        
        private androidData dataField;
        
        private androidError errorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public androidData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public androidError error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class androidPayPaymentRequest
    {
        
        private string merchantField;
        
        private string orderNumberField;
        
        private string descriptionField;
        
        private string languageField;
        
        private androidPayPaymentRequestEntry[] additionalParametersField;
        
        private bool preAuthField;
        
        private string paymentTokenField;
        
        private string ipField;
        
        private long amountField;
        
        private bool amountFieldSpecified;
        
        private string currencyCodeField;
        
        private string clientIdField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSVer2FinishUrlField;
        
        private string threeDSVer2MdOrderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string merchant
        {
            get
            {
                return this.merchantField;
            }
            set
            {
                this.merchantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public androidPayPaymentRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool preAuth
        {
            get
            {
                return this.preAuthField;
            }
            set
            {
                this.preAuthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string paymentToken
        {
            get
            {
                return this.paymentTokenField;
            }
            set
            {
                this.paymentTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string threeDSVer2FinishUrl
        {
            get
            {
                return this.threeDSVer2FinishUrlField;
            }
            set
            {
                this.threeDSVer2FinishUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string threeDSVer2MdOrder
        {
            get
            {
                return this.threeDSVer2MdOrderField;
            }
            set
            {
                this.threeDSVer2MdOrderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class androidPayPaymentRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class createBindingNoPaymentResponse
    {
        
        private string bindingIdField;
        
        private string cardholderNameField;
        
        private string clientIdField;
        
        private int errorCodeField;
        
        private string errorMessageField;
        
        private string expiryDateField;
        
        private string maskedPanField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string cardholderName
        {
            get
            {
                return this.cardholderNameField;
            }
            set
            {
                this.cardholderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string errorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string expiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string maskedPan
        {
            get
            {
                return this.maskedPanField;
            }
            set
            {
                this.maskedPanField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class createBindingNoPaymentRequest
    {
        
        private createBindingNoPaymentRequestEntry[] additionalParametersField;
        
        private string cardholderNameField;
        
        private string clientIdField;
        
        private string emailField;
        
        private string expiryDateField;
        
        private string panField;
        
        private string phoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public createBindingNoPaymentRequestEntry[] additionalParameters
        {
            get
            {
                return this.additionalParametersField;
            }
            set
            {
                this.additionalParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string cardholderName
        {
            get
            {
                return this.cardholderNameField;
            }
            set
            {
                this.cardholderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string expiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class createBindingNoPaymentRequestEntry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(basicLoyaltyOperation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(sbrfMilesLoyaltyOperation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(sbrfSpasiboLoyaltyOperation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public abstract partial class loyaltyOperation
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(sbrfMilesLoyaltyOperation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(sbrfSpasiboLoyaltyOperation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class basicLoyaltyOperation : loyaltyOperation
    {
        
        private long amountField;
        
        private string errorCodeField;
        
        private string errorDescriptionField;
        
        private operationType operationField;
        
        private bool operationFieldSpecified;
        
        private bool successfulField;
        
        private string transactionIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string errorDescription
        {
            get
            {
                return this.errorDescriptionField;
            }
            set
            {
                this.errorDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public operationType operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationSpecified
        {
            get
            {
                return this.operationFieldSpecified;
            }
            set
            {
                this.operationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool successful
        {
            get
            {
                return this.successfulField;
            }
            set
            {
                this.successfulField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string transactionId
        {
            get
            {
                return this.transactionIdField;
            }
            set
            {
                this.transactionIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public enum operationType
    {
        
        /// <remarks/>
        PAYMENT,
        
        /// <remarks/>
        AWARD,
        
        /// <remarks/>
        REVERSE,
        
        /// <remarks/>
        REFUND_PAYMENT,
        
        /// <remarks/>
        REFUND_AWARD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class sbrfMilesLoyaltyOperation : basicLoyaltyOperation
    {
        
        private long pcIdField;
        
        private bool pcIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long pcId
        {
            get
            {
                return this.pcIdField;
            }
            set
            {
                this.pcIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pcIdSpecified
        {
            get
            {
                return this.pcIdFieldSpecified;
            }
            set
            {
                this.pcIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class sbrfSpasiboLoyaltyOperation : basicLoyaltyOperation
    {
        
        private long pcIdField;
        
        private bool pcIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long pcId
        {
            get
            {
                return this.pcIdField;
            }
            set
            {
                this.pcIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pcIdSpecified
        {
            get
            {
                return this.pcIdFieldSpecified;
            }
            set
            {
                this.pcIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(orderStatusResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(paymentOrderOtherWayResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(finishThreeDSResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getLastOrdersForMerchantsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(verifyEnrollmentResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(paymentOrderResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(registerOrderResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(orderResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public abstract partial class abstractResponse
    {
        
        private loyaltyOperation[] operationsField;
        
        private int errorCodeField;
        
        private string errorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("operations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public loyaltyOperation[] operations
        {
            get
            {
                return this.operationsField;
            }
            set
            {
                this.operationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string errorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class orderStatusResponse : abstractResponse
    {
        
        private serviceParam[] paramsField;
        
        private orderBundle orderBundleField;
        
        private int orderStatusField;
        
        private string orderNumberField;
        
        private string panField;
        
        private string hpanField;
        
        private string expirationField;
        
        private string cardholderNameField;
        
        private long amountField;
        
        private string currencyField;
        
        private string approvalCodeField;
        
        private int authCodeField;
        
        private string ipField;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private string orderDescriptionField;
        
        private string merchantLoginField;
        
        private string actionCodeDescriptionField;
        
        private string clientIdField;
        
        private string bindingIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public orderBundle orderBundle
        {
            get
            {
                return this.orderBundleField;
            }
            set
            {
                this.orderBundleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int orderStatus
        {
            get
            {
                return this.orderStatusField;
            }
            set
            {
                this.orderStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hpan
        {
            get
            {
                return this.hpanField;
            }
            set
            {
                this.hpanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiration
        {
            get
            {
                return this.expirationField;
            }
            set
            {
                this.expirationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cardholderName
        {
            get
            {
                return this.cardholderNameField;
            }
            set
            {
                this.cardholderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string approvalCode
        {
            get
            {
                return this.approvalCodeField;
            }
            set
            {
                this.approvalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int authCode
        {
            get
            {
                return this.authCodeField;
            }
            set
            {
                this.authCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderDescription
        {
            get
            {
                return this.orderDescriptionField;
            }
            set
            {
                this.orderDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string merchantLogin
        {
            get
            {
                return this.merchantLoginField;
            }
            set
            {
                this.merchantLoginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actionCodeDescription
        {
            get
            {
                return this.actionCodeDescriptionField;
            }
            set
            {
                this.actionCodeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentOrderOtherWayResult : abstractResponse
    {
        
        private string infoField;
        
        private string redirectField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string redirect
        {
            get
            {
                return this.redirectField;
            }
            set
            {
                this.redirectField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class finishThreeDSResponse : abstractResponse
    {
        
        private string returnUrlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returnUrl
        {
            get
            {
                return this.returnUrlField;
            }
            set
            {
                this.returnUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class getLastOrdersForMerchantsResponse : abstractResponse
    {
        
        private getOrderStatusExtendedResponse[] orderStatusesField;
        
        private long totalCountField;
        
        private int pageField;
        
        private int pageSizeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("orderStatuses", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public getOrderStatusExtendedResponse[] orderStatuses
        {
            get
            {
                return this.orderStatusesField;
            }
            set
            {
                this.orderStatusesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long totalCount
        {
            get
            {
                return this.totalCountField;
            }
            set
            {
                this.totalCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int page
        {
            get
            {
                return this.pageField;
            }
            set
            {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int pageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class verifyEnrollmentResponse : abstractResponse
    {
        
        private string isEnrolledField;
        
        private string emitterNameField;
        
        private string emitterCountryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isEnrolled
        {
            get
            {
                return this.isEnrolledField;
            }
            set
            {
                this.isEnrolledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string emitterName
        {
            get
            {
                return this.emitterNameField;
            }
            set
            {
                this.emitterNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string emitterCountryCode
        {
            get
            {
                return this.emitterCountryCodeField;
            }
            set
            {
                this.emitterCountryCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentOrderResult : abstractResponse
    {
        
        private bool is3DSVer2Field;
        
        private bool is3DSVer2FieldSpecified;
        
        private string packedCReqField;
        
        private string threeDSServerTransIdField;
        
        private string threeDSMethodURLField;
        
        private string threeDSMethodURLServerField;
        
        private string threeDSMethodDataPackedField;
        
        private string infoField;
        
        private string redirectField;
        
        private string acsUrlField;
        
        private string paReqField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool is3DSVer2
        {
            get
            {
                return this.is3DSVer2Field;
            }
            set
            {
                this.is3DSVer2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is3DSVer2Specified
        {
            get
            {
                return this.is3DSVer2FieldSpecified;
            }
            set
            {
                this.is3DSVer2FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string packedCReq
        {
            get
            {
                return this.packedCReqField;
            }
            set
            {
                this.packedCReqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string threeDSMethodURL
        {
            get
            {
                return this.threeDSMethodURLField;
            }
            set
            {
                this.threeDSMethodURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string threeDSMethodURLServer
        {
            get
            {
                return this.threeDSMethodURLServerField;
            }
            set
            {
                this.threeDSMethodURLServerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string threeDSMethodDataPacked
        {
            get
            {
                return this.threeDSMethodDataPackedField;
            }
            set
            {
                this.threeDSMethodDataPackedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string redirect
        {
            get
            {
                return this.redirectField;
            }
            set
            {
                this.redirectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acsUrl
        {
            get
            {
                return this.acsUrlField;
            }
            set
            {
                this.acsUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paReq
        {
            get
            {
                return this.paReqField;
            }
            set
            {
                this.paReqField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class registerOrderResponse : abstractResponse
    {
        
        private string formUrlField;
        
        private string orderIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string formUrl
        {
            get
            {
                return this.formUrlField;
            }
            set
            {
                this.formUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class orderResult : abstractResponse
    {
        
        private long amountField;
        
        private bool amountFieldSpecified;
        
        private string currencyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class itemAttribute
    {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class tax
    {
        
        private long taxSumField;
        
        private bool taxSumFieldSpecified;
        
        private int taxTypeField;
        
        private bool taxTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long taxSum
        {
            get
            {
                return this.taxSumField;
            }
            set
            {
                this.taxSumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSumSpecified
        {
            get
            {
                return this.taxSumFieldSpecified;
            }
            set
            {
                this.taxSumFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int taxType
        {
            get
            {
                return this.taxTypeField;
            }
            set
            {
                this.taxTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxTypeSpecified
        {
            get
            {
                return this.taxTypeFieldSpecified;
            }
            set
            {
                this.taxTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class agentInterest
    {
        
        private string interestTypeField;
        
        private string interestValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string interestType
        {
            get
            {
                return this.interestTypeField;
            }
            set
            {
                this.interestTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string interestValue
        {
            get
            {
                return this.interestValueField;
            }
            set
            {
                this.interestValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class discount
    {
        
        private string discountTypeField;
        
        private string discountValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string discountType
        {
            get
            {
                return this.discountTypeField;
            }
            set
            {
                this.discountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string discountValue
        {
            get
            {
                return this.discountValueField;
            }
            set
            {
                this.discountValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class quantity
    {
        
        private string measureField;
        
        private float valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public float Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(depositOrderParams))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(loginParams))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(paymentOrderOtherWayParams))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(finishThreeDSVer2Request))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(finishThreeDSRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(reversalOrderParams))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(rawPositionRefundRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(rawSumRefundRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getLastOrdersForMerchantsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(extendBindingRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(refundOrderParams))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public abstract partial class abstractServiceRequest
    {
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class depositOrderParams : abstractServiceRequest
    {
        
        private item[] depositItemsField;
        
        private serviceParam[] paramsField;
        
        private agent agentField;
        
        private string supplierPhonesField;
        
        private string orderIdField;
        
        private long depositAmountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("items", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public item[] depositItems
        {
            get
            {
                return this.depositItemsField;
            }
            set
            {
                this.depositItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public agent agent
        {
            get
            {
                return this.agentField;
            }
            set
            {
                this.agentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string supplierPhones
        {
            get
            {
                return this.supplierPhonesField;
            }
            set
            {
                this.supplierPhonesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long depositAmount
        {
            get
            {
                return this.depositAmountField;
            }
            set
            {
                this.depositAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class loginParams : abstractServiceRequest
    {
        
        private string loginField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class paymentOrderOtherWayParams : abstractServiceRequest
    {
        
        private string orderIdField;
        
        private string paymentWayField;
        
        private string ipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paymentWay
        {
            get
            {
                return this.paymentWayField;
            }
            set
            {
                this.paymentWayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ip
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class finishThreeDSVer2Request : abstractServiceRequest
    {
        
        private string threeDSServerTransIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string threeDSServerTransId
        {
            get
            {
                return this.threeDSServerTransIdField;
            }
            set
            {
                this.threeDSServerTransIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class finishThreeDSRequest : abstractServiceRequest
    {
        
        private string mdField;
        
        private string paResField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string md
        {
            get
            {
                return this.mdField;
            }
            set
            {
                this.mdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paRes
        {
            get
            {
                return this.paResField;
            }
            set
            {
                this.paResField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class reversalOrderParams : abstractServiceRequest
    {
        
        private serviceParam[] paramsField;
        
        private string orderIdField;
        
        private string merchantLoginField;
        
        private string orderNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public serviceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string merchantLogin
        {
            get
            {
                return this.merchantLoginField;
            }
            set
            {
                this.merchantLoginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class rawPositionRefundRequest : abstractServiceRequest
    {
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        private string orderIdField;
        
        private string positionIdField;
        
        private long itemAmountField;
        
        private bool itemAmountFieldSpecified;
        
        private long expectedDepositedAmountField;
        
        private bool expectedDepositedAmountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string positionId
        {
            get
            {
                return this.positionIdField;
            }
            set
            {
                this.positionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long itemAmount
        {
            get
            {
                return this.itemAmountField;
            }
            set
            {
                this.itemAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemAmountSpecified
        {
            get
            {
                return this.itemAmountFieldSpecified;
            }
            set
            {
                this.itemAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long expectedDepositedAmount
        {
            get
            {
                return this.expectedDepositedAmountField;
            }
            set
            {
                this.expectedDepositedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedDepositedAmountSpecified
        {
            get
            {
                return this.expectedDepositedAmountFieldSpecified;
            }
            set
            {
                this.expectedDepositedAmountFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class rawSumRefundRequest : abstractServiceRequest
    {
        
        private additionalOfdParam[] additionalOfdParamsField;
        
        private string orderIdField;
        
        private string nameField;
        
        private long itemAmountField;
        
        private bool itemAmountFieldSpecified;
        
        private string itemCodeField;
        
        private taxType taxField;
        
        private bool taxFieldSpecified;
        
        private long expectedDepositedAmountField;
        
        private bool expectedDepositedAmountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalOfdParams", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public additionalOfdParam[] additionalOfdParams
        {
            get
            {
                return this.additionalOfdParamsField;
            }
            set
            {
                this.additionalOfdParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long itemAmount
        {
            get
            {
                return this.itemAmountField;
            }
            set
            {
                this.itemAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemAmountSpecified
        {
            get
            {
                return this.itemAmountFieldSpecified;
            }
            set
            {
                this.itemAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string itemCode
        {
            get
            {
                return this.itemCodeField;
            }
            set
            {
                this.itemCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public taxType tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxSpecified
        {
            get
            {
                return this.taxFieldSpecified;
            }
            set
            {
                this.taxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long expectedDepositedAmount
        {
            get
            {
                return this.expectedDepositedAmountField;
            }
            set
            {
                this.expectedDepositedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedDepositedAmountSpecified
        {
            get
            {
                return this.expectedDepositedAmountFieldSpecified;
            }
            set
            {
                this.expectedDepositedAmountFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public enum taxType
    {
        
        /// <remarks/>
        NONE,
        
        /// <remarks/>
        VAT_0,
        
        /// <remarks/>
        VAT_10,
        
        /// <remarks/>
        VAT_18,
        
        /// <remarks/>
        VAT_110,
        
        /// <remarks/>
        VAT_118,
        
        /// <remarks/>
        VAT_20,
        
        /// <remarks/>
        VAT_120,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class getLastOrdersForMerchantsRequest : abstractServiceRequest
    {
        
        private int pageField;
        
        private int sizeField;
        
        private System.DateTime fromField;
        
        private bool fromFieldSpecified;
        
        private System.DateTime toField;
        
        private bool toFieldSpecified;
        
        private string[] transactionStatesField;
        
        private string[] merchantsField;
        
        private bool searchByCreatedDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int page
        {
            get
            {
                return this.pageField;
            }
            set
            {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fromSpecified
        {
            get
            {
                return this.fromFieldSpecified;
            }
            set
            {
                this.fromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toSpecified
        {
            get
            {
                return this.toFieldSpecified;
            }
            set
            {
                this.toFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("transactionStates", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] transactionStates
        {
            get
            {
                return this.transactionStatesField;
            }
            set
            {
                this.transactionStatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("merchants", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] merchants
        {
            get
            {
                return this.merchantsField;
            }
            set
            {
                this.merchantsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool searchByCreatedDate
        {
            get
            {
                return this.searchByCreatedDateField;
            }
            set
            {
                this.searchByCreatedDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://engine.paymentgate.ru/webservices/merchant")]
    public partial class extendBindingRequest : abstractServiceRequest
    {
        
        private string bindingIdField;
        
        private string newExpiryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingId
        {
            get
            {
                return this.bindingIdField;
            }
            set
            {
                this.bindingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string newExpiry
        {
            get
            {
                return this.newExpiryField;
            }
            set
            {
                this.newExpiryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getLastOrders", WrapperNamespace="http://engine.paymentgate.ru/webservices/merchant", IsWrapped=true)]
    public partial class getLastOrders
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public System.DateTime from;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public System.DateTime to;
        
        public getLastOrders()
        {
        }
        
        public getLastOrders(System.DateTime from, System.DateTime to)
        {
            this.from = from;
            this.to = to;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getLastOrdersResponse", WrapperNamespace="http://engine.paymentgate.ru/webservices/merchant", IsWrapped=true)]
    public partial class getLastOrdersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenc22.orderInfo[] @return;
        
        public getLastOrdersResponse()
        {
        }
        
        public getLastOrdersResponse(ServiceReferenc22.orderInfo[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface MerchantServiceChannel : ServiceReferenc22.MerchantService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class MerchantServiceClient : System.ServiceModel.ClientBase<ServiceReferenc22.MerchantService>, ServiceReferenc22.MerchantService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MerchantServiceClient() : 
                base(MerchantServiceClient.GetDefaultBinding(), MerchantServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.MerchantServiceImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MerchantServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MerchantServiceClient.GetBindingForEndpoint(endpointConfiguration), MerchantServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MerchantServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MerchantServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MerchantServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MerchantServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MerchantServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> refundOrderAsync(ServiceReferenc22.refundOrderParams order)
        {
            return base.Channel.refundOrderAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.createBindingNoPaymentResponse> createBindingNoPaymentAsync(ServiceReferenc22.createBindingNoPaymentRequest request)
        {
            return base.Channel.createBindingNoPaymentAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> unBindCardAsync(string bindingId)
        {
            return base.Channel.unBindCardAsync(bindingId);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.androidPayPaymentResponse> androidPayAsync(ServiceReferenc22.androidPayPaymentRequest arg0)
        {
            return base.Channel.androidPayAsync(arg0);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.registerOrderResponse> registerOrderAsync(ServiceReferenc22.orderParams order)
        {
            return base.Channel.registerOrderAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.applePayPaymentResponse> applePayDirectAsync(ServiceReferenc22.applePayDirectPaymentRequest arg0)
        {
            return base.Channel.applePayDirectAsync(arg0);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderResult> paymentOrderBindingAsync(ServiceReferenc22.paymentOrderBindingParams order)
        {
            return base.Channel.paymentOrderBindingAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.applePayPaymentResponse> applePayAsync(ServiceReferenc22.applePayPaymentRequest arg0)
        {
            return base.Channel.applePayAsync(arg0);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> addParamsAsync(ServiceReferenc22.addParamsRequest request)
        {
            return base.Channel.addParamsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.getBindingsResponse> getBindingsAsync(ServiceReferenc22.getBindingsRequest request)
        {
            return base.Channel.getBindingsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenc22.getLastOrdersResponse> ServiceReferenc22.MerchantService.getLastOrdersAsync(ServiceReferenc22.getLastOrders request)
        {
            return base.Channel.getLastOrdersAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.getLastOrdersResponse> getLastOrdersAsync(System.DateTime from, System.DateTime to)
        {
            ServiceReferenc22.getLastOrders inValue = new ServiceReferenc22.getLastOrders();
            inValue.from = from;
            inValue.to = to;
            return ((ServiceReferenc22.MerchantService)(this)).getLastOrdersAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.getOrderStatusExtendedResponse> getOrderStatusExtendedAsync(ServiceReferenc22.getOrderStatusExtendedRequest order)
        {
            return base.Channel.getOrderStatusExtendedAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderCardPresentResult> paymentOrderCardPresentAsync(ServiceReferenc22.paymentOrderCardPresentParams order)
        {
            return base.Channel.paymentOrderCardPresentAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.registerOrderResponse> registerOrderPreAuthAsync(ServiceReferenc22.orderParams order)
        {
            return base.Channel.registerOrderPreAuthAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.extendBindingResponse> extendBindingAsync(ServiceReferenc22.extendBindingRequest request)
        {
            return base.Channel.extendBindingAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.verifyEnrollmentResponse> verifyEnrollmentAsync(string pan)
        {
            return base.Channel.verifyEnrollmentAsync(pan);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.getLastOrdersForMerchantsResponse> getLastOrdersForMerchantsAsync(ServiceReferenc22.getLastOrdersForMerchantsRequest request)
        {
            return base.Channel.getLastOrdersForMerchantsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> updateSSLCardListAsync(string mdorder)
        {
            return base.Channel.updateSSLCardListAsync(mdorder);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.getBindingsResponse> getBindingsByCardOrIdAsync(ServiceReferenc22.getBindingsByCardOrIdRequest request)
        {
            return base.Channel.getBindingsByCardOrIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.googlePayResponse> googlePayAsync(ServiceReferenc22.googlePayRequest arg0)
        {
            return base.Channel.googlePayAsync(arg0);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> processRawSumOrderRefundAsync(ServiceReferenc22.rawSumRefundRequest order)
        {
            return base.Channel.processRawSumOrderRefundAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.googlePayResponse> googlePayDirectAsync(ServiceReferenc22.googlePayDirectRequest arg0)
        {
            return base.Channel.googlePayDirectAsync(arg0);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> processRawPositionOrderRefundAsync(ServiceReferenc22.rawPositionRefundRequest order)
        {
            return base.Channel.processRawPositionOrderRefundAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> reverseOrderAsync(ServiceReferenc22.reversalOrderParams order)
        {
            return base.Channel.reverseOrderAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> bindCardAsync(string bindingId)
        {
            return base.Channel.bindCardAsync(bindingId);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.finishThreeDSResponse> finishThreeDsAsync(ServiceReferenc22.finishThreeDSRequest request)
        {
            return base.Channel.finishThreeDsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> updateBlackCardListAsync(string mdorder)
        {
            return base.Channel.updateBlackCardListAsync(mdorder);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.finishThreeDSResponse> finishThreeDsVer2Async(ServiceReferenc22.finishThreeDSVer2Request request)
        {
            return base.Channel.finishThreeDsVer2Async(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.recurrentPaymentResponse> recurrentPaymentAsync(ServiceReferenc22.recurrentPaymentRequest arg0)
        {
            return base.Channel.recurrentPaymentAsync(arg0);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderOtherWayResult> paymentOrderOtherWayAsync(ServiceReferenc22.paymentOrderOtherWayParams order)
        {
            return base.Channel.paymentOrderOtherWayAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> checkAuthenticateAsync(ServiceReferenc22.loginParams login)
        {
            return base.Channel.checkAuthenticateAsync(login);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.samsungPayPaymentResponse> samsungPayAsync(ServiceReferenc22.samsungPayPaymentRequest arg0)
        {
            return base.Channel.samsungPayAsync(arg0);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> updateWhiteCardListAsync(string mdorder)
        {
            return base.Channel.updateWhiteCardListAsync(mdorder);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderResult> depositOrderAsync(ServiceReferenc22.depositOrderParams order)
        {
            return base.Channel.depositOrderAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.orderStatusResponse> getOrderStatusAsync(ServiceReferenc22.orderStatusRequest order)
        {
            return base.Channel.getOrderStatusAsync(order);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenc22.paymentOrderResult> paymentOrderAsync(ServiceReferenc22.paymentOrderParams order)
        {
            return base.Channel.paymentOrderAsync(order);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.MerchantServiceImplPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.MerchantServiceImplPort))
            {
                return new System.ServiceModel.EndpointAddress("https://3dsec.sberbank.ru/payment/webservices/merchant-ws");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MerchantServiceClient.GetBindingForEndpoint(EndpointConfiguration.MerchantServiceImplPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MerchantServiceClient.GetEndpointAddress(EndpointConfiguration.MerchantServiceImplPort);
        }
        
        public enum EndpointConfiguration
        {
            
            MerchantServiceImplPort,
        }
    }
}
