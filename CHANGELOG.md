# CHANGELOG

## 2023-08-09 v0.5.0

- Based on Comet 23.6.9
- Added WebDAV `DestinationLocation`

## 2023-08-02 v0.4.0

- Based on Comet 23.6.9
- Support new API endpoints for managing external admin authentication sources
- Support Object Lock policy option
- Update docstrings for various types and fields

## 2023-07-11 v0.3.1

- *There was an issue with publishing the v0.3.0 tag on NuGet. The NuGet version of v0.3.0 contains the previous v0.2.0 release dll instead. The v0.3.1 release contains no other changes but should correctly contain all the v0.3.0 content on NuGet.*

## 2023-07-11 v0.3.0

- Based on Comet 23.6.5
- .NET: Add `[JsonPropertyName]` attributes on all fields to ensure correct case-sensitive marshalling in all cases
- Support `DeviceConfig->ClientVersion`
- Support new `OSInfo` and `RestoreJobAdvancedOptions` fields
- Support new `SourceConfig` fields for tracking policy-enforced Protected Items
- Support new optional parameters in `AdminDispatcherRunRestoreCustom` API
- Add many more documentation comments, including behaviour of base64 byte arrays

## 2023-06-01 v0.2.0

- Based on Comet 23.5.0
- Add new `StreamableEventType` constants (`SEVT_*`) used for tracking Comet Server config changes
- Add new `StreamerType` constants (`STREAMER_TYPE_*`)
- Add new `FileOptions` type for configuring the Comet Server to log live events to a file
- Add new field `AuditFileOptions` to the `Organization` type for configuring per-tenant audit log options
- Add `Actor` (authenticated user), `ResourceID`, `Timestamp` and `TypeString` fields to the `StreamableEvent` type
- Deprecate the `UserProfileFragment` type
- Add extra comments to many types

## 2023-05-29 v0.1.0

- Based on Comet 23.3.7
- Initial version

