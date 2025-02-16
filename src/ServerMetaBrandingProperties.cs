// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ServerMetaBrandingProperties</c>
/// </summary>
public class ServerMetaBrandingProperties {

	[JsonPropertyName("BrandName")]
	public string BrandName { get; set; } = string.Empty;

	[JsonPropertyName("ProductName")]
	public string ProductName { get; set; } = string.Empty;

	[JsonPropertyName("HasImage")]
	//If true, this Comet Server has an image configured for its main logo. You can access it from the /gen/logo.img
	//endpoint. If false, this Comet Server has text configured for its main logo.
	public bool HasImage { get; set; }

	[JsonPropertyName("ImageEtag")]
	//A value that will change if the branding image (/gen/logo.img) changes. You can use this as a cache key.
	public string ImageEtag { get; set; } = string.Empty;

	[JsonPropertyName("TopColor")]
	//Colour in RGB hex format (e.g. "#FFFFFF")
	public string TopColor { get; set; } = string.Empty;

	[JsonPropertyName("AccentColor")]
	//Colour in RGB hex format (e.g. "#FFFFFF")
	public string AccentColor { get; set; } = string.Empty;

	[JsonPropertyName("HideNewsArea")]
	public bool HideNewsArea { get; set; }

	[JsonPropertyName("AllowUnauthenticatedDownloads")]
	public bool AllowUnauthenticatedDownloads { get; set; }

	[JsonPropertyName("AllowAuthenticatedDownloads")]
	public bool AllowAuthenticatedDownloads { get; set; }

	[JsonPropertyName("PruneLogsAfterDays")]
	public long PruneLogsAfterDays { get; set; }

	[JsonPropertyName("ExpiredInSeconds")]
	public long ExpiredInSeconds { get; set; }

	[JsonPropertyName("ExternalAuthenticationSources")]
	public List<ExternalAuthenticationSourceDisplay> ExternalAuthenticationSources { get; set; }

	[JsonPropertyName("ServerIsEmpty")]
	//If true, this Comet Server currently has no admins or users.
	public bool ServerIsEmpty { get; set; }

	[JsonPropertyName("CloudStorageName")]
	public string CloudStorageName { get; set; } = string.Empty;

	[JsonPropertyName("AdminHidePreBuiltClientOption")]
	//Will hide the "Pre-built software client" option from the server settings. Only properly enforced when custom
	//branding is enforced via the license.
	public bool AdminHidePreBuiltClientOption { get; set; }

	[JsonPropertyName("AdminHideBrandedCloudStorage")]
	//Will hide Comet Storage from everywhere, including the admin view. Only properly enforced when custom branding is
	//enforced via the license.
	public bool AdminHideBrandedCloudStorage { get; set; }

	public ServerMetaBrandingProperties(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ServerMetaBrandingProperties FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ServerMetaBrandingProperties>(jsStr);
	}

}
}
