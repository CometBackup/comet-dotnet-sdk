// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>StreamableEvent</c>
/// </summary>
public class StreamableEvent {
	public string OwnerOrganizationID { get; set; } = string.Empty;
	public long Type { get; set; }
	public Object Data { get; set; }

	public StreamableEvent(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public StreamableEvent FromJson(string jsStr) {
		return JsonSerializer.Deserialize<StreamableEvent>(jsStr);
	}

}
}
