# CHANGELOG

## 2026-11-25 v1.1.0

- Based on Comet 26.11.3
- Add admin API token authentication (requires Comet Server 26.8.3 or later)
- An error-shaped response with a Status of 200–299 is now success, and anything outside that range is an error. This stops Ruby raising on 2xx results like 204, and lets Go and PHP report 1xx/3xx errors.
- Corrected (>= x.y.z) version annotations for the admin-user and RequireHash parameters

## 2026-11-23 v1.0.0

- Based on Comet 26.11.3-rc
- Add APIs for creating, listing and revoking admin personal API tokens
- Add APIs for testing the connection to a Proxmox cluster node
- Add NinjaOne PSA integration APIs, and PSA configuration types for ConnectWise and NinjaOne
- Add Office 365 APIs for evaluating selection rules and converting a legacy selection into rules
- Add custom branding options for adding CSS and JavaScript to the web interface
- Add Linux RPM code signing properties, and a PKCS#11 driver allowlist for code signing
- Add Windows code signing with AWS KMS, Google Cloud KMS and Azure Artifact Signing
- Add PostgreSQL Protected Item types, and APIs for browsing PostgreSQL databases
- Add OAuth authentication for SMTP email, and an API for completing the OAuth authorization
- Add APIs for reading the server configuration with a hash, and for setting it only if that hash still matches
- Add APIs for updating another admin account, and for listing and deleting the admins of a given organization
- Add APIs for clearing a device's login password, rotating a Storage Vault bucket key, and abandoning a job from the user web interface
- Add Slack, email, and AWS SQS, SNS and EventBridge as webhook formats, and a job filter for webhooks
- Add self-backup events
- Add an optional time window for Storage Vault speed limits
- Add DNS cache options
- Add restore types for restoring to cloud storage, and restore options for skipping existing Office 365 items and not sparsifying restored files
- Add an option to wait for the device to confirm a software update
- The user web dispatcher APIs for running backups and restores now return the job ID
- The set-user-profile API now accepts the optional AdminOptions parameter
- Breaking: /api/v1/admin/account/session-upgrade now exchanges an SSO one-time token and no longer takes a session key
- Breaking: /api/v1/admin/installation/dispatch/register-device no longer takes a TOTP code
- Breaking: remove the OFFICE365_REGION_GERMANY constant
- Breaking: constants and the fields that hold them now use named types, such as DestinationType, EngineType and ScheduleFrequencyType, instead of uint64 and string
- Fix the CometAPI constructor that takes an HttpClient ignoring it and creating its own
- Fix file uploads, such as AdminMetaResourceNew, which the server could not read
- Update System.Text.Json to 8.0.6, for CVE-2024-30105. Platform support is unchanged

## 2025-12-04 v0.37.0

- Based on Comet 25.9.8
- Add support for shared quota management APIs
- Add Proxmox API parameter

## 2025-11-14 v0.36.0

- Based on Comet 25.9.6
- Add new API methods for getting, setting, and deleting Protected Items and
their associated schedules
- Add new API methods for live connection credential/session management
- Add JobID field to API response when starting jobs via the dispatcher on
devices running Comet 25.9.6 or newer
- Add support for custom tags on backup jobs to allow grouping of
snapshots/jobs
- Add support SAS Relic codesigning
- Improve documentation for Proxmox API types

## 2025-08-15 v0.35.0

- Based on Comet 25.6.8
- Add support for Proxmox
- Add profile hash to some API endpoints

## 2025-03-20 v0.34.0

- Based on Comet 25.3.1
- Support yearly retention rules
- Support yearly schedule rules
- Support storage vault key rotation period
- Support restoring deduplicated files from NTFS disk images

## 2025-02-17 v0.33.0
Update to 24.12.5

- Based on Comet 24.12.5

## 2025-01-29 v0.32.0

- Based on Comet 24.12.4

## 2025-01-22 v0.31.0

- Based on Comet 24.12.3
- Additional properties for BrandingOptions, BrandingProperties and ServerMetaBrandingProperties

## 2025-01-15 v0.30.0

- Based on Comet 24.12.2
- Support new Login Protection feature
- Support requiring password changes for admin accounts
- Support new user grouping functionality
- Support creating a first admin account on empty servers
- Support vault-device associations and automatic vault creation

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

