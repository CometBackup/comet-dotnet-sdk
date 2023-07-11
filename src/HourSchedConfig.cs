// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>HourSchedConfig</c>
/// </summary>
public class HourSchedConfig {

	[JsonPropertyName("Hour")]
	public ulong Hour { get; set; }

	[JsonPropertyName("Minutes")]
	public ulong Minutes { get; set; }

	public HourSchedConfig(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public HourSchedConfig FromJson(string jsStr) {
		return JsonSerializer.Deserialize<HourSchedConfig>(jsStr);
	}

}
}
