// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>AdminSecurityOptions</c>
/// </summary>
public class AdminSecurityOptions {

	[JsonPropertyName("PasswordFormat")]
	//One of the PASSWORD_FORMAT_ constants
	public long PasswordFormat { get; set; }

	[JsonPropertyName("Password")]
	public string Password { get; set; } = string.Empty;

	[JsonPropertyName("AllowPasswordLogin")]
	public bool AllowPasswordLogin { get; set; }

	[JsonPropertyName("AllowPasswordAndTOTPLogin")]
	public bool AllowPasswordAndTOTPLogin { get; set; }

	[Obsolete("Deprecated since Comet version 21.12.0")]

	[JsonPropertyName("AllowPasswordAndU2FLogin")]
	public bool AllowPasswordAndU2FLogin { get; set; }

	[JsonPropertyName("AllowPasswordAndWebAuthnLogin")]
	public bool AllowPasswordAndWebAuthnLogin { get; set; }

	[Obsolete("Deprecated since Comet version 21.12.0")]

	[JsonPropertyName("U2FRegistrations")]
	public List<AdminU2FRegistration> U2FRegistrations { get; set; }

	[JsonPropertyName("WebAuthnRegistrations")]
	public List<AdminWebAuthnRegistration> WebAuthnRegistrations { get; set; }

	[JsonPropertyName("RequirePasswordChange")]
	public bool RequirePasswordChange { get; set; }

	[JsonPropertyName("TOTPKeyEncryptionFormat")]
	//One of the ENCRYPTIONMETHOD_ constants
	public long TOTPKeyEncryptionFormat { get; set; }

	[JsonPropertyName("TOTPKey")]
	public string TOTPKey { get; set; } = string.Empty;

	[JsonPropertyName("IPWhitelist")]
	//A regular expression in Go regex syntax, for which IP addresses are allowed to authenticate as this admin account
	public string IPWhitelist { get; set; } = string.Empty;

	public AdminSecurityOptions(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public AdminSecurityOptions FromJson(string jsStr) {
		return JsonSerializer.Deserialize<AdminSecurityOptions>(jsStr);
	}

}
}
