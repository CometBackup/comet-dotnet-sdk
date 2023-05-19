// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>BrowseHVResponse</c>
/// </summary>
public class BrowseHVResponse {
	public long Status { get; set; }
	public string Message { get; set; } = string.Empty;
	public List<HyperVMachineInfo> VirtualMachines { get; set; }

	public BrowseHVResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public BrowseHVResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<BrowseHVResponse>(jsStr);
	}

	public CometAPIResponseMessage GetEmbeddedCometAPIResponseMessage() => new CometAPIResponseMessage {
		Status = this.Status,
		Message = this.Message,
	};

	public void SetEmbeddedCometAPIResponseMessage(CometAPIResponseMessage other){
		this.Status = other.Status;
		this.Message = other.Message;
	}

}
}
