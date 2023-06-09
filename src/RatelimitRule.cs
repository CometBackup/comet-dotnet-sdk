// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>RatelimitRule</c>
/// </summary>
public class RatelimitRule {

	[JsonPropertyName("MatchRegex")]
	public string MatchRegex { get; set; } = string.Empty;

	[JsonPropertyName("BytesPerSecond")]
	public ulong BytesPerSecond { get; set; }

	public RatelimitRule(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public RatelimitRule FromJson(string jsStr) {
		return JsonSerializer.Deserialize<RatelimitRule>(jsStr);
	}

}
}
