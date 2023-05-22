// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>CometAPIResponseMessage</c>
/// </summary>
public class CometAPIResponseMessage {
	//If the operation was successful, the status will be in the 200-299 range.
	public long Status { get; set; }
	public string Message { get; set; } = string.Empty;

	public CometAPIResponseMessage(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public CometAPIResponseMessage FromJson(string jsStr) {
		return JsonSerializer.Deserialize<CometAPIResponseMessage>(jsStr);
	}

}
}
