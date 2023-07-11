// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>WindowsCodeSignProperties</c>
/// </summary>
public class WindowsCodeSignProperties {

	[JsonPropertyName("WindowsCodeSignMethod")]
	//One of the WINDOWSCODESIGN_METHOD_ constants
	public long WindowsCodeSignMethod { get; set; }

	[JsonPropertyName("WindowsCodeSignPKCS12FilePath")]
	public string WindowsCodeSignPKCS12FilePath { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS12PasswordFormat")]
	//One of the ENCRYPTIONMETHOD_ constants
	public ulong WindowsCodeSignPKCS12PasswordFormat { get; set; }

	[JsonPropertyName("WindowsCodeSignPKCS12Password")]
	public string WindowsCodeSignPKCS12Password { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11Engine")]
	public string WindowsCodeSignPKCS11Engine { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11Module")]
	public string WindowsCodeSignPKCS11Module { get; set; } = string.Empty;

	[Obsolete("Deprecated since Comet version 22.12.7")]

	[JsonPropertyName("WindowsCodeSignPKCS11Certfile")]
	public string WindowsCodeSignPKCS11Certfile { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11KeyID")]
	public string WindowsCodeSignPKCS11KeyID { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11PasswordFormat")]
	//One of the ENCRYPTIONMETHOD_ constants
	public ulong WindowsCodeSignPKCS11PasswordFormat { get; set; }

	[JsonPropertyName("WindowsCodeSignPKCS11Password")]
	public string WindowsCodeSignPKCS11Password { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureVaultName")]
	public string WindowsCodeSignAzureVaultName { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureCertName")]
	public string WindowsCodeSignAzureCertName { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureAppID")]
	public string WindowsCodeSignAzureAppID { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureAppSecretFormat")]
	//One of the ENCRYPTIONMETHOD_ constants
	public ulong WindowsCodeSignAzureAppSecretFormat { get; set; }

	[JsonPropertyName("WindowsCodeSignAzureAppSecret")]
	public string WindowsCodeSignAzureAppSecret { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureTenantID")]
	public string WindowsCodeSignAzureTenantID { get; set; } = string.Empty;

	public WindowsCodeSignProperties(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public WindowsCodeSignProperties FromJson(string jsStr) {
		return JsonSerializer.Deserialize<WindowsCodeSignProperties>(jsStr);
	}

}
}
