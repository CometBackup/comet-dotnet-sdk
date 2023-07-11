// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>WebInterfaceBrandingProperties</c>
/// </summary>
public class WebInterfaceBrandingProperties {

	[JsonPropertyName("BrandingStyleType")]
	//One of the BRANDINGSTYLETYPE_ constants
	public long BrandingStyleType { get; set; }

	[JsonPropertyName("BrandName")]
	public string BrandName { get; set; } = string.Empty;

	[JsonPropertyName("LogoImage")]
	public string LogoImage { get; set; } = string.Empty;

	[JsonPropertyName("TopColor")]
	public string TopColor { get; set; } = string.Empty;

	[JsonPropertyName("AccentColor")]
	public string AccentColor { get; set; } = string.Empty;

	[JsonPropertyName("Favicon")]
	public string Favicon { get; set; } = string.Empty;

	[JsonPropertyName("HideNewsArea")]
	public bool HideNewsArea { get; set; }

	public WebInterfaceBrandingProperties(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public WebInterfaceBrandingProperties FromJson(string jsStr) {
		return JsonSerializer.Deserialize<WebInterfaceBrandingProperties>(jsStr);
	}

}
}
