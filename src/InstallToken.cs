// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>InstallToken</c>
/// </summary>
public class InstallToken {
	public string Username { get; set; } = string.Empty;
	public string Server { get; set; } = string.Empty;
	public string Token { get; set; } = string.Empty;
	public long CreateTime { get; set; }
	public bool Used { get; set; }
	public long ExpireTime { get; set; }

	public InstallToken(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public InstallToken FromJson(string jsStr) {
		return JsonSerializer.Deserialize<InstallToken>(jsStr);
	}

}
}