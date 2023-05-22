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
	public string GUID { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string Type { get; set; } = string.Empty;
	//May be an email address or a SharePoint site URL
	public string Value { get; set; } = string.Empty;
	public List<string> Members { get; set; }

	public Office365ObjectInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public Office365ObjectInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<Office365ObjectInfo>(jsStr);
	}

}
}
