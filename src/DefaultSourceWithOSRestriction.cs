// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>DefaultSourceWithOSRestriction</c>
/// </summary>
public class DefaultSourceWithOSRestriction {

	[JsonPropertyName("SourceConfig")]
	public SourceConfig SourceConfig { get; set; }

	[JsonPropertyName("RestrictOS")]
	public long RestrictOS { get; set; }

	public DefaultSourceWithOSRestriction(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public DefaultSourceWithOSRestriction FromJson(string jsStr) {
		return JsonSerializer.Deserialize<DefaultSourceWithOSRestriction>(jsStr);
	}

}
}
