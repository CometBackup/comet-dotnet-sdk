// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>FileOption</c> FileOption defines the configuration for Comet Server to log live events to a file. See the
/// SEVT_ constants for more information.
/// Since Version : 23.3.7
/// </summary>
public class FileOption {

	[JsonPropertyName("Filename")]
	//The prefix for the log filename. It will be stored in the same file location as the Comet Server log files
	public string Filename { get; set; } = string.Empty;

	[JsonPropertyName("AllowEventTypes")]
	//Configure a subset of allowed event types (see SEVT_ constants). If the array is empty, all events will be sent
	public List<long> AllowEventTypes { get; set; }

	[JsonPropertyName("Level")]
	//One of the STREAM_LEVEL_ constants. This controls how much data is logged into the file
	public string Level { get; set; } = string.Empty;

	[JsonPropertyName("PruningEnabled")]
	//Enables pruning of log files
	public bool PruningEnabled { get; set; }

	[JsonPropertyName("PruningLimit")]
	//Limit in days to keep log files when PruningEnabled is set to true. If not set or 0, uses server's PruneLogsAfterDays
	public long PruningLimit { get; set; }

	public FileOption(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public FileOption FromJson(string jsStr) {
		return JsonSerializer.Deserialize<FileOption>(jsStr);
	}

}
}
