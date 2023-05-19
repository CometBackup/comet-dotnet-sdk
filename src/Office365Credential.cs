// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>Office365Credential</c>
/// </summary>
public class Office365Credential {
	public string AppID { get; set; } = "";
	public string TenantID { get; set; } = "";
	public string Secret { get; set; } = "";
	public string AppCert { get; set; } = "";
	public string Region { get; set; } = "";

	public Office365Credential(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public Office365Credential FromJson(string jsStr) {
		return JsonSerializer.Deserialize<Office365Credential>(jsStr);
	}

}
}
