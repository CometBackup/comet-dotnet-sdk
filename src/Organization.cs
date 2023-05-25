// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>Organization</c>
/// </summary>
public class Organization {
	public string Name { get; set; } = string.Empty;
	public List<string> Hosts { get; set; }
	public SoftwareBuildRoleOptions SoftwareBuildRole { get; set; }
	public BrandingOptions Branding { get; set; }
	public List<RemoteStorageOption> RemoteStorage { get; set; }
	public ConstellationRoleOptions ConstellationRole { get; set; }
	public Dictionary<string, WebhookOption> WebhookOptions { get; set; }
	public List<PSAConfig> PSAConfigs { get; set; }
	public EmailOptions Email { get; set; }
	public bool IsSuspended { get; set; }
	public List<string> ExperimentalOptions { get; set; }

	public Organization(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public Organization FromJson(string jsStr) {
		return JsonSerializer.Deserialize<Organization>(jsStr);
	}

}
}