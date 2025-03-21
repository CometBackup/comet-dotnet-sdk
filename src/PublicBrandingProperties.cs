// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>PublicBrandingProperties</c>
/// </summary>
public class PublicBrandingProperties {

	[JsonPropertyName("ProductName")]
	public string ProductName { get; set; } = string.Empty;

	[JsonPropertyName("CompanyName")]
	public string CompanyName { get; set; } = string.Empty;

	[JsonPropertyName("HelpURL")]
	public string HelpURL { get; set; } = string.Empty;

	[JsonPropertyName("HelpIsPopup")]
	public bool HelpIsPopup { get; set; }

	[JsonPropertyName("DefaultLoginServerURL")]
	public string DefaultLoginServerURL { get; set; } = string.Empty;

	[JsonPropertyName("TileBackgroundColor")]
	public string TileBackgroundColor { get; set; } = string.Empty;

	[JsonPropertyName("AccountRegisterURL")]
	public string AccountRegisterURL { get; set; } = string.Empty;

	[JsonPropertyName("HideBackgroundLogo")]
	public bool HideBackgroundLogo { get; set; }

	[JsonPropertyName("CloudStorageName")]
	public string CloudStorageName { get; set; } = string.Empty;

	[JsonPropertyName("AdminHidePreBuiltClientOption")]
	public bool AdminHidePreBuiltClientOption { get; set; }

	[JsonPropertyName("AdminHideBrandedCloudStorage")]
	public bool AdminHideBrandedCloudStorage { get; set; }

	public PublicBrandingProperties(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public PublicBrandingProperties FromJson(string jsStr) {
		return JsonSerializer.Deserialize<PublicBrandingProperties>(jsStr);
	}

}
}
