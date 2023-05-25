// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>AvailableDownload</c>
/// </summary>
public class AvailableDownload {
	public string Category { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public bool Recommended { get; set; }

	public AvailableDownload(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public AvailableDownload FromJson(string jsStr) {
		return JsonSerializer.Deserialize<AvailableDownload>(jsStr);
	}

}
}