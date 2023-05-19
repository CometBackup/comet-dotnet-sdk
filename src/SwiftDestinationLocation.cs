// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SwiftDestinationLocation</c>
/// </summary>
public class SwiftDestinationLocation {
	public string Username { get; set; } = string.Empty;
	public string APIKey { get; set; } = string.Empty;
	public string Region { get; set; } = string.Empty;
	public string AuthURL { get; set; } = string.Empty;
	public string Domain { get; set; } = string.Empty;
	public string Tenant { get; set; } = string.Empty;
	public string TenantDomain { get; set; } = string.Empty;
	public string TenantID { get; set; } = string.Empty;
	public string TrustID { get; set; } = string.Empty;

	[Obsolete("Deprecated since Comet version 17.8.0")]
	public string AuthToken { get; set; } = string.Empty;
	public string Prefix { get; set; } = string.Empty;
	public string Container { get; set; } = string.Empty;
	public string DefaultContainerPolicy { get; set; } = string.Empty;

	public SwiftDestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SwiftDestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SwiftDestinationLocation>(jsStr);
	}

}
}
