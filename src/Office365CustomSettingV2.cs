// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>Office365CustomSettingV2</c> Office365CustomSettingV2 is used in the EngineProps for an Office 365
/// Protected Item (see ENGINE_BUILTIN_MSOFFICE).
/// Since Version : 21.9.xx
/// </summary>
public class Office365CustomSettingV2 {

	[Obsolete("Deprecated since Comet version 24.12.2")]

	[JsonPropertyName("Organization")]
	//If true, then backup everything except the selected users (group members are still included)
	public bool Organization { get; set; }

	[JsonPropertyName("FilterMode")]
	//If true, exclude all filtered IDs and Members. Backup everything else
	public bool FilterMode { get; set; }

	[JsonPropertyName("BackupOptions")]
	//Key is the ID of User, Group, or Site
	//Value is a bitset of the SERVICE_ constants, to select which services to back up for members
	public Dictionary<string, long> BackupOptions { get; set; }

	[JsonPropertyName("MemberBackupOptions")]
	//Key is the ID of a Group or Team Site
	//Value is a bitset of the SERVICE_ constants, to select which services to back up for members
	public Dictionary<string, long> MemberBackupOptions { get; set; }

	[JsonPropertyName("FilterOptions")]
	//Key is the ID of a User, Group, or Site
	//Value is a bitset of the SERVICE_ constants, to select which services to back up for members
	public Dictionary<string, long> FilterOptions { get; set; }

	[JsonPropertyName("FilterMemberOptions")]
	//Key is the ID of a Group or Team Site
	//Value is a bitset of the SERVICE_ constants, to select which services to back up for members
	public Dictionary<string, long> FilterMemberOptions { get; set; }

	public Office365CustomSettingV2(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public Office365CustomSettingV2 FromJson(string jsStr) {
		return JsonSerializer.Deserialize<Office365CustomSettingV2>(jsStr);
	}

}
}
