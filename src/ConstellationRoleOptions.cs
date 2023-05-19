// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ConstellationRoleOptions</c>
/// </summary>
public class ConstellationRoleOptions {
	public bool RoleEnabled { get; set; }
	public bool DeleteUnusedData { get; set; }
	public List<RemoteServerAddress> Servers { get; set; } = new List<RemoteServerAddress>();

	public ConstellationRoleOptions(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ConstellationRoleOptions FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ConstellationRoleOptions>(jsStr);
	}

}
}
