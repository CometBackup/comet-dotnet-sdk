// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>RegisterOfficeApplicationBeginResponse</c>
/// </summary>
public class RegisterOfficeApplicationBeginResponse {

	[JsonPropertyName("Continuation")]
	public string Continuation { get; set; } = string.Empty;

	[JsonPropertyName("VerificationURL")]
	public string VerificationURL { get; set; } = string.Empty;

	[JsonPropertyName("UserCode")]
	public string UserCode { get; set; } = string.Empty;

	public RegisterOfficeApplicationBeginResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public RegisterOfficeApplicationBeginResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<RegisterOfficeApplicationBeginResponse>(jsStr);
	}

}
}
