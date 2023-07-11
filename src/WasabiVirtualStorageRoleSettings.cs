// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>WasabiVirtualStorageRoleSettings</c>
/// </summary>
public class WasabiVirtualStorageRoleSettings {

	[JsonPropertyName("MasterBucket")]
	public string MasterBucket { get; set; } = string.Empty;

	[JsonPropertyName("AccessKey")]
	public string AccessKey { get; set; } = string.Empty;

	[JsonPropertyName("SecretKey")]
	public string SecretKey { get; set; } = string.Empty;

	[JsonPropertyName("UseObjectLock")]
	public bool UseObjectLock { get; set; }

	[JsonPropertyName("ObjectLockDays")]
	public long ObjectLockDays { get; set; }

	[JsonPropertyName("RemoveDeleted")]
	public bool RemoveDeleted { get; set; }

	public WasabiVirtualStorageRoleSettings(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public WasabiVirtualStorageRoleSettings FromJson(string jsStr) {
		return JsonSerializer.Deserialize<WasabiVirtualStorageRoleSettings>(jsStr);
	}

}
}
