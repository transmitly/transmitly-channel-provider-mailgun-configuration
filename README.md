# Transmitly.ChannelProvider.Mailgun.Configuration

Shared Mailgun configuration primitives for Transmitly channel-provider implementations.

## Should you use this package?

Use this package if you are authoring a Mailgun channel provider or extension for the Transmitly ecosystem and need the common Mailgun configuration types and contracts.

If you are building an application and just want to send email through Mailgun, use [`transmitly-channel-provider-mailgun`](https://github.com/transmitly/transmitly-channel-provider-mailgun) instead.

## What this package provides

- `MailgunOptions`: common provider options (`ApiKey`, `SendingDomain`, `ApiHost`, `ApiVersion`, `WebProxy`, `UserAgent`).
- `MailgunConstant.Id`: the default provider id (`"Mailgun"`).
- `ChannelProviders.Mailgun(...)`: extension for building a provider id with optional instance suffix.
- `IEmailExtendedChannelProperties`: Mailgun-specific email options such as templates, tags, DKIM, tracking, AMP HTML, TLS, and custom properties.
- `IEmailExtendedDeliveryReportProperties`: Mailgun-specific delivery-report fields such as event metadata, delivery status, envelope data, tags, and signature values.
- `IDeliveryReportExtendedProperties`: root delivery-report contract for Mailgun provider extensions.
- `email.Mailgun()` and `report.Mailgun()`: extension methods for accessing Mailgun-specific properties.
- `AddEmailExtendedPropertiesAdaptor<T>()` and `AddDeliveryReportExtendedProprtiesAdaptor<T>()`: hooks for binding concrete implementations.

## Related projects

- [Transmitly](https://github.com/transmitly/transmitly)
- [transmitly-channel-provider-mailgun](https://github.com/transmitly/transmitly-channel-provider-mailgun)

---
_Copyright (c) Code Impressions, LLC. This open-source project is sponsored and maintained by Code Impressions and is licensed under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html)._
