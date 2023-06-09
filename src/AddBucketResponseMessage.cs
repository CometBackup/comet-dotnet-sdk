// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>AddBucketResponseMessage</c>
/// </summary>
public class AddBucketResponseMessage {

	[JsonPropertyName("Status")]
	//If the operation was successful, the status will be in the 200-299 range.
	public long Status { get; set; }

	[JsonPropertyName("Message")]
	public string Message { get; set; } = string.Empty;

	[JsonPropertyName("NewBucketID")]
	public string NewBucketID { get; set; } = string.Empty;

	[JsonPropertyName("NewBucketKey")]
	public string NewBucketKey { get; set; } = string.Empty;

	public AddBucketResponseMessage(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public AddBucketResponseMessage FromJson(string jsStr) {
		return JsonSerializer.Deserialize<AddBucketResponseMessage>(jsStr);
	}

	public CometAPIResponseMessage GetEmbeddedCometAPIResponseMessage() => new CometAPIResponseMessage {
		Status = this.Status,
		Message = this.Message,
	};

	public void SetEmbeddedCometAPIResponseMessage(CometAPIResponseMessage other){
		this.Status = other.Status;
		this.Message = other.Message;
	}

	public NewBucketDetail GetEmbeddedNewBucketDetail() => new NewBucketDetail {
		NewBucketID = this.NewBucketID,
		NewBucketKey = this.NewBucketKey,
	};

	public void SetEmbeddedNewBucketDetail(NewBucketDetail other){
		this.NewBucketID = other.NewBucketID;
		this.NewBucketKey = other.NewBucketKey;
	}

}
}
