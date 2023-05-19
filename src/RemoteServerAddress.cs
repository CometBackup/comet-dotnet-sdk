// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>RemoteServerAddress</c>
/// </summary>
public class RemoteServerAddress {
	public string Type { get; set; } = "";
	public string Description { get; set; } = "";
	public string RemoteAddress { get; set; } = "";
	public string Username { get; set; } = "";
	public string Password { get; set; } = "";
	public ExternalLDAPAuthenticationSourceSettings LDAP { get; set; } = new ExternalLDAPAuthenticationSourceSettings();
	public B2VirtualStorageRoleSettings B2 { get; set; } = new B2VirtualStorageRoleSettings();
	public WasabiVirtualStorageRoleSettings Wasabi { get; set; } = new WasabiVirtualStorageRoleSettings();
	public CustomRemoteBucketSettings Custom { get; set; } = new CustomRemoteBucketSettings();
	public S3GenericVirtualStorageRole S3 { get; set; } = new S3GenericVirtualStorageRole();
	public AmazonAWSVirtualStorageRoleSettings AWS { get; set; } = new AmazonAWSVirtualStorageRoleSettings();
	public StorjVirtualStorageRoleSetting Storj { get; set; } = new StorjVirtualStorageRoleSetting();

	public RemoteServerAddress(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public RemoteServerAddress FromJson(string jsStr) {
		return JsonSerializer.Deserialize<RemoteServerAddress>(jsStr);
	}

}
}
