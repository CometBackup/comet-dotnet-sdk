// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>StorjVirtualStorageRoleSetting</c>
/// </summary>
public class StorjVirtualStorageRoleSetting {

	[JsonPropertyName("SatelliteAddress")]
	public string SatelliteAddress { get; set; } = string.Empty;

	[JsonPropertyName("APIKey")]
	public string APIKey { get; set; } = string.Empty;

	[JsonPropertyName("Passphrase")]
	public string Passphrase { get; set; } = string.Empty;

	[JsonPropertyName("Bucket")]
	public string Bucket { get; set; } = string.Empty;

	public StorjVirtualStorageRoleSetting(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public StorjVirtualStorageRoleSetting FromJson(string jsStr) {
		return JsonSerializer.Deserialize<StorjVirtualStorageRoleSetting>(jsStr);
	}

}
}
