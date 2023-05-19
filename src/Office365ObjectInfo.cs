// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>Office365ObjectInfo</c>
/// </summary>
public class Office365ObjectInfo {
	public string GUID { get; set; } = "";
	public string Name { get; set; } = "";
	public string Type { get; set; } = "";
	public string Value { get; set; } = "";
	public List<string> Members { get; set; } = new List<string>();

	public Office365ObjectInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public Office365ObjectInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<Office365ObjectInfo>(jsStr);
	}

}
}
