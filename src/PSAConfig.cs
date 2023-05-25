// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>PSAConfig</c>
/// </summary>
public class PSAConfig {
	public bool AlertsDisabled { get; set; }
	public Dictionary<string, string> CustomHeaders { get; set; }
	public string PartnerKey { get; set; } = string.Empty;
	public long Type { get; set; }
	public string URL { get; set; } = string.Empty;

	public PSAConfig(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public PSAConfig FromJson(string jsStr) {
		return JsonSerializer.Deserialize<PSAConfig>(jsStr);
	}

}
}