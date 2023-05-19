// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>U2FRegisterRequest</c>
/// </summary>
[Obsolete("Deprecated since Comet version 21.12.0")]
public class U2FRegisterRequest {
	public string Challenge { get; set; } = "";
	public string Version { get; set; } = "";

	public U2FRegisterRequest(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public U2FRegisterRequest FromJson(string jsStr) {
		return JsonSerializer.Deserialize<U2FRegisterRequest>(jsStr);
	}

}
}
