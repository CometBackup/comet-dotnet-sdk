// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>VaultSnapshot</c>
/// </summary>
public class VaultSnapshot {
	public string Snapshot { get; set; } = string.Empty;
	public string Source { get; set; } = string.Empty;
	public long CreateTime { get; set; }
	public bool HasOriginalPathInfo { get; set; }

	public VaultSnapshot(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public VaultSnapshot FromJson(string jsStr) {
		return JsonSerializer.Deserialize<VaultSnapshot>(jsStr);
	}

}
}
