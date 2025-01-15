// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>UserGroup</c>
/// </summary>
public class UserGroup {

	[JsonPropertyName("CreatedAt")]
	//Unix timestamp in seconds
	public long CreatedAt { get; set; }

	[JsonPropertyName("OrganizationID")]
	public string OrganizationID { get; set; } = string.Empty;

	[JsonPropertyName("Name")]
	public string Name { get; set; } = string.Empty;

	public UserGroup(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public UserGroup FromJson(string jsStr) {
		return JsonSerializer.Deserialize<UserGroup>(jsStr);
	}

}
}
