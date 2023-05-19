// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>Office365CustomSetting</c>
/// </summary>
[Obsolete("Deprecated since Comet version 21.9.xx")]
public class Office365CustomSetting {
	public string MailboxStrategy { get; set; } = string.Empty;
	public string SiteStrategy { get; set; } = string.Empty;
	public List<string> MailboxUserIDs { get; set; }
	public List<string> MailboxGroupIDs { get; set; }
	public List<string> SiteIDs { get; set; }

	public Office365CustomSetting(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public Office365CustomSetting FromJson(string jsStr) {
		return JsonSerializer.Deserialize<Office365CustomSetting>(jsStr);
	}

}
}
