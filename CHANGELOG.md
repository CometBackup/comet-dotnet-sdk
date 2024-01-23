# CHANGELOG

## 2024-01-23 v0.18.0

- Based on Comet 23.12.3

## 2024-01-17 v0.17.0

- Based on Comet 23.12.3

## 2023-12-21 v0.16.0

- Based on Comet 23.12.1

## 2023-12-20 v0.15.0

- Based on Comet 23.11.2

## 2023-11-21 v0.14.0

- Based on Comet 23.9.11

## 2023-11-08 v0.13.0

- Based on Comet 23.9.9
- Add Syncro support

## 2023-11-03 v0.12.0

- (This release is identical to the v0.11.0 release version.)

## 2023-11-03 v0.11.0

- Based on Comet 23.9.8

## 2023-10-25 v0.10.0

- Based on Comet 23.9.7
- Add VMware support

## 2023-10-18 v0.9.0

- Based on Comet 23.9.6
- Added Comet Storage Remote Server Type

## 2023-10-12 v0.8.0

- Based on Comet 23.9.5
- Add new field `LogLevel` to control job log verbosity
- Add new `RESTORETYPE_WINDISK_ESXI` for restoring to VMware-compatible
virtual disks

## 2023-09-19 v0.7.0

- Based on Comet 23.9.2
- 'UseObjectLock' for S3 compatible storage settings deprecated. Replaced by 'ObjectLockMode'
- New Streamable event SEVT_DEVICE_LOBBY_CONNECT and SEVT_DEVICE_LOBBY_DISCONNECT
- Added 'TOTPCode' to 'InstallCreds' used for device registration.
- 'GroupedBy' added to 'PSAConfig' for grouping statistics.
- New APIs
	- AdminInstallationDispatchDropConnection
	- AdminInstallationDispatchRegisterDevice
	- AdminInstallationListActive
	- AdminJobAbandon

## 2023-08-29 v0.6.0

- Based on Comet 23.8.0
- Improve documentation of JobStatus constants

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

