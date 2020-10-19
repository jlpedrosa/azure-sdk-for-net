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
    internal partial class ReservationsSummariesRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ReservationsSummariesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public ReservationsSummariesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2019-10-01")
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

        internal HttpMessage CreateListByReservationOrderRequest(string reservationOrderId, Datagrain grain, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationorders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationSummaries", false);
            uri.AppendQuery("grain", grain.ToString(), true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderAsync(string reservationOrderId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }

            using var message = CreateListByReservationOrderRequest(reservationOrderId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrder(string reservationOrderId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }

            using var message = CreateListByReservationOrderRequest(reservationOrderId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderAndReservationRequest(string reservationOrderId, string reservationId, Datagrain grain, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationorders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendPath("/reservations/", false);
            uri.AppendPath(reservationId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationSummaries", false);
            uri.AppendQuery("grain", grain.ToString(), true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderAndReservationAsync(string reservationOrderId, string reservationId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }
            if (reservationId == null)
            {
                throw new ArgumentNullException(nameof(reservationId));
            }

            using var message = CreateListByReservationOrderAndReservationRequest(reservationOrderId, reservationId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is null. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrderAndReservation(string reservationOrderId, string reservationId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }
            if (reservationId == null)
            {
                throw new ArgumentNullException(nameof(reservationId));
            }

            using var message = CreateListByReservationOrderAndReservationRequest(reservationOrderId, reservationId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string scope, Datagrain grain, string startDate, string endDate, string filter, string reservationId, string reservationOrderId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationSummaries", false);
            uri.AppendQuery("grain", grain.ToString(), true);
            if (startDate != null)
            {
                uri.AppendQuery("startDate", startDate, true);
            }
            if (endDate != null)
            {
                uri.AppendQuery("endDate", endDate, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (reservationId != null)
            {
                uri.AppendQuery("reservationId", reservationId, true);
            }
            if (reservationOrderId != null)
            {
                uri.AppendQuery("reservationOrderId", reservationOrderId, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="scope"> The scope associated with reservations summaries operations. This includes &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}&apos; for BillingAccount scope (legacy), and &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}&apos; for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListAsync(string scope, Datagrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListRequest(scope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="scope"> The scope associated with reservations summaries operations. This includes &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}&apos; for BillingAccount scope (legacy), and &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}&apos; for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<ReservationSummariesListResult> List(string scope, Datagrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListRequest(scope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderNextPageRequest(string nextLink, string reservationOrderId, Datagrain grain, string filter)
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

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="reservationOrderId"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderNextPageAsync(string nextLink, string reservationOrderId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }

            using var message = CreateListByReservationOrderNextPageRequest(nextLink, reservationOrderId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="reservationOrderId"/> is null. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrderNextPage(string nextLink, string reservationOrderId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }

            using var message = CreateListByReservationOrderNextPageRequest(nextLink, reservationOrderId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderAndReservationNextPageRequest(string nextLink, string reservationOrderId, string reservationId, Datagrain grain, string filter)
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

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/>, or <paramref name="reservationId"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderAndReservationNextPageAsync(string nextLink, string reservationOrderId, string reservationId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }
            if (reservationId == null)
            {
                throw new ArgumentNullException(nameof(reservationId));
            }

            using var message = CreateListByReservationOrderAndReservationNextPageRequest(nextLink, reservationOrderId, reservationId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/>, or <paramref name="reservationId"/> is null. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrderAndReservationNextPage(string nextLink, string reservationOrderId, string reservationId, Datagrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (reservationOrderId == null)
            {
                throw new ArgumentNullException(nameof(reservationOrderId));
            }
            if (reservationId == null)
            {
                throw new ArgumentNullException(nameof(reservationId));
            }

            using var message = CreateListByReservationOrderAndReservationNextPageRequest(nextLink, reservationOrderId, reservationId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string scope, Datagrain grain, string startDate, string endDate, string filter, string reservationId, string reservationOrderId)
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

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope associated with reservations summaries operations. This includes &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}&apos; for BillingAccount scope (legacy), and &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}&apos; for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListNextPageAsync(string nextLink, string scope, Datagrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListNextPageRequest(nextLink, scope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope associated with reservations summaries operations. This includes &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}&apos; for BillingAccount scope (legacy), and &apos;/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}&apos; for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports &apos;le&apos; and  &apos;ge&apos;. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<ReservationSummariesListResult> ListNextPage(string nextLink, string scope, Datagrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListNextPageRequest(nextLink, scope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
