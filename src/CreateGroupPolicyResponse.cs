// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>CreateGroupPolicyResponse</c>
/// </summary>
public class CreateGroupPolicyResponse {

	[JsonPropertyName("Status")]
	//If the operation was successful, the status will be in the 200-299 range.
	public long Status { get; set; }

	[JsonPropertyName("Message")]
	public string Message { get; set; } = string.Empty;

	[JsonPropertyName("PolicyHash")]
	public string PolicyHash { get; set; } = string.Empty;

	public CreateGroupPolicyResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public CreateGroupPolicyResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<CreateGroupPolicyResponse>(jsStr);
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
