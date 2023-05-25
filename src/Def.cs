
// AUTOGENERATED, DO NOT EDIT

namespace CometBackup.CometAPI.SDK {
public static class Def {
	public const string APPLICATION_VERSION = "23.3.7";

	public const long APPLICATION_VERSION_MAJOR = 23;

	public const long APPLICATION_VERSION_MINOR = 3;

	public const long APPLICATION_VERSION_REVISION = 7;

	/// AutoRetentionLevel: The system will automatically choose how often to run an automatic Retention Pass after each
	/// backup job.
	public const long BACKUPJOBAUTORETENTION_AUTOMATIC = 0;

	/// AutoRetentionLevel: The system will run a Retention Pass after every single backup job. This is more
	/// system-intensive, but is the most responsive at freeing storage space.
	public const long BACKUPJOBAUTORETENTION_IMMEDIATE = 1;

	/// AutoRetentionLevel: The system will follow the automatic ruleset for a 'High Power' device.
	public const long BACKUPJOBAUTORETENTION_MORE_OFTEN = 2;

	/// AutoRetentionLevel: The system will follow the automatic ruleset for a 'Low Power' device.
	public const long BACKUPJOBAUTORETENTION_LESS_OFTEN = 3;

	public const long BRANDINGSTYLETYPE_AUTO_LEGACY = 0;

	public const long BRANDINGSTYLETYPE_DEFAULT = 1;

	public const long BRANDINGSTYLETYPE_CUSTOM_TEXT = 2;

	public const long BRANDINGSTYLETYPE_CUSTOM_LOGO = 3;

	/// ClientBrandingBuildMode: The software client will be custom-built by this Comet Server, allowing custom branding,
	/// default server URL, and codesigning.
	public const long CLIENTBRANDINGBUILD_CUSTOM = 0;

	/// ClientBrandingBuildMode: A pre-built software client will be served, with Comet-branding, no server URL, and Comet
	/// codesigning.
	public const long CLIENTBRANDINGBUILD_PREBUILT = 1;

	/// CompressMode
	public const long COMPRESS_INVALID = 0;

	/// CompressMode
	public const long COMPRESS_LVL_1 = 1;

	/// CompressMode
	public const long COMPRESS_LVL_2 = 2;

	/// CompressMode
	public const long COMPRESS_LVL_3 = 3;

	/// CompressMode
	public const long COMPRESS_LVL_4 = 4;

	/// CompressMode
	public const long COMPRESS_LVL_5 = 5;

	/// CompressMode
	public const long COMPRESS_MAX = 5;

	/// CompressMode
	public const long COMPRESS_DEFAULT = 4;

	/// LanguageCode
	public const string DEFAULT_LANGUAGE = "en_US";

	public const string DEFAULT_TIMEZONE = "UTC";

	/// SftpAuthMode
	public const ulong DESTINATION_SFTP_AUTHMODE_NATIVE = 0;

	/// SftpAuthMode
	public const ulong DESTINATION_SFTP_AUTHMODE_PASSWORD = 1;

	/// SftpAuthMode
	public const ulong DESTINATION_SFTP_AUTHMODE_PRIVATEKEY = 2;

	public const ulong DESTINATIONTYPE___INVALID = 0;

	public const ulong DESTINATIONTYPE_S3 = 1000;

	public const ulong DESTINATIONTYPE_SFTP = 1001;

	public const ulong DESTINATIONTYPE_LOCALCOPY = 1002;

	public const ulong DESTINATIONTYPE_COMET = 1003;

	public const ulong DESTINATIONTYPE_FTP = 1004;

	public const ulong DESTINATIONTYPE_AZUREBLOB = 1005;

	public const ulong DESTINATIONTYPE_SPANNED = 1006;

	public const ulong DESTINATIONTYPE_SWIFT = 1007;

	public const ulong DESTINATIONTYPE_B2 = 1008;

	public const ulong DESTINATIONTYPE_STORJ = 1009;

	public const ulong DESTINATIONTYPE_LATEST = 1100;

	public const ulong DESTINATIONTYPE_ALL = 1101;

	/// The Comet Server is still starting up and has not yet checked whether any email reports are due to be sent.
	public const long EMAIL_WORKER_STATE_NOT_STARTED = 0;

	/// The Comet Server is still starting up and has not yet checked whether any email reports are due to be sent.
	public const long EMAIL_WORKER_STATE_STARTED = 1;

	/// The Comet Server is currently searching through email report configuration, to determine when the next email report
	/// is due to be sent.
	public const long EMAIL_WORKER_STATE_CALCULATING = 2;

	/// The Comet Server knows when the next scheduled email report is due to be sent, and is waiting until that time.
	public const long EMAIL_WORKER_STATE_WAITING = 3;

	/// The Comet Server is currently sending a scheduled email report.
	public const long EMAIL_WORKER_STATE_SENDING = 4;

	/// EmailDeliveryType: If this is for the top-level Organization, email is disabled. If this is for an Organization,
	/// use the parent's email settings.
	public const string EMAIL_DELIVERY_INHERIT = "";

	/// EmailDeliveryType
	public const string EMAIL_DELIVERY_MX_DIRECT = "builtin";

	/// EmailDeliveryType
	public const string EMAIL_DELIVERY_SMTP = "smtp";

	/// EmailDeliveryType
	public const string EMAIL_DELIVERY_SMTP_SSL = "smtp-ssl";

	/// EmailDeliveryType
	public const string EMAIL_DELIVERY_DISABLED = "disabled";

	/// EmailDeliveryType: Legacy alias for EMAIL_DELIVERY_MX_DIRECT
	public const string EMAIL_DELIVERY_BUILTIN = "builtin";

	/// EmailDeliveryType: Legacy alias for EMAIL_DELIVERY_INHERIT
	public const string EMAIL_DELIVERY_NONE = "";

	/// EmailReportType
	public const long EMAILREPORTTYPE_IMMEDIATE = 0;

	/// EmailReportType
	public const long EMAILREPORTTYPE_SUMMARY = 1;

	/// EmailReportType
	public const long EMAILREPORTTYPE_GROUPED_STATUS = 2;

	/// EmailReportType
	public const long EMAILREPORTTYPE_RECENT_ACTIVITY = 3;

	public const ulong ENCRYPTIONMETHOD_UNCONFIGURED = 0;

	/// Files and Folders
	public const string ENGINE_BUILTIN_FILE = "engine1/file";

	/// Program Output
	public const string ENGINE_BUILTIN_STDOUT = "engine1/stdout";

	/// MySQL
	public const string ENGINE_BUILTIN_MYSQL = "engine1/mysql";

	/// Windows Server System State
	public const string ENGINE_BUILTIN_SYSTEMSTATE = "engine1/systemstate";

	/// Microsoft SQL Server
	public const string ENGINE_BUILTIN_MSSQL = "engine1/mssql";

	/// Windows System Backup
	public const string ENGINE_BUILTIN_WINDOWSSYSTEM = "engine1/windowssystem";

	/// Microsoft Exchange Server
	public const string ENGINE_BUILTIN_EXCHANGEEDB = "engine1/exchangeedb";

	/// Application-Aware Writer
	public const string ENGINE_BUILTIN_VSSWRITER = "engine1/vsswriter";

	/// Microsoft Hyper-V
	public const string ENGINE_BUILTIN_HYPERV = "engine1/hyperv";

	/// Disk Image
	public const string ENGINE_BUILTIN_WINDISK = "engine1/windisk";

	/// MongoDB
	public const string ENGINE_BUILTIN_MONGODB = "engine1/mongodb";

	/// Office 365
	public const string ENGINE_BUILTIN_MSOFFICE = "engine1/winmsofficemail";

	/// FtpsModeType
	public const long FTPS_MODE_PLAINTEXT = 0;

	/// FtpsModeType
	public const long FTPS_MODE_IMPLICIT = 1;

	/// FtpsModeType
	public const long FTPS_MODE_EXPLICIT = 2;

	/// JobClassification
	public const ulong JOB_CLASSIFICATION__MIN = 4000;

	/// JobClassification
	public const ulong JOB_CLASSIFICATION_UNKNOWN = 4000;

	/// JobClassification
	public const ulong JOB_CLASSIFICATION_BACKUP = 4001;

	/// JobClassification
	public const ulong JOB_CLASSIFICATION_RESTORE = 4002;

	/// JobClassification: Automatic or manual retention cleaning pass.
	public const ulong JOB_CLASSIFICATION_RETENTION = 4003;

	/// JobClassification: Another process needed exclusive Vault access (e.g. for retention) but the process died. This
	/// task cleans up exclusive lockfiles.
	public const ulong JOB_CLASSIFICATION_UNLOCK = 4004;

	/// JobClassification: A specific snapshot has been deleted via the Restore wizard.
	public const ulong JOB_CLASSIFICATION_DELETE_CUSTOM = 4005;

	/// JobClassification: Explicitly re-measuring the size of a Vault (right-click > Advanced menu).
	public const ulong JOB_CLASSIFICATION_REMEASURE = 4006;

	/// JobClassification: Software update
	public const ulong JOB_CLASSIFICATION_UPDATE = 4007;

	/// JobClassification
	public const ulong JOB_CLASSIFICATION_IMPORT = 4008;

	/// JobClassification: Repair indexes
	public const ulong JOB_CLASSIFICATION_REINDEX = 4009;

	/// JobClassification
	public const ulong JOB_CLASSIFICATION_DEEPVERIFY = 4010;

	/// JobClassification: Software uninstall
	public const ulong JOB_CLASSIFICATION_UNINSTALL = 4011;

	/// JobClassification
	public const ulong JOB_CLASSIFICATION__MAX = 4999;

	/// JobStatus
	public const ulong JOB_STATUS_STOP_SUCCESS__MIN = 5000;

	/// JobStatus
	public const ulong JOB_STATUS_STOP_SUCCESS = 5000;

	/// JobStatus
	public const ulong JOB_STATUS_STOP_SUCCESS__MAX = 5999;

	/// JobStatus
	public const ulong JOB_STATUS_RUNNING__MIN = 6000;

	/// JobStatus: Unused
	public const ulong JOB_STATUS_RUNNING_INDETERMINATE = 6000;

	/// JobStatus
	public const ulong JOB_STATUS_RUNNING_ACTIVE = 6001;

	/// JobStatus: A backup job that was marked as stopped or abandoned, but has somehow continued to run
	public const ulong JOB_STATUS_RUNNING_REVIVED = 6002;

	/// JobStatus
	public const ulong JOB_STATUS_RUNNING__MAX = 6999;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED__MIN = 7000;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_TIMEOUT = 7000;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_WARNING = 7001;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_ERROR = 7002;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_QUOTA = 7003;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_SCHEDULEMISSED = 7004;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_CANCELLED = 7005;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_SKIPALREADYRUNNING = 7006;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED_ABANDONED = 7007;

	/// JobStatus
	public const ulong JOB_STATUS_FAILED__MAX = 7999;

	/// LDAPSecurityMethod
	public const string LDAPSECURITYMETHOD_PLAIN = "plain";

	/// LDAPSecurityMethod
	public const string LDAPSECURITYMETHOD_LDAPS = "ldaps";

	/// LDAPSecurityMethod
	public const string LDAPSECURITYMETHOD_STARTTLS = "starttls";

	/// MacOSCodesignLevel
	public const long MACOSCODESIGN_LEVEL_SIGN = 0;

	/// MacOSCodesignLevel
	public const long MACOSCODESIGN_LEVEL_SIGN_NOTARISE = 1;

	/// MacOSCodesignLevel
	public const long MACOSCODESIGN_LEVEL_SIGN_NOTARISE_STAPLE = 2;

	public const long MIXED_VIRTUAL_ACCOUNT_TYPE_USER = 1;

	public const long MIXED_VIRTUAL_ACCOUNT_TYPE_GROUP = 2;

	public const long MIXED_VIRTUAL_ACCOUNT_TYPE_TEAM_GROUP = 3;

	public const long MIXED_VIRTUAL_ACCOUNT_TYPE_SHAREPOINT_ONLY = 4;

	public const long MONGODB_DEFAULT_PORT = 27017;

	/// MSSQLAuthMode
	public const string MSSQL_AUTH_WINDOWS = "windows";

	/// MSSQLAuthMode
	public const string MSSQL_AUTH_NATIVE = "native";

	/// MSSQLMethod: On Windows x86_64, use the native x86_64 driver.
	public const string MSSQL_METHOD_OLEDB_NATIVE = "OLEDB_NATIVE";

	/// MSSQLMethod: On Windows x86_64, use an x86_32 OLEDB driver.
	public const string MSSQL_METHOD_OLEDB_32 = "OLEDB_32";

	/// MSSQLRestoreOpt
	public const string MSSQL_RESTORE_RECOVERY = "RECOVERY";

	/// MSSQLRestoreOpt
	public const string MSSQL_RESTORE_NORECOVERY = "NO_RECOVERY";

	public const string OFFICE365_REGION_PUBLIC = "GlobalPublicCloud";

	public const string OFFICE365_REGION_CHINA = "ChinaCloud";

	public const string OFFICE365_REGION_GERMANY = "GermanCloud";

	public const string OFFICE365_REGION_US_GOVT = "USGovtGccCloud";

	public const string OFFICE365_REGION_US_DOD = "USGovtGccDoDCloud";

	/// ExtraFileExclusionOSRestriction: Applies to any device
	public const long OS_ANY = 0;

	/// ExtraFileExclusionOSRestriction: Applies to all Windows devices, regardless of CPU type
	public const long OS_ONLY_WINDOWS = 1;

	/// ExtraFileExclusionOSRestriction: Applies to Windows devices with x86_32 CPU
	public const long OS_ONLY_WINDOWS_X8632 = 2;

	/// ExtraFileExclusionOSRestriction: Applies to Windows devices with x86_64 CPU
	public const long OS_ONLY_WINDOWS_X8664 = 3;

	/// ExtraFileExclusionOSRestriction: Applies to macOS devices, regardless of CPU type
	public const long OS_ONLY_MACOS = 4;

	/// ExtraFileExclusionOSRestriction: Applies to Linux devices (including Synology DSM), regardless of CPU type
	public const long OS_ONLY_LINUX = 5;

	/// When resetting a password with the API, set the PasswordFormat to this value. The Comet Server will re-hash the
	/// credential automatically.
	public const long PASSWORD_FORMAT_PLAINTEXT = 0;

	/// PSAType
	public const long PSA_TYPE_GENERIC = 0;

	/// PSAType
	public const long PSA_TYPE_GRADIENT = 1;

	public const string RELEASE_CODENAME = "Voyager";

	/// RemoteServerType
	public const string REMOTESERVER_COMET = "comet";

	/// RemoteServerType
	public const string REMOTESERVER_LDAP = "ldap";

	/// RemoteServerType
	public const string REMOTESERVER_B2 = "b2";

	/// RemoteServerType
	public const string REMOTESERVER_WASABI = "wasabi";

	/// RemoteServerType
	public const string REMOTESERVER_CUSTOM = "custom";

	/// RemoteServerType
	public const string REMOTESERVER_S3_GENERIC = "s3";

	/// RemoteServerType
	public const string REMOTESERVER_AWS = "aws";

	/// RemoteServerType
	public const string REMOTESERVER_STORJ = "storj";

	/// RemoteServerType
	public const string REMOTESERVER_IDRIVEE2 = "idrivee2";

	/// ReplicatorState
	public const long REPLICATOR_STATE_NONE = 0;

	/// ReplicatorState
	public const long REPLICATOR_STATE_FILE_LIST_WORKER_STARTED = 1;

	/// ReplicatorState
	public const long REPLICATOR_STATE_FILE_LIST_SYNC_RUNNING = 2;

	/// ReplicatorState
	public const long REPLICATOR_STATE_FILE_LIST_SYNC_FINISHED = 4;

	/// ReplicatorState
	public const long REPLICATOR_STATE_WORKERS_STARTED = 8;

	/// ReplicatorDisplayClass
	public const long REPLICATOR_DISPLAYCLASS_STORAGE = 100;

	/// ReplicatorDisplayClass
	public const long REPLICATOR_DISPLAYCLASS_USER = 101;

	/// RestoreArchiveFormat
	public const long RESTOREARCHIVEFORMAT_TAR = 0;

	/// RestoreArchiveFormat
	public const long RESTOREARCHIVEFORMAT_TARGZ = 1;

	/// RestoreArchiveFormat
	public const long RESTOREARCHIVEFORMAT_ZIP = 2;

	/// RestoreArchiveFormat: SquashFS container
	public const long RESTOREARCHIVEFORMAT_SQFS = 3;

	/// RestoreArchiveFormat
	public const long RESTOREARCHIVEFORMAT_TARZSTD = 4;

	/// RestoreType
	public const long RESTORETYPE_INVALID = -1;

	/// RestoreType
	public const long RESTORETYPE_FILE = 0;

	/// RestoreType
	public const long RESTORETYPE_NULL = 1;

	/// RestoreType
	public const long RESTORETYPE_PROCESS_PERFILE = 2;

	/// RestoreType
	public const long RESTORETYPE_PROCESS_ARCHIVE = 3;

	/// RestoreType
	public const long RESTORETYPE_WINDISK = 4;

	/// RestoreType
	public const long RESTORETYPE_FILE_ARCHIVE = 5;

	/// RestoreType
	public const long RESTORETYPE_OFFICE365_CLOUD = 6;

	/// RestoreType
	public const long RESTORETYPE_VMDK_FILE = 7;

	/// RestoreType
	public const long RESTORETYPE_VMDK_FILE_NULL = 8;

	/// RestoreType
	public const long RESTORETYPE_VMDK_FILE_ARCHIVE = 9;

	/// RestoreType
	public const long RESTORETYPE_MYSQL = 10;

	/// RestoreType
	public const long RESTORETYPE_MSSQL = 11;

	/// RestoreType: Legacy name alias - Prefer to use RESTORETYPE_PROCESS_ARCHIVE since multiple archive file formats are
	/// supported within this single RESTORETYPE_
	public const long RESTORETYPE_PROCESS_TARBALL = 3;

	/// RetentionMode: If this mode is set in a RetentionPolicy, then RetentionPolicy.Ranges should be ignored.
	public const long RETENTIONMODE_KEEP_EVERYTHING = 801;

	/// RetentionMode: Delete everything except for jobs matching the ranges in RetentionPolicy.Ranges.
	public const long RETENTIONMODE_DELETE_EXCEPT = 802;

	/// RetentionRangeType
	public const long RETENTIONRANGE__LOWEST = 900;

	/// RetentionRangeType: Uses Jobs
	public const long RETENTIONRANGE_MOST_RECENT_X_JOBS = 900;

	/// RetentionRangeType: Uses Timestamp
	public const long RETENTIONRANGE_NEWER_THAN_X = 901;

	/// RetentionRangeType: Uses Days, Weeks, Months
	public const long RETENTIONRANGE_JOBS_SINCE = 902;

	/// RetentionRangeType: Uses Days
	public const long RETENTIONRANGE_FIRST_JOB_FOR_EACH_LAST_X_DAYS = 903;

	/// RetentionRangeType
	public const long RETENTIONRANGE__RESERVED904 = 904;

	/// RetentionRangeType: Uses Months, MonthOffset
	public const long RETENTIONRANGE_FIRST_JOB_FOR_LAST_X_MONTHS = 905;

	/// RetentionRangeType: Uses Weeks, WeekOffset
	public const long RETENTIONRANGE_FIRST_JOB_FOR_LAST_X_WEEKS = 906;

	/// RetentionRangeType: Uses Jobs
	public const long RETENTIONRANGE_LAST_X_BACKUPS_ONE_FOR_EACH_DAY = 907;

	/// RetentionRangeType: Uses Jobs
	public const long RETENTIONRANGE_LAST_X_BACKUPS_ONE_FOR_EACH_WEEK = 908;

	/// RetentionRangeType: Uses Jobs
	public const long RETENTIONRANGE_LAST_X_BACKUPS_ONE_FOR_EACH_MONTH = 909;

	/// RetentionRangeType
	public const long RETENTIONRANGE__HIGHEST = 909;

	public const long RETENTIONRANGE_MAXINT = 1125899906842624;

	public const ulong SCHEDULE_FREQUENCY_LOWEST = 8010;

	/// SecondsPast should be a Unix timestamp, in seconds
	public const ulong SCHEDULE_FREQUENCY_ONCEONLY = 8010;

	/// SecondsPast is the number of seconds past 00:00, in the device's local timezone.
	public const ulong SCHEDULE_FREQUENCY_DAILY = 8011;

	/// SecondsPast is the number of seconds past *:00, in the device's local timezone.
	public const ulong SCHEDULE_FREQUENCY_HOURLY = 8012;

	/// SecondsPast is the number of seconds past 00:00 Sunday, in the device's local timezone.
	public const ulong SCHEDULE_FREQUENCY_WEEKLY = 8013;

	/// SecondsPast is the number of seconds past 00:00 1st, in the device's local timezone.
	public const ulong SCHEDULE_FREQUENCY_MONTHLY = 8014;

	/// SecondsPast is the number of seconds per period. Offset: Shunt seconds after unix epoch
	public const ulong SCHEDULE_FREQUENCY_PERIODIC = 8015;

	public const ulong SCHEDULE_FREQUENCY_HIGHEST = 8015;

	/// Maximum random delay (5 hours)
	public const long SCHEDULE_MAX_RANDOM_DELAY_SECS = 18000;

	public const long SCHEDULE_MAXINT = 1125899906842624;

	/// SearchClauseType
	public const string SEARCHCLAUSE_RULE = "";

	/// SearchClauseType
	public const string SEARCHCLAUSE_AND = "and";

	/// SearchClauseType
	public const string SEARCHCLAUSE_OR = "or";

	/// SearchClauseType
	public const string SEARCHCLAUSE_NOT_AND = "not_and";

	/// SearchClauseType
	public const string SEARCHCLAUSE_NOT_OR = "not_or";

	public const string SEARCHOPERATOR_STRING_EQ = "str_eq";

	public const string SEARCHOPERATOR_STRING_NEQ = "str_neq";

	public const string SEARCHOPERATOR_STRING_CONTAINS = "str_contains";

	public const string SEARCHOPERATOR_STRING_NCONTAINS = "str_ncontains";

	public const string SEARCHOPERATOR_STRING_STARTSWITH = "str_startswith";

	public const string SEARCHOPERATOR_STRING_NSTARTSWITH = "str_nstartswith";

	public const string SEARCHOPERATOR_STRING_ENDSWITH = "str_endswith";

	public const string SEARCHOPERATOR_STRING_NENDSWITH = "str_nendswith";

	public const string SEARCHOPERATOR_STRING_EQ_CI = "str_eq_ci";

	public const string SEARCHOPERATOR_STRING_NEQ_CI = "str_neq_ci";

	public const string SEARCHOPERATOR_STRING_CONTAINS_CI = "str_contains_ci";

	public const string SEARCHOPERATOR_STRING_NCONTAINS_CI = "str_ncontains_ci";

	public const string SEARCHOPERATOR_STRING_STARTSWITH_CI = "str_startswith_ci";

	public const string SEARCHOPERATOR_STRING_NSTARTSWITH_CI = "str_nstartswith_ci";

	public const string SEARCHOPERATOR_STRING_ENDSWITH_CI = "str_endswith_ci";

	public const string SEARCHOPERATOR_STRING_NENDSWITH_CI = "str_nendswith_ci";

	public const string SEARCHOPERATOR_STRING_REGEXMATCH = "str_regexmatch";

	public const string SEARCHOPERATOR_STRING_NREGEXMATCH = "str_nregexmatch";

	public const string SEARCHOPERATOR_INT_EQ = "int_eq";

	public const string SEARCHOPERATOR_INT_NEQ = "int_neq";

	public const string SEARCHOPERATOR_INT_GT = "int_gt";

	public const string SEARCHOPERATOR_INT_GTE = "int_gte";

	public const string SEARCHOPERATOR_INT_LT = "int_lt";

	public const string SEARCHOPERATOR_INT_LTE = "int_lte";

	public const string SEARCHOPERATOR_BOOL_IS = "bool_is";

	public const string SEARCHOPERATOR_BOOL_NIS = "bool_nis";

	public const long SERVICE_CALENDAR = 1;

	public const long SERVICE_CONTACT = 2;

	public const long SERVICE_MAIL = 4;

	public const long SERVICE_SHAREPOINT = 8;

	public const long SERVICE_ONEDRIVE = 16;

	/// DefaultSettingMode
	public const long SETTING_SYSTEM_DEFAULT = 0;

	/// DefaultSettingMode
	public const long SETTING_OPTIONAL_DEFAULT_ON = 1;

	/// DefaultSettingMode
	public const long SETTING_OPTIONAL_DEFAULT_OFF = 2;

	/// DefaultSettingMode
	public const long SETTING_ENFORCED_ON = 3;

	/// DefaultSettingMode
	public const long SETTING_ENFORCED_OFF = 4;

	/// Severity
	public const string SEVERITY_INFO = "I";

	/// Severity
	public const string SEVERITY_WARNING = "W";

	/// Severity
	public const string SEVERITY_ERROR = "E";

	/// StreamableEventType
	public const long SEVT__MIN = 4000;

	/// StreamableEventType: This event is emitted when the webhook is registered, or when the server starts up. The Data
	/// associated is ServerMetaVersionInfo
	public const long SEVT_META_HELLO = 4000;

	/// StreamableEventType: Data is the profile object
	public const long SEVT_ACCOUNT_NEW = 4100;

	/// StreamableEventType: Data is the username
	public const long SEVT_ACCOUNT_REMOVED = 4101;

	/// StreamableEventType: Data is the profile object
	public const long SEVT_ACCOUNT_UPDATED = 4102;

	/// StreamableEventType
	public const long SEVT_JOB_NEW = 4200;

	/// StreamableEventType
	public const long SEVT_JOB_COMPLETED = 4201;

	/// StreamableEventType: Data is the string bucket ref
	public const long SEVT_BUCKET_NEW = 4300;

	/// StreamableEventType
	public const long SEVT__MAX = 4999;

	/// SSHAuthMode
	public const ulong SSHCONNECTION_AUTHMODE__INVALID = 0;

	/// SSHAuthMode
	public const ulong SSHCONNECTION_AUTHMODE_PASSWORD = 1;

	/// SSHAuthMode
	public const ulong SSHCONNECTION_AUTHMODE_PRIVATEKEY = 2;

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_FILE = "file";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_DIRECTORY = "dir";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_SYMLINK = "symlink";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_UNIXBLOCKDEVICE = "dev";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_UNIXCHARDEVICE = "chardev";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_UNIXFIFO = "fifo";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_UNIXSOCKET = "socket";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_WINEFS = "winefs";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_EMAILMESSAGE = "emailmessage";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_EMAILFOLDER = "mailfolder";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_OFFICECONTACT = "contact";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_OFFICECONTACTFOLDER = "contactfolder";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_OFFICECALENDAREVENT = "calendarevent";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_OFFICECALENDAR = "calendar";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_MSSITE = "mssite";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_MSSITE_TEAM = "mssiteteam";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_MSSITELISTENTITY = "mssitelistentity";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_MSSITEITEMENTITY = "mssiteitementity";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_MSSITELISTDRIVEENTITY = "mssitelistdriveentity";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_VMDK_FILE = "vmdkfile";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_VMDK_DIRECTORY = "vmdkdir";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_VMDK_WINEFS = "vmdkwinefs";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_VMDK_SYMLINK = "vmdksymlink";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_VIRTUALIMAGE_DISK = "virtualimagedisk";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_VHDX_GPT_PARTITION = "vhdxpartitiongpt";

	/// StoredObjectType
	public const string STOREDOBJECTTYPE_VHDX_MBR_PARTITION = "vhdxpartitionmbr";

	/// If an API response returns in failure, but it includes this value in the CometAPIResponseMessage->Message
	/// parameter, it indicates that your supplied authentication was insufficient, and you must supply additional
	/// two-factor authentication credentials.
	public const string TOTPRequiredError = "ERR_TOTP_REQUIRED";

	/// UpdateStatus
	public const long UPDATESTATUS_NOT_SEEN = 0;

	/// UpdateStatus: The selected device does not meet the filter criteria from the Bulk Update Campaign's configuration.
	public const long UPDATESTATUS_INELIGIBLE = 1;

	/// UpdateStatus
	public const long UPDATESTATUS_PENDING = 2;

	/// UpdateStatus: The device has made a live connection and it meets the filter criteria. A live connection message has
	/// been sent asking it to perform the software upgrade.
	public const long UPDATESTATUS_REQUEST_MADE = 3;

	/// UpdateStatus: An update signal was sent to the device, but when it reconnected, it did not advertise the target
	/// software version. It's likely that the update failed - please check the device's Update log for more information.
	public const long UPDATESTATUS_UPDATE_FAILED = 4;

	/// UpdateStatus: The device has successfully updated to the target version.
	public const long UPDATESTATUS_UPDATE_CONFIRMED = 5;

	/// If an API response returns in failure, but it includes this value in the CometAPIResponseMessage->Message
	/// parameter, it indicates that the specified Device ID was invalid or not found.
	public const string UnknownDeviceError = "ERR_UNKNOWN_DEVICE";

	public const string UnsupportVhdxFileSystem = "ERR_UNSUPPORT_VHDX_FILE_SYSTEM";

	public const string UnsupportVmdkFileSystem = "ERR_UNSUPPORT_VMDK_FILE_SYSTEM";

	public const string VhdxPartitonReadErrMsg = "ERR_VHDX_PARTITION";

	/// WebAuthnDeviceType
	public const long WEBAUTHN_DEVICE_TYPE__UNKNOWN = 0;

	/// WebAuthnDeviceType
	public const long WEBAUTHN_DEVICE_TYPE__HARDWARE_TOKEN = 1;

	/// WebAuthnDeviceType
	public const long WEBAUTHN_DEVICE_TYPE__ANDROID = 2;

	/// WebAuthnDeviceType
	public const long WEBAUTHN_DEVICE_TYPE__APPLE = 3;

	/// WebAuthnDeviceType
	public const long WEBAUTHN_DEVICE_TYPE__TPM_GENERIC = 4;

	/// WebAuthnDeviceType
	public const long WEBAUTHN_DEVICE_TYPE__TPM_WINDOWS = 5;

	/// WebAuthnDeviceType
	public const long WEBAUTHN_DEVICE_TYPE__TPM_LINUX = 6;

	/// WindowsCodesignMethod: When upgrading from a version of Comet Server prior to 22.12.7, this option will be
	/// automatically converted to a more specific type..
	public const long WINDOWSCODESIGN_METHOD_AUTO = 0;

	/// WindowsCodesignMethod: Do not perform Authenticode codesigning
	public const long WINDOWSCODESIGN_METHOD_DISABLED = 1;

	/// WindowsCodesignMethod: Use a configured PKCS#12 key file for Authenticode codesigning
	public const long WINDOWSCODESIGN_METHOD_PKCS12FILE = 2;

	/// WindowsCodesignMethod: Use a configured PKCS#11 hardware security module (HSM) for Authenticode codesigning
	public const long WINDOWSCODESIGN_METHOD_PKCS11HSM = 3;

	/// WindowsCodesignMethod: Use a configured Azure Key Vault for Authenticode codesigning
	public const long WINDOWSCODESIGN_METHOD_AZUREKEYVAULT = 4;

}}