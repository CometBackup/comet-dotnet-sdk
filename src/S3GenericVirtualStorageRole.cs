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
	public string S3Endpoint { get; set; } = string.Empty;
	public string IAMEndpoint { get; set; } = string.Empty;
	public string MasterBucket { get; set; } = string.Empty;
	public string AccessKey { get; set; } = string.Empty;
	public string SecretKey { get; set; } = string.Empty;
	public bool UseObjectLock { get; set; }
	public long ObjectLockDays { get; set; }
	public bool RemoveDeleted { get; set; }

	public S3GenericVirtualStorageRole(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public S3GenericVirtualStorageRole FromJson(string jsStr) {
		return JsonSerializer.Deserialize<S3GenericVirtualStorageRole>(jsStr);
	}

}
}