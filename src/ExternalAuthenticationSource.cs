// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ExternalAuthenticationSource</c>
/// </summary>
public class ExternalAuthenticationSource {

	[JsonPropertyName("Type")]
	public string Type { get; set; } = string.Empty;

	[JsonPropertyName("Description")]
	public string Description { get; set; } = string.Empty;

	[JsonPropertyName("RemoteAddress")]
	public string RemoteAddress { get; set; } = string.Empty;

	[JsonPropertyName("Username")]
	public string Username { get; set; } = string.Empty;

	[JsonPropertyName("Password")]
	public string Password { get; set; } = string.Empty;

	[JsonPropertyName("LDAP")]
	public ExternalLDAPAuthenticationSourceSettings LDAP { get; set; }

	[JsonPropertyName("OIDC")]
	public OidcConfig OIDC { get; set; }

	[JsonPropertyName("B2")]
	public B2VirtualStorageRoleSettings B2 { get; set; }

	[JsonPropertyName("Wasabi")]
	public WasabiVirtualStorageRoleSettings Wasabi { get; set; }

	[JsonPropertyName("Custom")]
	public CustomRemoteBucketSettings Custom { get; set; }

	[JsonPropertyName("S3")]
	public S3GenericVirtualStorageRole S3 { get; set; }

	[JsonPropertyName("AWS")]
	//Amazon AWS - Virtual Storage Role
	public AmazonAWSVirtualStorageRoleSettings AWS { get; set; }

	[JsonPropertyName("Storj")]
	public StorjVirtualStorageRoleSetting Storj { get; set; }

	[JsonPropertyName("NewUserPermissions")]
	public AdminUserPermissions NewUserPermissions { get; set; }

	public ExternalAuthenticationSource(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ExternalAuthenticationSource FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ExternalAuthenticationSource>(jsStr);
	}

	public RemoteServerAddress GetEmbeddedRemoteServerAddress() => new RemoteServerAddress {
		Type = this.Type,
		Description = this.Description,
		RemoteAddress = this.RemoteAddress,
		Username = this.Username,
		Password = this.Password,
		LDAP = this.LDAP,
		OIDC = this.OIDC,
		B2 = this.B2,
		Wasabi = this.Wasabi,
		Custom = this.Custom,
		S3 = this.S3,
		AWS = this.AWS,
		Storj = this.Storj,
	};

	public void SetEmbeddedRemoteServerAddress(RemoteServerAddress other){
		this.Type = other.Type;
		this.Description = other.Description;
		this.RemoteAddress = other.RemoteAddress;
		this.Username = other.Username;
		this.Password = other.Password;
		this.LDAP = other.LDAP;
		this.OIDC = other.OIDC;
		this.B2 = other.B2;
		this.Wasabi = other.Wasabi;
		this.Custom = other.Custom;
		this.S3 = other.S3;
		this.AWS = other.AWS;
		this.Storj = other.Storj;
	}

}
}
