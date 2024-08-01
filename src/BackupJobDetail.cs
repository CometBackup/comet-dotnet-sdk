// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>BackupJobDetail</c>
/// </summary>
public class BackupJobDetail {

	[JsonPropertyName("GUID")]
	public string GUID { get; set; } = string.Empty;

	[JsonPropertyName("Username")]
	public string Username { get; set; } = string.Empty;

	[JsonPropertyName("Classification")]
	public ulong Classification { get; set; }

	[JsonPropertyName("Status")]
	public ulong Status { get; set; }

	[JsonPropertyName("StartTime")]
	//Unix timestamp in seconds
	public long StartTime { get; set; }

	[JsonPropertyName("EndTime")]
	//Unix timestamp in seconds. Will be zero if the job is still running.
	public long EndTime { get; set; }

	[JsonPropertyName("RetryCount")]
	public long RetryCount { get; set; }

	[JsonPropertyName("SourceGUID")]
	//The Protected Item that this job is for
	public string SourceGUID { get; set; } = string.Empty;

	[JsonPropertyName("DestinationGUID")]
	//The Storage Vault that this job is for
	public string DestinationGUID { get; set; } = string.Empty;

	[JsonPropertyName("DeviceID")]
	public string DeviceID { get; set; } = string.Empty;

	[JsonPropertyName("SnapshotID")]
	public string SnapshotID { get; set; } = string.Empty;

	[JsonPropertyName("BackupRuleGUID")]
	//The ID of the backup rule that contains the schedule that triggered this job
	public string BackupRuleGUID { get; set; } = string.Empty;

	[JsonPropertyName("ClientVersion")]
	public string ClientVersion { get; set; } = string.Empty;

	[JsonPropertyName("TotalDirectories")]
	public long TotalDirectories { get; set; }

	[JsonPropertyName("TotalFiles")]
	public long TotalFiles { get; set; }

	[JsonPropertyName("TotalSize")]
	public long TotalSize { get; set; }

	[JsonPropertyName("TotalChunks")]
	public long TotalChunks { get; set; }

	[JsonPropertyName("UploadSize")]
	public long UploadSize { get; set; }

	[JsonPropertyName("DownloadSize")]
	public long DownloadSize { get; set; }

	[JsonPropertyName("TotalVmCount")]
	//For Hyper-V and VMware backup jobs, the total number of virtual machines.
	public long TotalVmCount { get; set; }

	[JsonPropertyName("TotalMailsCount")]
	//For Office 365 backup jobs, the total number of mailboxes.
	public long TotalMailsCount { get; set; }

	[JsonPropertyName("TotalSitesCount")]
	//For Office 365 backup jobs, the total number of SharePoint sites.
	public long TotalSitesCount { get; set; }

	[JsonPropertyName("TotalAccountsCount")]
	//For Office 365 backup jobs, the calculated effective number of protected accounts.
	public long TotalAccountsCount { get; set; }

	[JsonPropertyName("TotalLicensedMailsCount")]
	//For Office 365 backup jobs, the number of licensed mailboxes.
	public long TotalLicensedMailsCount { get; set; }

	[JsonPropertyName("TotalUnlicensedMailsCount")]
	//For Office 365 backup jobs, the number of unlicensed mailboxes.
	public long TotalUnlicensedMailsCount { get; set; }

	[JsonPropertyName("CancellationID")]
	//If this field is present, it is possible to request cancellation of this job via the API.
	public string CancellationID { get; set; } = string.Empty;

	[JsonPropertyName("Progress")]
	//If this backup job is still running, additional partial-progress information may be present in this field.
	public BackupJobProgress Progress { get; set; }

	[JsonPropertyName("DestinationSizeStart")]
	//The size of the Storage Vault, as measured at the start of the job.
	public SizeMeasurement DestinationSizeStart { get; set; }

	[JsonPropertyName("DestinationSizeEnd")]
	//The size of the Storage Vault, as measured at the end of the job.
	public SizeMeasurement DestinationSizeEnd { get; set; }

	public BackupJobDetail(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public BackupJobDetail FromJson(string jsStr) {
		return JsonSerializer.Deserialize<BackupJobDetail>(jsStr);
	}

}
}
