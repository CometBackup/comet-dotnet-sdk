// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>StorageVaultProviderPolicy</c>
/// </summary>
public class StorageVaultProviderPolicy {

	[JsonPropertyName("ShouldRestrictProviderList")]
	public bool ShouldRestrictProviderList { get; set; }

	[JsonPropertyName("AllowedProvidersWhenRestricted")]
	public List<ulong> AllowedProvidersWhenRestricted { get; set; }

	public StorageVaultProviderPolicy(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public StorageVaultProviderPolicy FromJson(string jsStr) {
		return JsonSerializer.Deserialize<StorageVaultProviderPolicy>(jsStr);
	}

}
}
