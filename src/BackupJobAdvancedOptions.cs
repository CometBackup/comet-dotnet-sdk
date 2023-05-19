// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>BackupJobAdvancedOptions</c>
/// </summary>
public class BackupJobAdvancedOptions {
	public bool SkipAlreadyRunning { get; set; }
	public long StopAfter { get; set; }
	public long LimitVaultSpeedBps { get; set; }
	public bool ReduceDiskConcurrency { get; set; }
	public bool UseOnDiskIndexes { get; set; }
	public bool AllowZeroFilesSuccess { get; set; }
	public long AutoRetentionLevel { get; set; }

	public BackupJobAdvancedOptions(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public BackupJobAdvancedOptions FromJson(string jsStr) {
		return JsonSerializer.Deserialize<BackupJobAdvancedOptions>(jsStr);
	}

}
}
