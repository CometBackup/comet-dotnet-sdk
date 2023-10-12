// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>PSAGroupedBy</c>
/// </summary>
public class PSAGroupedBy {

	[JsonPropertyName("Users")]
	public bool Users { get; set; }

	[JsonPropertyName("Tenants")]
	public bool Tenants { get; set; }

	[JsonPropertyName("AccountName")]
	public bool AccountName { get; set; }

	public PSAGroupedBy(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public PSAGroupedBy FromJson(string jsStr) {
		return JsonSerializer.Deserialize<PSAGroupedBy>(jsStr);
	}

}
}