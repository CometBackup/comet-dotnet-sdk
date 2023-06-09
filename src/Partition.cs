// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>Partition</c>
/// </summary>
public class Partition {

	[JsonPropertyName("DeviceName")]
	public string DeviceName { get; set; } = string.Empty;

	[JsonPropertyName("Filesystem")]
	//The name of the filesystem used on this partition (e.g. "NTFS")
	public string Filesystem { get; set; } = string.Empty;

	[JsonPropertyName("VolumeName")]
	public string VolumeName { get; set; } = string.Empty;

	[JsonPropertyName("VolumeGuid")]
	public string VolumeGuid { get; set; } = string.Empty;

	[JsonPropertyName("VolumeSerial")]
	public string VolumeSerial { get; set; } = string.Empty;

	[JsonPropertyName("MountPoints")]
	public List<string> MountPoints { get; set; }

	[JsonPropertyName("ReadOffset")]
	//Bytes. The partition's offset within the DeviceName. It will be zero if this partition has a direct DeviceName
	//handle.
	public long ReadOffset { get; set; }

	[JsonPropertyName("Size")]
	//Bytes
	public long Size { get; set; }

	[JsonPropertyName("UsedSize")]
	//Bytes. Only present for supported filesystems that are currently mounted by the OS
	public long UsedSize { get; set; }

	[JsonPropertyName("Flags")]
	public long Flags { get; set; }

	[JsonPropertyName("BytesPerFilesystemCluster")]
	public long BytesPerFilesystemCluster { get; set; }

	public Partition(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public Partition FromJson(string jsStr) {
		return JsonSerializer.Deserialize<Partition>(jsStr);
	}

}
}
