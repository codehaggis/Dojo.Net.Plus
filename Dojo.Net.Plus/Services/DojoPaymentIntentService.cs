using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Dojo.Net.Plus.Api;
using Dojo.Net.Plus.Api.PaymentIntents;

namespace Dojo.Net.Plus.Services
{
    internal sealed class DojoPaymentIntentService : BaseService, IDojoPaymentIntentService
    {
        // inject the refit client
        private readonly IDojoApi _dojoApi;

        public DojoPaymentIntentService(IDojoApi dojoApi)
        {
            _dojoApi = dojoApi;
        }
        
        public async Task<DojoResponse<PaymentIntentResponse>> CreatePaymentIntentAsync(CreatePaymentIntent createPaymentIntent)
        {
            // validation
            if (createPaymentIntent.Amount is null || createPaymentIntent.Amount.Value == 0)
            {
                throw new ArgumentException("Amount cannot be zero.");
            }
            
            return await ExecuteApiCallAsync(() => _dojoApi.CreatePaymentIntent(createPaymentIntent));
            
        }

        public async Task<DojoResponse<PaymentIntentResponse>> GetPaymentIntentAsync(string paymentIntentId)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }

            return await ExecuteApiCallAsync(() => _dojoApi.GetPaymentIntent(paymentIntentId));
           
        }

        public async Task<DojoResponse<PaymentIntentResponse>> DeletePaymentIntentAsync(string paymentIntentId)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }
            
            return await ExecuteApiCallAsync(() => _dojoApi.CancelPaymentIntent(paymentIntentId));
            
        }

        public async Task<DojoResponse<CaptureResponse>> CapturePaymentIntentAsync(string paymentIntentId, CaptureRequest captureRequest)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }

            if (captureRequest == null)
            {
                throw new ArgumentNullException(nameof(captureRequest));
            }


            return await ExecuteApiCallAsync(() => _dojoApi.CapturePaymentIntent(paymentIntentId, captureRequest));
                
        }
        
        public async Task<DojoResponse<CaptureResponse>> CapturePaymentIntentAsync(string paymentIntentId, int amount)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }

            var captureRequest = new CaptureRequest
            {
                Amount = amount
            };

            return await ExecuteApiCallAsync(() => _dojoApi.CapturePaymentIntent(paymentIntentId, captureRequest));
                
        }

        public async Task<DojoResponse<PaymentIntentResponse>> UpdatePaymentIntentAsync(string paymentIntentId, UpdatePaymentIntent updatePaymentIntent)
        {
            // validation
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }

            if (updatePaymentIntent == null)
            {
                throw new ArgumentNullException(nameof(updatePaymentIntent));
            }
            
            if (updatePaymentIntent.Amount != null && updatePaymentIntent.Amount.Value <= 0)
            {
                throw new ArgumentException("Amount cannot be zero or negative.");
            }
            
            return await ExecuteApiCallAsync(() => _dojoApi.UpdatePaymentIntent(paymentIntentId, updatePaymentIntent));
            
        }

        public async Task<DojoResponse<PaymentIntentResponse>> RefreshClientSessionSecretAsync(string paymentIntentId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.RefreshClientSessionSecret(paymentIntentId));
        }
    }
}