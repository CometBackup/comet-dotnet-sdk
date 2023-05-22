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
	public string BrandName { get; set; } = string.Empty;
	public string ProductName { get; set; } = string.Empty;
	//If true, this Comet Server has an image configured for its main logo. You can access it from the /gen/logo.img
	//endpoint. If false, this Comet Server has text configured for its main logo.
	public bool HasImage { get; set; }
	//A value that will change if the branding image (/gen/logo.img) changes. You can use this as a cache key.
	public string ImageEtag { get; set; } = string.Empty;
	public string TopColor { get; set; } = string.Empty;
	public string AccentColor { get; set; } = string.Empty;
	public bool HideNewsArea { get; set; }
	public bool AllowUnauthenticatedDownloads { get; set; }
	public bool AllowAuthenticatedDownloads { get; set; }
	public long PruneLogsAfterDays { get; set; }
	public long ExpiredInSeconds { get; set; }

	public ServerMetaBrandingProperties(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ServerMetaBrandingProperties FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ServerMetaBrandingProperties>(jsStr);
	}

}
}
