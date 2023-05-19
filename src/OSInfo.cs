// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>OSInfo</c>
/// </summary>
public class OSInfo {

	[JsonPropertyName("version")]
	public string Version { get; set; } = "";

	[JsonPropertyName("distribution")]
	public string Distribution { get; set; } = "";

	[JsonPropertyName("build")]
	public string Build { get; set; } = "";

	public OSInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public OSInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<OSInfo>(jsStr);
	}

}
}
