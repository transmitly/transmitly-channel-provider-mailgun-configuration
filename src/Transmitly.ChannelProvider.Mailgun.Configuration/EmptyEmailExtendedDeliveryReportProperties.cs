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

namespace Transmitly.ChannelProvider.Mailgun.Configuration
{
	sealed class EmptyEmailExtendedDeliveryReportProperties : IEmailExtendedDeliveryReportProperties
	{
		public string? Event { get; set; }
		public string? Id { get; set; }
		public DateTimeOffset? Timestamp { get; set; }
		public string? LogLevel { get; set; }

		public string? Recipient { get; set; }
		public string? RecipientDomain { get; set; }
		public string? MessageId { get; set; }
		public string? MessageTo { get; set; }
		public string? MessageFrom { get; set; }
		public string? MessageSubject { get; set; }
		public int? MessageSize { get; set; }

		public int? DeliveryStatusCode { get; set; }
		public string? DeliveryStatusMessage { get; set; }
		public string? DeliveryStatusDescription { get; set; }
		public string? DeliveryStatusReason { get; set; }
		public string? DeliveryStatusMxHost { get; set; }
		public bool? DeliveryStatusTls { get; set; }
		public bool? DeliveryStatusUtf8 { get; set; }
		public int? DeliveryStatusAttemptNo { get; set; }
		public double? DeliveryStatusSessionSeconds { get; set; }
		public bool? DeliveryStatusCertificateVerified { get; set; }

		public bool? FlagIsRouted { get; set; }
		public bool? FlagIsAuthenticated { get; set; }
		public bool? FlagIsSystemTest { get; set; }
		public bool? FlagIsTestMode { get; set; }

		public string? EnvelopeTransport { get; set; }
		public string? EnvelopeSender { get; set; }
		public string? EnvelopeSendingIp { get; set; }
		public string? EnvelopeTargets { get; set; }

		public string? StorageUrl { get; set; }
		public string? StorageKey { get; set; }

		public IReadOnlyCollection<string>? Tags { get; set; }
		public IReadOnlyDictionary<string, string?>? UserVariables { get; set; }

		public string? SignatureToken { get; set; }
		public string? SignatureTimestamp { get; set; }
		public string? SignatureValue { get; set; }

		public IEmailExtendedChannelProperties Adapt(IEmailChannelConfiguration email)
		{
			return new EmptyEmailExtendedChannelProperties();
		}
	}
}
