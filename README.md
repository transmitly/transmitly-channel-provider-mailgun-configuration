# Transmitly.ChannelProvider.Mailgun.Configuration

Shared Mailgun configuration and extension contracts for Transmitly channel providers.

## Should you use this package?

Use this package if you are building or extending a Mailgun provider for the Transmitly ecosystem and need the shared Mailgun option types, channel extensions, and delivery-report contracts.

If you are building an application and just want to send email through Mailgun, use [`Transmitly.ChannelProvider.Mailgun`](https://github.com/transmitly/transmitly-channel-provider-mailgun) instead.

## What This Package Provides

- `MailgunOptions` with `ApiKey`, `SendingDomain`, `ApiHost`, `ApiVersion`, `WebProxy`, and provider user-agent support.
- `ChannelProviders.Mailgun(providerId)` for resolving a Transmitly channel-provider id.
- `email.Mailgun()` for Mailgun-specific email settings.
- `report.Mailgun()` support when a concrete delivery-report adaptor is registered.
- Email contracts for stored templates, AMP HTML, tags, custom properties, DKIM, TLS, and tracking.
- Delivery-report contracts for Mailgun webhook event data.
- Builder extensions for registering email and delivery-report adaptors.

## Related Packages

- [Transmitly](https://github.com/transmitly/transmitly)
- [Transmitly.ChannelProvider.Mailgun](https://github.com/transmitly/transmitly-channel-provider-mailgun)
- [Transmitly.ChannelProvider.Mailgun.Api](https://github.com/transmitly/transmitly-channel-provider-mailgun-api)

---
_Copyright (c) Code Impressions, LLC. This open-source project is sponsored and maintained by Code Impressions and is licensed under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html)._
