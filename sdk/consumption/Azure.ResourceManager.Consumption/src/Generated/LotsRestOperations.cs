// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    internal partial class LotsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of LotsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public LotsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2019-10-01")
        {
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string billingAccountId, string billingProfileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/billingProfiles/", false);
            uri.AppendPath(billingProfileId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/lots", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists the lots by billingAccountId and billingProfileId. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        public async Task<Response<Lots>> ListAsync(string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingProfileId == null)
            {
                throw new ArgumentNullException(nameof(billingProfileId));
            }

            using var message = CreateListRequest(billingAccountId, billingProfileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the lots by billingAccountId and billingProfileId. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        public Response<Lots> List(string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingProfileId == null)
            {
                throw new ArgumentNullException(nameof(billingProfileId));
            }

            using var message = CreateListRequest(billingAccountId, billingProfileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string billingAccountId, string billingProfileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists the lots by billingAccountId and billingProfileId. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/>, or <paramref name="billingProfileId"/> is null. </exception>
        public async Task<Response<Lots>> ListNextPageAsync(string nextLink, string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingProfileId == null)
            {
                throw new ArgumentNullException(nameof(billingProfileId));
            }

            using var message = CreateListNextPageRequest(nextLink, billingAccountId, billingProfileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the lots by billingAccountId and billingProfileId. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/>, or <paramref name="billingProfileId"/> is null. </exception>
        public Response<Lots> ListNextPage(string nextLink, string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingProfileId == null)
            {
                throw new ArgumentNullException(nameof(billingProfileId));
            }

            using var message = CreateListNextPageRequest(nextLink, billingAccountId, billingProfileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
