// Copyright (c) Code Impressions, LLC. All Rights Reserved.
//  
//  Licensed under the Apache License, Version 2.0 (the "License")
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;
using System.Collections.Generic;
using Transmitly.Channel.Configuration.Email;
using Transmitly.ChannelProvider.Mailgun.Configuration;

namespace Transmitly
{
	public interface IEmailExtendedDeliveryReportProperties
	{
		IEmailExtendedChannelProperties Adapt(IEmailChannelConfiguration email);

		string? Event { get; set; }
		string? Id { get; set; }
		DateTimeOffset? Timestamp { get; set; }
		string? LogLevel { get; set; }

		string? Recipient { get; set; }
		string? RecipientDomain { get; set; }
		string? MessageId { get; set; }
		string? MessageTo { get; set; }
		string? MessageFrom { get; set; }
		string? MessageSubject { get; set; }
		int? MessageSize { get; set; }

		int? DeliveryStatusCode { get; set; }
		string? DeliveryStatusMessage { get; set; }
		string? DeliveryStatusDescription { get; set; }
		string? DeliveryStatusReason { get; set; }
		string? DeliveryStatusMxHost { get; set; }
		bool? DeliveryStatusTls { get; set; }
		bool? DeliveryStatusUtf8 { get; set; }
		int? DeliveryStatusAttemptNo { get; set; }
		double? DeliveryStatusSessionSeconds { get; set; }
		bool? DeliveryStatusCertificateVerified { get; set; }

		bool? FlagIsRouted { get; set; }
		bool? FlagIsAuthenticated { get; set; }
		bool? FlagIsSystemTest { get; set; }
		bool? FlagIsTestMode { get; set; }

		string? EnvelopeTransport { get; set; }
		string? EnvelopeSender { get; set; }
		string? EnvelopeSendingIp { get; set; }
		string? EnvelopeTargets { get; set; }

		string? StorageUrl { get; set; }
		string? StorageKey { get; set; }

		IReadOnlyCollection<string>? Tags { get; set; }
		IReadOnlyDictionary<string, string?>? UserVariables { get; set; }

		string? SignatureToken { get; set; }
		string? SignatureTimestamp { get; set; }
		string? SignatureValue { get; set; }
	}
}
