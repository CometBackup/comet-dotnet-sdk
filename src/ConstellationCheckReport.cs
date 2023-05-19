// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ConstellationCheckReport</c>
/// </summary>
public class ConstellationCheckReport {
	public long CheckStarted { get; set; }
	public long CheckCompleted { get; set; }
	public Dictionary<string, BucketUsageInfo> Usage { get; set; } = new Dictionary<string, BucketUsageInfo>();

	public ConstellationCheckReport(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ConstellationCheckReport FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ConstellationCheckReport>(jsStr);
	}

}
}
