// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>StorjDestinationLocation</c>
/// </summary>
public class StorjDestinationLocation {

	[JsonPropertyName("SatelliteAddress")]
	public string SatelliteAddress { get; set; } = string.Empty;

	[JsonPropertyName("APIKey")]
	public string APIKey { get; set; } = string.Empty;

	[JsonPropertyName("Passphrase")]
	public string Passphrase { get; set; } = string.Empty;

	[JsonPropertyName("StorjBucket")]
	public string StorjBucket { get; set; } = string.Empty;

	[JsonPropertyName("StorjBucketPrefix")]
	public string StorjBucketPrefix { get; set; } = string.Empty;

	public StorjDestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public StorjDestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<StorjDestinationLocation>(jsStr);
	}

}
}
