// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>StoredObject</c>
/// </summary>
public class StoredObject {

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("mtime")]
	public long ModifyTime { get; set; }

	[JsonPropertyName("type")]
	//One of the STOREDOBJECTTYPE_... constant values
	public string Type { get; set; } = string.Empty;

	[JsonPropertyName("subtree")]
	public string Subtree { get; set; } = string.Empty;

	[JsonPropertyName("size")]
	public ulong Size { get; set; }

	[JsonPropertyName("dname")]
	public string DisplayName { get; set; } = string.Empty;

	[JsonPropertyName("itemClass")]
	public string ItemClass { get; set; } = string.Empty;

	[JsonPropertyName("from")]
	public string From { get; set; } = string.Empty;

	[JsonPropertyName("to")]
	public string To { get; set; } = string.Empty;

	[JsonPropertyName("rtime")]
	public long ReceivedDateTime { get; set; }

	[JsonPropertyName("has_attachments")]
	public bool HasAttachments { get; set; }

	[JsonPropertyName("stime")]
	public long StartTime { get; set; }

	[JsonPropertyName("etime")]
	public long EndTime { get; set; }

	[JsonPropertyName("r")]
	public bool RecursiveCountKnown { get; set; }

	[JsonPropertyName("f")]
	public ulong RecursiveFiles { get; set; }

	[JsonPropertyName("b")]
	public ulong RecursiveBytes { get; set; }

	[JsonPropertyName("d")]
	public ulong RecursiveFolders { get; set; }

	public StoredObject(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public StoredObject FromJson(string jsStr) {
		return JsonSerializer.Deserialize<StoredObject>(jsStr);
	}

}
}