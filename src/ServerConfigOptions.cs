// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ServerConfigOptions</c>
/// </summary>
public class ServerConfigOptions {
	public List<AllowedAdminUser> AdminUsers { get; set; }
	public AuthenticationRoleOptions AuthenticationRole { get; set; }
	public BrandingOptions Branding { get; set; }
	public ConstellationRoleOptions ConstellationRole { get; set; }

	[JsonPropertyName("OverseerRole")]
	public ConstellationRoleOptions ConstellationRole_Legacy { get; set; }
	public EmailOptions Email { get; set; }
	public List<string> ExperimentalOptions { get; set; }
	public Dictionary<string, ExternalAuthenticationSource> ExternalAdminUserSources { get; set; }
	public RatelimitOptions IPRateLimit { get; set; }
	public LicenseOptions License { get; set; }
	public List<HTTPConnectorOptions> ListenAddresses { get; set; }
	public Dictionary<string, Organization> Organizations { get; set; }
	public List<PSAConfig> PSAConfigs { get; set; }
	public SelfBackupOptions SelfBackup { get; set; }
	public SessionOptions SessionSettings { get; set; }
	public SoftwareBuildRoleOptions SoftwareBuildRole { get; set; }
	public StorageRoleOptions StorageRole { get; set; }
	public bool TrustXForwardedFor { get; set; }
	public Dictionary<string, WebhookOption> WebhookOptions { get; set; }

	public ServerConfigOptions(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ServerConfigOptions FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ServerConfigOptions>(jsStr);
	}

}
}
