// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ReplicaServer</c>
/// </summary>
public class ReplicaServer {
	public string Type { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public string RemoteAddress { get; set; } = string.Empty;
	public string Username { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;
	public ExternalLDAPAuthenticationSourceSettings LDAP { get; set; }
	public B2VirtualStorageRoleSettings B2 { get; set; }
	public WasabiVirtualStorageRoleSettings Wasabi { get; set; }
	public CustomRemoteBucketSettings Custom { get; set; }
	public S3GenericVirtualStorageRole S3 { get; set; }
	public AmazonAWSVirtualStorageRoleSettings AWS { get; set; }
	public StorjVirtualStorageRoleSetting Storj { get; set; }
	public string ReplicaDeletionStrategy { get; set; } = string.Empty;

	public ReplicaServer(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ReplicaServer FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ReplicaServer>(jsStr);
	}

	public RemoteServerAddress GetEmbeddedRemoteServerAddress() => new RemoteServerAddress {
		Type = this.Type,
		Description = this.Description,
		RemoteAddress = this.RemoteAddress,
		Username = this.Username,
		Password = this.Password,
		LDAP = this.LDAP,
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
		this.B2 = other.B2;
		this.Wasabi = other.Wasabi;
		this.Custom = other.Custom;
		this.S3 = other.S3;
		this.AWS = other.AWS;
		this.Storj = other.Storj;
	}

}
}
