// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SessionKeyRegeneratedResponse</c>
/// </summary>
public class SessionKeyRegeneratedResponse {
	public long Status { get; set; }
	public string Message { get; set; } = string.Empty;
	public string SessionKey { get; set; } = string.Empty;
	public string SessionType { get; set; } = string.Empty;

	public SessionKeyRegeneratedResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SessionKeyRegeneratedResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SessionKeyRegeneratedResponse>(jsStr);
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
