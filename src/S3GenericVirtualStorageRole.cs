// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>S3GenericVirtualStorageRole</c>
/// </summary>
public class S3GenericVirtualStorageRole {

	[JsonPropertyName("S3Endpoint")]
	//The URL for S3 API calls (e.g. "s3.amazonaws.com")
	public string S3Endpoint { get; set; } = string.Empty;

	[JsonPropertyName("IAMEndpoint")]
	//The URL for IAM API calls (e.g. "iam.amazonaws.com")
	public string IAMEndpoint { get; set; } = string.Empty;

	[JsonPropertyName("MasterBucket")]
	//If set, the Storage Template will generate Storage Vaults pointing to a subdirectory within this bucket. A single
	//dynamic IAM policy will cover all created Storage Vaults.
	//This is preferable for platforms that have limits on the total number of IAM policies. However, it requires a high
	//level of IAM compatibility.
	//If left blank, the Storage Template will generate Storage Vaults pointing to new, separate S3 buckets each time. An
	//additional IAM policy is created for each new Storage Vault.
	//This is preferable for platforms that have a lower level of IAM compatibility.
	public string MasterBucket { get; set; } = string.Empty;

	[JsonPropertyName("AccessKey")]
	public string AccessKey { get; set; } = string.Empty;

	[JsonPropertyName("SecretKey")]
	public string SecretKey { get; set; } = string.Empty;

	[Obsolete("Deprecated since Comet version 23.x.x")]

	[JsonPropertyName("UseObjectLock")]
	public bool UseObjectLock_Legacy_DoNotUse { get; set; }

	[JsonPropertyName("ObjectLockMode")]
	//Control whether the resulting Storage Vaults are configured for Object Lock. One of the OBJECT_LOCK_ constants
	public byte ObjectLockMode { get; set; }

	[JsonPropertyName("ObjectLockDays")]
	public long ObjectLockDays { get; set; }

	[JsonPropertyName("RemoveDeleted")]
	//Control whether the "Allow removal of deleted files" checkbox is enabled for Storage Vaults generated from this
	//Storage Template.
	//When configuring a Storage Template from the Comet Server web interface, this field is set automatically for Storage
	//Templates using Object Lock.
	public bool RemoveDeleted { get; set; }

	[JsonPropertyName("Region")]
	//Optional. The region to be used for new buckets. If blank, uses the default region for the S3-compatible provider
	//(e.g. us-east-1).
	public string Region { get; set; } = string.Empty;

	[JsonPropertyName("Prefix")]
	//Optional. Prefix to use for bucket paths.
	public string Prefix { get; set; } = string.Empty;

	public S3GenericVirtualStorageRole(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public S3GenericVirtualStorageRole FromJson(string jsStr) {
		return JsonSerializer.Deserialize<S3GenericVirtualStorageRole>(jsStr);
	}

	public AmazonAWSVirtualStorageRoleSettings GetEmbeddedAmazonAWSVirtualStorageRoleSettings() => new AmazonAWSVirtualStorageRoleSettings {
		MasterBucket = this.MasterBucket,
		AccessKey = this.AccessKey,
		SecretKey = this.SecretKey,
		UseObjectLock_Legacy_DoNotUse = this.UseObjectLock_Legacy_DoNotUse,
		ObjectLockMode = this.ObjectLockMode,
		ObjectLockDays = this.ObjectLockDays,
		RemoveDeleted = this.RemoveDeleted,
	};

	public void SetEmbeddedAmazonAWSVirtualStorageRoleSettings(AmazonAWSVirtualStorageRoleSettings other){
		this.MasterBucket = other.MasterBucket;
		this.AccessKey = other.AccessKey;
		this.SecretKey = other.SecretKey;
		this.UseObjectLock_Legacy_DoNotUse = other.UseObjectLock_Legacy_DoNotUse;
		this.ObjectLockMode = other.ObjectLockMode;
		this.ObjectLockDays = other.ObjectLockDays;
		this.RemoveDeleted = other.RemoveDeleted;
	}

}
}
