// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>UserOnServer</c>
/// </summary>
public class UserOnServer {
	//The server where this user was found. The 0-based indexes here correspond to the entries inside
	//ConstellationRoleOptions->Servers.
	public long ServerID { get; set; }
	public string Username { get; set; } = string.Empty;

	public UserOnServer(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public UserOnServer FromJson(string jsStr) {
		return JsonSerializer.Deserialize<UserOnServer>(jsStr);
	}

}
}