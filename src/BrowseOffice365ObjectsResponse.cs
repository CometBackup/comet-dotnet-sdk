// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>BrowseOffice365ObjectsResponse</c>
/// </summary>
public class BrowseOffice365ObjectsResponse {
	//If the operation was successful, the status will be in the 200-299 range.
	public long Status { get; set; }
	public string Message { get; set; } = string.Empty;
	public List<Office365ObjectInfo> Objects { get; set; }

	public BrowseOffice365ObjectsResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public BrowseOffice365ObjectsResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<BrowseOffice365ObjectsResponse>(jsStr);
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
