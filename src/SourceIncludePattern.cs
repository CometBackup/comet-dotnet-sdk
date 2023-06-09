// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SourceIncludePattern</c> SourceIncludePattern is used for pattern inclusions for File and Folder Protected
/// Items (ENGINE_BUILTIN_FILE).
/// It should be marshalled as JSON and then stored in the PINCLUDE / RINCLUDE EngineProp keys.
/// </summary>
public class SourceIncludePattern {

	[JsonPropertyName("TopDirectory")]
	//The filesystem path to search within, for matches
	public string TopDirectory { get; set; } = string.Empty;

	[JsonPropertyName("Value")]
	//The pattern (glob or regex format) to match
	public string Value { get; set; } = string.Empty;

	public SourceIncludePattern(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SourceIncludePattern FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SourceIncludePattern>(jsStr);
	}

}
}
