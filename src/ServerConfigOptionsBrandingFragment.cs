// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ServerConfigOptionsBrandingFragment</c>
/// </summary>
public class ServerConfigOptionsBrandingFragment {
	public BrandingOptions Branding { get; set; } = new BrandingOptions();

	public ServerConfigOptionsBrandingFragment(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ServerConfigOptionsBrandingFragment FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ServerConfigOptionsBrandingFragment>(jsStr);
	}

}
}
