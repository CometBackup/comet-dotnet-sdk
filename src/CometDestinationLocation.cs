// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>CometDestinationLocation</c>
/// </summary>
public class CometDestinationLocation {
	//The URL for the target Comet Server Storage Role, including http/https and trailing slash
	public string CometServer { get; set; } = string.Empty;
	public string CometBucket { get; set; } = string.Empty;
	public string CometBucketKey { get; set; } = string.Empty;

	public CometDestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public CometDestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<CometDestinationLocation>(jsStr);
	}

}
}
