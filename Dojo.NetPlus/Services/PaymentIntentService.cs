using System;
using System.Threading.Tasks;
using Dojo.NetPlus.Api;
using Dojo.NetPlus.Api.PaymentIntents;

namespace Dojo.NetPlus.Services
{
    internal sealed class PaymentIntentService : IPaymentIntentService
    {
        // inject the refit client
        private readonly IDojoApi _dojoApi;

        public PaymentIntentService(IDojoApi dojoApi)
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

            try
            {
                var apiResponse = await _dojoApi.CreatePaymentIntent(createPaymentIntent);
                return new Response<PaymentIntent>(apiResponse);
                
            }
            catch (Exception e)
            {
                return new Response<PaymentIntent>(e.Message);
            } 
            
        }

        public async Task<Response<PaymentIntent>> GetPaymentIntentAsync(string paymentIntentId)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }

            try
            {
                var apiResponse = await _dojoApi.GetPaymentIntent(paymentIntentId);
                return new Response<PaymentIntent>(apiResponse);
                
            }
            catch (Exception e)
            {
                return new Response<PaymentIntent>(e.Message);
            }
        }

        public async Task<Response<PaymentIntent>> DeletePaymentIntentAsync(string paymentIntentId)
        {
            if (string.IsNullOrWhiteSpace(paymentIntentId))
            {
                throw new ArgumentException("Payment intent ID cannot be null or empty.");
            }

            try
            {
                var apiResponse = await _dojoApi.CancelPaymentIntent(paymentIntentId);
                return new Response<PaymentIntent>(apiResponse);
                
            }
            catch (Exception e)
            {
                return new Response<PaymentIntent>(e.Message);
            }
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

            try
            {
                var apiResponse = await _dojoApi.CapturePaymentIntent(paymentIntentId, captureRequest);
                return new Response<CaptureResponse>(apiResponse);
                
            }
            catch (Exception e)
            {
                return new Response<CaptureResponse>(e.Message);
            }
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

            try
            {
                var apiResponse = await _dojoApi.UpdatePaymentIntent(paymentIntentId, updatePaymentIntent);
                return new Response<PaymentIntent>(apiResponse);
                
            }
            catch (Exception e)
            {
                return new Response<PaymentIntent>(e.Message);
            }
        }
    }
}