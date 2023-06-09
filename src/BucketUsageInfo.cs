// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>BucketUsageInfo</c>
/// </summary>
public class BucketUsageInfo {

	[JsonPropertyName("AccessKey")]
	public string AccessKey { get; set; } = string.Empty;

	[JsonPropertyName("ExistsOnServers")]
	//The servers where this bucket was found. The 0-based indexes here correspond to the entries inside
	//ConstellationRoleOptions->Servers.
	public List<long> ExistsOnServers { get; set; }

	[JsonPropertyName("InUseBy")]
	public List<UserOnServer> InUseBy { get; set; }

	public BucketUsageInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public BucketUsageInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<BucketUsageInfo>(jsStr);
	}

}
}
