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

using System.Collections.Generic;
using Transmitly.Template.Configuration;
using Transmitly.Util;

namespace Transmitly.ChannelProvider.Mailgun.Configuration
{
	internal sealed class EmailExtendedChannelProperties(IExtendedProperties extendedProperties) : IEmailExtendedChannelProperties
	{
		private readonly IExtendedProperties _extendedProperties = Guard.AgainstNull(extendedProperties);
		private const string ProviderKey = MailgunConstant.EmailPropertiesKey;

		// Created once and kept, so templates added through one accessor are still there at dispatch.
		public IContentTemplateConfiguration AmpHtml
		{
			get
			{
				var ampHtml = _extendedProperties.GetValue<IContentTemplateConfiguration?>(ProviderKey, nameof(AmpHtml));
				if (ampHtml == null)
				{
					ampHtml = new ContentTemplateConfiguration();
					AmpHtml = ampHtml;
				}
				return ampHtml;
			}
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(AmpHtml), value);
		}

		public string? Template
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(Template));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Template), value);
		}

		public string? TemplateVersion
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(TemplateVersion));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(TemplateVersion), value);
		}

		public IReadOnlyCollection<string>? Tags
		{
			get => _extendedProperties.GetValue<IReadOnlyCollection<string>?>(ProviderKey, nameof(Tags));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Tags), value);
		}

		public bool? DKIMSignatures
		{
			get => _extendedProperties.GetValue<bool?>(ProviderKey, nameof(DKIMSignatures));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(DKIMSignatures), value);
		}

		public string? SecondaryDKIM
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(SecondaryDKIM));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(SecondaryDKIM), value);
		}

		public string? PublicSecondaryDKIM
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(PublicSecondaryDKIM));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(PublicSecondaryDKIM), value);
		}

		public bool? TestMode
		{
			get => _extendedProperties.GetValue<bool?>(ProviderKey, nameof(TestMode));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(TestMode), value);
		}

		public bool? Tracking
		{
			get => _extendedProperties.GetValue<bool?>(ProviderKey, nameof(Tracking));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Tracking), value);
		}

		public bool? TrackingClicks
		{
			get => _extendedProperties.GetValue<bool?>(ProviderKey, nameof(TrackingClicks));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(TrackingClicks), value);
		}

		public bool? TrackingOpens
		{
			get => _extendedProperties.GetValue<bool?>(ProviderKey, nameof(TrackingOpens));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(TrackingOpens), value);
		}

		public bool? TrackingPixelLocationTop
		{
			get => _extendedProperties.GetValue<bool?>(ProviderKey, nameof(TrackingPixelLocationTop));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(TrackingPixelLocationTop), value);
		}

		public bool? RequireTls
		{
			get => _extendedProperties.GetValue<bool?>(ProviderKey, nameof(RequireTls));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(RequireTls), value);
		}

		public string? SendingIp
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(SendingIp));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(SendingIp), value);
		}

		public IDictionary<string, string>? Properties
		{
			get => _extendedProperties.GetValue<IDictionary<string, string>?>(ProviderKey, nameof(Properties));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Properties), value);
		}
	}
}
