// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SizeMeasurement</c>
/// </summary>
public class SizeMeasurement {

	[JsonPropertyName("Size")]
	//Bytes
	public long Size { get; set; }

	[JsonPropertyName("MeasureStarted")]
	//Unix timestamp in seconds
	public long MeasureStarted { get; set; }

	[JsonPropertyName("MeasureCompleted")]
	//Unix timestamp in seconds
	public long MeasureCompleted { get; set; }

	public SizeMeasurement(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SizeMeasurement FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SizeMeasurement>(jsStr);
	}

}
}
