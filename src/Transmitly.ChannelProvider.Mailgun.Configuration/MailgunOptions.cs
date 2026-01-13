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

using System.Net;

namespace Transmitly.ChannelProvider.Mailgun.Configuration
{
    /// <summary>
    /// Represents the configuration options for the Mailgun channel provider.
    /// </summary>
    public sealed class MailgunOptions
    {
        private readonly string _userAgent = GetUserAgent();

        /// <summary>
        /// Gets or sets the web proxy used for HTTP requests.
        /// </summary>
        public WebProxy? WebProxy { get; set; }
        /// <summary>
        /// The Mailgun API key.
        /// </summary>
        public string? ApiKey { get; set; }
        /// <summary>
        /// The Mailgun sending domain.
        /// </summary>
        public string? SendingDomain { get; set; }
        /// <summary>
        /// Base url (e.g. <a href="https://api.mailgun.net"></a>).
        /// </summary>
        public string ApiHost { get; set; } = "https://api.mailgun.net";
        /// <summary>
        /// API version.
        /// </summary>
        public string ApiVersion { get; set; } = "v3";
        /// <summary>
        /// Gets the user agent string used in HTTP requests.
        /// </summary>
        public string UserAgent => _userAgent;

        private static string GetUserAgent()
        {
            string? version = null;
            try
            {
                version = typeof(MailgunOptions).Assembly.GetName().Version?.ToString();
            }
            catch
            {
                //eat error
            }

            if (string.IsNullOrWhiteSpace(version))
                version = "0.1.0";

            return $"transmitly-mailgun/{version}";
        }
    }
}