# CHANGELOG

## 2024-10-29 v0.29.0

- Based on Comet 24.9.6
- New API AdminDispatcherTestSmbAuth to instruct a device to test Windows SMB credentials
- New RESTORETYPE_WINDISK_VHDX to restore Disk Image backup as Hyper-V VHDX format
- BackupJobDetail supports ConflictingJobID field to indicate conflicting job if a lock error occurred
- BackupJobProgress can report the total number of items for progress visualization
- DiskDrive adds information about parent disks on Linux

## 2024-09-17 v0.28.0

- Based on Comet 24.9.1
- Added Hyper-V Guest limits per user
- Added VMware Guest limits per user
- Added protected item type (engine) to protected item class
- Added Force Overwrite Restore permissions

## 2024-08-01 v0.27.0

- Based on Comet 24.6.6
- Add new AdminConvertStorageRole API
- Update data types for new job retry feature (BackupJobDetail, BackupRuleEventTriggers, and new JOB_STATUS_RUNNING_TRYAGAIN)
- Add support for custom Prefix in S3GenericVirtualStorageRole

## 2024-07-16 v0.26.0

- Based on Comet 24.6.4
- Added Server Device and Booster Limits
- Added API to count devices registered on a Server
- Added Software Build Role configuration per tenant

## 2024-06-11 v0.25.0

- Based on Comet 24.6.0
- Added custom HELO/EHLO STMP support
- Added support to set if disabled Office 365 accounts should be backed up
- Added EngineType as a property of VaultSnapshots

## 2024-05-31 v0.24.0

- Based on Comet 24.5.0
- Added support for matching Microsoft Office 365 users and groups by Drive ID
- Added support for configuring Object Lock on a Impossible Cloud Partner API Storage Template
- Added support for Custom Body Date when using a Custom Remote Bucket Storage Template

## 2024-05-24 v0.23.0

- Based on Comet 24.3.9

## 2024-05-17 v0.22.0

- Based on Comet 24.3.8
- Added support for configuring Software Build Role builder count
- Added LastStartTime field to job statistics

## 2024-05-14 v0.21.0

- Based on Comet 24.3.7
- Added support for configuring concurrency in Microsoft 365 Protected Items

## 2024-05-02 v0.20.0

- Based on Comet 24.3.6
- Testing new release process

## 2024-04-12 v0.19.0

- Based on Comet 24.3.5

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

