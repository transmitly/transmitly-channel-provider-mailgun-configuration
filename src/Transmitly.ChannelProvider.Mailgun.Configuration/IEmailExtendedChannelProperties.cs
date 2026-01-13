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
using Transmitly.Channel.Configuration.Email;
using Transmitly.Template.Configuration;

namespace Transmitly.ChannelProvider.Mailgun.Configuration
{
	/// <summary>
	/// Extended properties for Mailgun emails.
	/// </summary>
	public interface IEmailExtendedChannelProperties
	{
		/// <summary>
		/// AMP part of the message. Please follow Google guidelines to compose and send AMP emails.
		/// </summary>
		IContentTemplateConfiguration AmpHtml { get; set; }
		/// <summary>
		/// Name of a template stored via the Templates API to use to render the email body. 
		/// See <see href="https://documentation.mailgun.com/docs/mailgun/user-manual/sending-messages/send-templates">Templates</see> for more information.
		/// </summary>
		string? Template { get; set; }
		/// <summary>
		/// Render a specific version of the given template instead of the latest version. <see cref="Template"/> option must also be provided.
		/// </summary>
		string? TemplateVersion { get; set; }
		/// <summary>
		/// Tag string. 
		/// See <see href="https://documentation.mailgun.com/docs/mailgun/user-manual/tracking-messages/track-tagging">Tagging</see> for more information.
		/// </summary>
		IReadOnlyCollection<string>? Tags { get; set; }
		/// <summary>
		/// Enables or disables DKIM signatures on a per-message basis. 
		/// Overrides the domain-level DKIM setting for this specific message.
		/// </summary>
		bool? DKIMSignatures { get; set; }
		/// <summary>
		/// Specify a second domain key to sign the email with. The value is formatted as signing_domain/selector, e.g. example.com/s1.
		/// This tells Mailgun to sign the message with the signing domain example.com using the selector s1. 
		/// Note: the domain key specified must have been previously created and activated
		/// </summary>
		string? SecondaryDKIM { get; set; }
		/// <summary>
		/// Specify an alias of the domain key specified in o:secondary-dkim. Also formatted as public_signing_domain/selector. 
		/// o:secondary-dkim option must also be provided. 
		/// Mailgun will sign the message with the provided key of the secondary DKIM, but use the public secondary DKIM name and selector. 
		/// Note: We will perform a DNS check prior to signing the message to ensure the public keys matches the secondary DKIM.
		/// </summary>
		string? PublicSecondaryDKIM { get; set; }
		/// <summary>
		/// Enables sending in test mode. Messages are processed normally but not actually delivered to recipients. 
		/// Useful for testing without sending real emails
		/// </summary>
		bool? TestMode { get; set; }
		/// <summary>
		/// Toggles both click and open tracking on a per-message basis.
		/// </summary>
		bool? Tracking { get; set; }
		/// <summary>
		/// Toggles click tracking on a per-message basis, see <see href="https://documentation.mailgun.com/docs/mailgun/user-manual/tracking-messages/tracking-clicks">Tracking Clicks</see>. 
		/// This overrides the domain-level click tracking setting
		/// </summary>
		bool? TrackingClicks { get; set; }
		/// <summary>
		/// Toggles opens tracking on a per-message basis, see <see href="https://documentation.mailgun.com/docs/mailgun/user-manual/tracking-messages/tracking-opens">Tracking Opens</see>. 
		/// Has higher priority than domain-level setting.
		/// </summary>
		bool? TrackingOpens { get; set; }
		/// <summary>
		/// Places the tracking pixel at the top of emails instead of the bottom. 
		/// Useful for long emails that may be truncated or have rendering issues, ensuring open tracking works accurately
		/// </summary>
		bool? TrackingPixelLocationTop { get; set; }
		/// <summary>
		/// When set to 'yes', requires the message to be sent only over a TLS connection to the Email Service Provider. 
		/// If TLS cannot be established, the message will not be delivered.
		/// When set to 'no' (default), Mailgun attempts TLS but falls back to plaintext SMTP if needed.
		/// </summary>
		bool? RequireTls { get; set; }
		/// <summary>
		/// If an IP Pool ID is provided, the email will be delivered with an IP that belongs in that pool
		/// </summary>
		string? SendingIp { get; set; }
		/// <summary>
		/// Additional properties
		/// </summary>
		IDictionary<string, string>? Properties { get; set; }

		/// <summary>
		/// Adapts the provided email channel to Mailgun extended properties.
		/// </summary>
		/// <param name="email">Channel to adapt.</param>
		/// <returns>Extended email properties.</returns>
		IEmailExtendedChannelProperties Adapt(IEmailChannelConfiguration email);
	}
}
