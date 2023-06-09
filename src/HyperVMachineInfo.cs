// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>HyperVMachineInfo</c>
/// </summary>
public class HyperVMachineInfo {

	[JsonPropertyName("ID")]
	public string ID { get; set; } = string.Empty;

	[JsonPropertyName("Name")]
	public string DisplayName { get; set; } = string.Empty;

	public HyperVMachineInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public HyperVMachineInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<HyperVMachineInfo>(jsStr);
	}

}
}
