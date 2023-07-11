// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>EmailReportGeneratedPreview</c>
/// </summary>
public class EmailReportGeneratedPreview {

	[JsonPropertyName("Status")]
	//If the operation was successful, the status will be in the 200-299 range.
	public long Status { get; set; }

	[JsonPropertyName("Message")]
	public string Message { get; set; } = string.Empty;

	[JsonPropertyName("From")]
	public string From { get; set; } = string.Empty;

	[JsonPropertyName("To")]
	public List<string> To { get; set; }

	[JsonPropertyName("EmailSubject")]
	public string EmailSubject { get; set; } = string.Empty;

	[JsonPropertyName("EmailBodyHTML")]
	public string EmailBodyHTML { get; set; } = string.Empty;

	[JsonPropertyName("EmailBodyPlaintext")]
	public string EmailBodyPlaintext { get; set; } = string.Empty;

	public EmailReportGeneratedPreview(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public EmailReportGeneratedPreview FromJson(string jsStr) {
		return JsonSerializer.Deserialize<EmailReportGeneratedPreview>(jsStr);
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
