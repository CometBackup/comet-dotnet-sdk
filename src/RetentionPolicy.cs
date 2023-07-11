// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>RetentionPolicy</c>
/// </summary>
public class RetentionPolicy {

	[JsonPropertyName("Mode")]
	//One of the RETENTIONMODE_ constants
	public long Mode { get; set; }

	[JsonPropertyName("Ranges")]
	public List<RetentionRange> Ranges { get; set; }

	public RetentionPolicy(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public RetentionPolicy FromJson(string jsStr) {
		return JsonSerializer.Deserialize<RetentionPolicy>(jsStr);
	}

}
}
