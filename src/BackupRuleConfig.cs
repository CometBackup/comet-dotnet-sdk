// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>BackupRuleConfig</c> A backup rule connects one source Protected Item and one destination Storage Vault,
/// with multiple time schedules or event triggers
/// </summary>
public class BackupRuleConfig {
	public string Description { get; set; } = string.Empty;
	//Unix timestamp in seconds
	public long CreateTime { get; set; }
	//Unix timestamp in seconds. The caller is responsible for updating this themselves.
	public long ModifyTime { get; set; }
	//Custom commands to run before the job
	public List<string> PreExec { get; set; }
	//Custom commands to run after taking a disk snapshot
	public List<string> ThawExec { get; set; }
	//Custom commands to run after the job
	public List<string> PostExec { get; set; }
	//The source Protected Item ID to back up from, during this schedule
	public string Source { get; set; } = string.Empty;
	//The destination Storage Vault ID to back up to, during this schedule
	public string Destination { get; set; } = string.Empty;
	public bool SkipAlreadyRunning { get; set; }
	//If Zero: disabled
	public long StopAfter { get; set; }
	//If Zero: disabled
	public long LimitVaultSpeedBps { get; set; }
	//Default disabled
	public bool ReduceDiskConcurrency { get; set; }
	//Default disabled
	public bool UseOnDiskIndexes { get; set; }
	//Default disabled
	public bool AllowZeroFilesSuccess { get; set; }
	//If Zero: default Automatic (BACKUPJOBAUTORETENTION_AUTOMATIC)
	public long AutoRetentionLevel { get; set; }
	//Scheduled start times
	public List<ScheduleConfig> Schedules { get; set; }
	//Other events that will cause this scheduled job to start
	public BackupRuleEventTriggers EventTriggers { get; set; }

	public BackupRuleConfig(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public BackupRuleConfig FromJson(string jsStr) {
		return JsonSerializer.Deserialize<BackupRuleConfig>(jsStr);
	}

	public BackupJobAdvancedOptions GetEmbeddedBackupJobAdvancedOptions() => new BackupJobAdvancedOptions {
		SkipAlreadyRunning = this.SkipAlreadyRunning,
		StopAfter = this.StopAfter,
		LimitVaultSpeedBps = this.LimitVaultSpeedBps,
		ReduceDiskConcurrency = this.ReduceDiskConcurrency,
		UseOnDiskIndexes = this.UseOnDiskIndexes,
		AllowZeroFilesSuccess = this.AllowZeroFilesSuccess,
		AutoRetentionLevel = this.AutoRetentionLevel,
	};

	public void SetEmbeddedBackupJobAdvancedOptions(BackupJobAdvancedOptions other){
		this.SkipAlreadyRunning = other.SkipAlreadyRunning;
		this.StopAfter = other.StopAfter;
		this.LimitVaultSpeedBps = other.LimitVaultSpeedBps;
		this.ReduceDiskConcurrency = other.ReduceDiskConcurrency;
		this.UseOnDiskIndexes = other.UseOnDiskIndexes;
		this.AllowZeroFilesSuccess = other.AllowZeroFilesSuccess;
		this.AutoRetentionLevel = other.AutoRetentionLevel;
	}

}
}
