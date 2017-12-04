﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Cancel a pending certificate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task CancelCertificate(CertificateCancel request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"certificates/{request.certificateId}/cancel", request);
            await CheckResponseMessageIsValid(response);
            return;
        }
        /// <summary>
        /// Check Domain Control
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task CheckDomainControl(CertificateDomainControlCheck request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"certificates/{request.certificateId}/verifydomaincontrol", null);
            await CheckResponseMessageIsValid(response);
            return;
        }
        /// <summary>
        /// Create a pending order for certificate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XMarketId"></param>
        /// <returns></returns>
        public async Task<CertificateIdentifierResponse> CreateCertificate(CertificatesCreate request, string XMarketId = null)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            if (XMarketId != null)
                client.DefaultRequestHeaders.Add("X-Market-Id", XMarketId);
            var response = await client.PostAsync($"certificates", request);
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CertificateIdentifierResponse>();
        }
        /// <summary>
        /// Download certificate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CertificateBundleResponse> DownloadCertificate(CertificateDownload request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"certificates/{request.certificateId}/download");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CertificateBundleResponse>();
        }
        /// <summary>
        /// Reissue active certificate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="certificateId"></param>
        /// <returns></returns>
        public async Task ReissueActiveCertificate(CertificateReissue request, string certificateId)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"certificates/{certificateId}/reissue", request);
            await CheckResponseMessageIsValid(response);
            return;
        }
        /// <summary>
        /// Renew active certificate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="certificateId"></param>
        /// <returns></returns>
        public async Task RenewActiveCertificate(CertificateRenew request, string certificateId)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"certificates/{certificateId}/renew", request);
            await CheckResponseMessageIsValid(response);
            return;
        }
        /// <summary>
        /// Retrieve certificate detail
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<List<CertificateActionResponse>> RetrieveCertificateAction(CertificateActionRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"certificates/{request.certificateId}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<List<CertificateActionResponse>>();
        }
        /// <summary>
        /// Register of certificate action callback
        /// </summary>
        /// <param name="request"></param>
        /// <param name="certificateId"></param>
        /// <returns></returns>
        public async Task RegisterCertificateAction(CertificateCallbackActionRegister request, string certificateId)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PutAsync($"certificates/{certificateId}/callback", request);
            await CheckResponseMessageIsValid(response);
            return;
        }
        /// <summary>
        /// Retrieve certificate details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CertificateIdentifierResponse> RetrieveCertificateDetail(CertificateDetailRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"certificates/{request.certificateId}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CertificateIdentifierResponse>();
        }
        /// <summary>
        /// Get Site seal
        /// </summary>
        /// <param name="request"></param>
        /// <param name="certificateId"></param>
        /// <returns></returns>
        public async Task<CertificateSiteSealResponse> RetrieveSiteSeal(CertificateSiteSealRetrieve request, string certificateId)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"certificates/{certificateId}/siteseal");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CertificateSiteSealResponse>();
        }
        /// <summary>
        /// Revoke active certificate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="certificateId"></param>
        /// <returns></returns>
        public async Task RevokeActiveCertificate(CertificateRevoke request, string certificateId)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"certificates/{certificateId}/revoke", request);
            await CheckResponseMessageIsValid(response);
            return;
        }
        /// <summary>
        /// Unregister system callback
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task UnregisterCertificateCallback(CertificateCallbackUnregister request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.DeleteAsync($"certificates/{request.certificateId}/callback");
            await CheckResponseMessageIsValid(response);
            return;
        }
    }
}
