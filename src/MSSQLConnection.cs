// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>MSSQLConnection</c>
/// </summary>
public class MSSQLConnection {
	public string Type { get; set; } = "";
	public string Username { get; set; } = "";
	public string Password { get; set; } = "";
	public string Hostname { get; set; } = "";
	public string InstanceName { get; set; } = "";
	public string Method { get; set; } = "";

	public MSSQLConnection(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public MSSQLConnection FromJson(string jsStr) {
		return JsonSerializer.Deserialize<MSSQLConnection>(jsStr);
	}

}
}
