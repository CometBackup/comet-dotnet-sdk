// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SourceStatistics</c>
/// </summary>
public class SourceStatistics {

	[JsonPropertyName("LastBackupJob")]
	public BackupJobDetail LastBackupJob { get; set; }

	[JsonPropertyName("LastSuccessfulBackupJob")]
	public BackupJobDetail LastSuccessfulBackupJob { get; set; }

	public SourceStatistics(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SourceStatistics FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SourceStatistics>(jsStr);
	}

}
}
