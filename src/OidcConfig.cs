// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>OidcConfig</c>
/// </summary>
public class OidcConfig {

	[JsonPropertyName("DisplayName")]
	public string DisplayName { get; set; } = string.Empty;

	[JsonPropertyName("Hosts")]
	public List<string> Hosts { get; set; }

	[JsonPropertyName("OrganizationID")]
	public string OrganizationID { get; set; } = string.Empty;

	[JsonPropertyName("Provider")]
	public string Provider { get; set; } = string.Empty;

	[JsonPropertyName("ClientID")]
	public string ClientID { get; set; } = string.Empty;

	[JsonPropertyName("ClientSecret")]
	public string ClientSecret { get; set; } = string.Empty;

	[JsonPropertyName("SkipMFA")]
	public bool SkipMFA { get; set; }

	[JsonPropertyName("Scopes")]
	public List<string> Scopes { get; set; }

	[JsonPropertyName("RequiredClaims")]
	public List<OidcClaim> RequiredClaims { get; set; }

	[JsonPropertyName("DiscoveryDocumentURL")]
	public string GenericOP_DiscoveryDocumentURL { get; set; } = string.Empty;

	[JsonPropertyName("AzureTenantID")]
	public string AzureADV2OP_TenantID { get; set; } = string.Empty;

	[JsonPropertyName("GoogleHostedDomain")]
	public string GoogleOP_HostedDomain { get; set; } = string.Empty;

	public OidcConfig(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public OidcConfig FromJson(string jsStr) {
		return JsonSerializer.Deserialize<OidcConfig>(jsStr);
	}

}
}
