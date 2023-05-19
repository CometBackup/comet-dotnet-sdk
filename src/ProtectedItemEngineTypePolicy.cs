// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ProtectedItemEngineTypePolicy</c>
/// </summary>
public class ProtectedItemEngineTypePolicy {
	public bool ShouldRestrictEngineTypeList { get; set; }
	public List<string> AllowedEngineTypeWhenRestricted { get; set; }

	public ProtectedItemEngineTypePolicy(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ProtectedItemEngineTypePolicy FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ProtectedItemEngineTypePolicy>(jsStr);
	}

}
}
