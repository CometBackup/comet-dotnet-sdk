// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>DispatcherStoredObjectsResponse</c>
/// </summary>
public class DispatcherStoredObjectsResponse {
	public long Status { get; set; }
	public string Message { get; set; } = "";
	public List<StoredObject> StoredObjects { get; set; } = new List<StoredObject>();

	public DispatcherStoredObjectsResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public DispatcherStoredObjectsResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<DispatcherStoredObjectsResponse>(jsStr);
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
