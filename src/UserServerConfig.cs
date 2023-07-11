// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>UserServerConfig</c>
/// </summary>
public class UserServerConfig {

	[JsonPropertyName("RandomDelaySecs")]
	public ulong RandomDelaySecs { get; set; }

	public UserServerConfig(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public UserServerConfig FromJson(string jsStr) {
		return JsonSerializer.Deserialize<UserServerConfig>(jsStr);
	}

}
}
