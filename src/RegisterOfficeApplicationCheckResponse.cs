// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>RegisterOfficeApplicationCheckResponse</c>
/// </summary>
public class RegisterOfficeApplicationCheckResponse {

	[JsonPropertyName("Continuation")]
	public string Continuation { get; set; } = string.Empty;

	[JsonPropertyName("Completed")]
	public bool Completed { get; set; }

	[JsonPropertyName("Error")]
	public string Error { get; set; } = string.Empty;

	[JsonPropertyName("Result")]
	public Office365Credential Result { get; set; }

	public RegisterOfficeApplicationCheckResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public RegisterOfficeApplicationCheckResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<RegisterOfficeApplicationCheckResponse>(jsStr);
	}

}
}
