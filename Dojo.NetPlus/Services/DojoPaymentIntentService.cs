using System;
using System.Threading.Tasks;
using Dojo.NetPlus.Api;
using Dojo.NetPlus.Api.PaymentIntents;

namespace Dojo.NetPlus.Services
{
    internal sealed class DojoPaymentIntentService : BaseService, IDojoPaymentIntentService
    {
        // inject the refit client
        private readonly IDojoApi _dojoApi;

        public DojoPaymentIntentService(IDojoApi dojoApi)
        {
            _dojoApi = dojoApi;
        }
        
        public async Task<Response<PaymentIntent>> CreatePaymentIntentAsync(CreatePaymentIntent createPaymentIntent)
        {
            // validation
            if (createPaymentIntent.Amount is null || createPaymentIntent.Amount.Value == 0)
            {
                throw new ArgumentException("Amount cannot be zero.");
            }
            
            return await ExecuteApiCallAsync(() => _dojoApi.CreatePaymentIntent(createPaymentIntent));
            
        }

        public async Task<Response<PaymentIntent>> GetPaymentIntentAsync(string paymentIntentId)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }

            return await ExecuteApiCallAsync(() => _dojoApi.GetPaymentIntent(paymentIntentId));
           
        }

        public async Task<Response<PaymentIntent>> DeletePaymentIntentAsync(string paymentIntentId)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }
            
            return await ExecuteApiCallAsync(() => _dojoApi.CancelPaymentIntent(paymentIntentId));
            
        }

        public async Task<Response<CaptureResponse>> CapturePaymentIntentAsync(string paymentIntentId, CaptureRequest captureRequest)
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

        public async Task<Response<PaymentIntent>> UpdatePaymentIntentAsync(string paymentIntentId, UpdatePaymentIntent updatePaymentIntent)
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

        public async Task<Response<PaymentIntent>> RefreshClientSessionSecretAsync(string paymentIntentId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.RefreshClientSessionSecret(paymentIntentId));
        }
    }
}