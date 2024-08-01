// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>UserPolicy</c>
/// </summary>
public class UserPolicy {

	[JsonPropertyName("PreventRequestStorageVault")]
	public bool PreventRequestStorageVault { get; set; }

	[JsonPropertyName("PreventAddCustomStorageVault")]
	public bool PreventAddCustomStorageVault { get; set; }

	[JsonPropertyName("PreventEditStorageVault")]
	public bool PreventEditStorageVault { get; set; }

	[JsonPropertyName("HideCloudStorageBranding")]
	public bool HideCloudStorageBranding { get; set; }

	[JsonPropertyName("PreventDeleteStorageVault")]
	public bool PreventDeleteStorageVault { get; set; }

	[JsonPropertyName("StorageVaultProviders")]
	public StorageVaultProviderPolicy StorageVaultProviders { get; set; }

	[JsonPropertyName("PreventNewProtectedItem")]
	public bool PreventNewProtectedItem { get; set; }

	[JsonPropertyName("PreventEditProtectedItem")]
	public bool PreventEditProtectedItem { get; set; }

	[JsonPropertyName("PreventDeleteProtectedItem")]
	public bool PreventDeleteProtectedItem { get; set; }

	[JsonPropertyName("ProtectedItemEngineTypes")]
	public ProtectedItemEngineTypePolicy ProtectedItemEngineTypes { get; set; }

	[JsonPropertyName("FileAndFolderMandatoryExclusions")]
	public List<ExtraFileExclusion> FileAndFolderMandatoryExclusions { get; set; }

	[JsonPropertyName("ModeScheduleSkipAlreadyRunning")]
	public long ModeScheduleSkipAlreadyRunning { get; set; }

	[JsonPropertyName("ModeScheduleLastJobFailDoRetry")]
	public long ModeScheduleLastJobFailDoRetry { get; set; }

	[JsonPropertyName("ModeLastJobFailDoRetryTime")]
	public ulong ModeLastJobFailDoRetryTime { get; set; }

	[JsonPropertyName("ModeLastJobFailDoRetryCount")]
	public ulong ModeLastJobFailDoRetryCount { get; set; }

	[JsonPropertyName("ModeAdminResetPassword")]
	public long ModeAdminResetPassword { get; set; }

	[JsonPropertyName("ModeAdminViewFilenames")]
	public long ModeAdminViewFilenames { get; set; }

	[JsonPropertyName("ModeRequireUserResetPassword")]
	public long ModeRequireUserResetPassword { get; set; }

	[JsonPropertyName("PreventDeleteSingleSnapshots")]
	public bool PreventDeleteSingleSnapshots { get; set; }

	[JsonPropertyName("PreventChangeAccountPassword")]
	public bool PreventChangeAccountPassword { get; set; }

	[JsonPropertyName("PreventChangeEmailSettings")]
	public bool PreventChangeEmailSettings { get; set; }

	[JsonPropertyName("PreventChangeAccountName")]
	public bool PreventChangeAccountName { get; set; }

	[JsonPropertyName("PreventOpenAppUI")]
	public bool PreventOpenAppUI { get; set; }

	[JsonPropertyName("RequirePasswordOpenAppUI")]
	public bool RequirePasswordOpenAppUI { get; set; }

	[JsonPropertyName("HideAppImport")]
	public bool HideAppImport { get; set; }

	[JsonPropertyName("HideAppVersion")]
	public bool HideAppVersion { get; set; }

	[JsonPropertyName("PreventOpenWebUI")]
	public bool PreventOpenWebUI { get; set; }

	[JsonPropertyName("PreventViewDeviceNames")]
	public bool PreventViewDeviceNames { get; set; }

	[JsonPropertyName("DefaultEmailReports")]
	public DefaultEmailReportPolicy DefaultEmailReports { get; set; }

	[JsonPropertyName("DefaultStorageVaultRetention")]
	public RetentionPolicy DefaultStorageVaultRetention { get; set; }

	[JsonPropertyName("EnforceStorageVaultRetention")]
	public bool EnforceStorageVaultRetention { get; set; }

	[JsonPropertyName("PreventProtectedItemRetention")]
	public bool PreventProtectedItemRetention { get; set; }

	[JsonPropertyName("AllowEditObjectLockRetention")]
	public bool AllowEditObjectLockRetention { get; set; }

	[JsonPropertyName("DefaultSources")]
	public Dictionary<string, SourceConfig> DefaultSources { get; set; }

	[JsonPropertyName("DefaultSourcesBackupRules")]
	public Dictionary<string, BackupRuleConfig> DefaultSourcesBackupRules { get; set; }

	[JsonPropertyName("DefaultSourcesWithOSRestriction")]
	public Dictionary<string, DefaultSourceWithOSRestriction> DefaultSourcesWithOSRestriction { get; set; }

	[JsonPropertyName("DefaultBackupRules")]
	public Dictionary<string, BackupRuleConfig> DefaultBackupRules { get; set; }

	[JsonPropertyName("RandomDelaySecs")]
	public ulong RandomDelaySecs { get; set; }

	public UserPolicy(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public UserPolicy FromJson(string jsStr) {
		return JsonSerializer.Deserialize<UserPolicy>(jsStr);
	}

}
}
