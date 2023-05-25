// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SourceBasicInfo</c>
/// </summary>
public class SourceBasicInfo {
	public string Description { get; set; } = string.Empty;
	public long O365AccountCount { get; set; }
	public long Size { get; set; }
	public Dictionary<string, RetentionPolicy> OverrideDestinationRetention { get; set; }

	public SourceBasicInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SourceBasicInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SourceBasicInfo>(jsStr);
	}

}
}