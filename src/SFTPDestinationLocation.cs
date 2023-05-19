// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SFTPDestinationLocation</c>
/// </summary>
public class SFTPDestinationLocation {
	public string SFTPServer { get; set; } = string.Empty;
	public string SFTPUsername { get; set; } = string.Empty;
	public string SFTPRemotePath { get; set; } = string.Empty;
	public ulong SFTPAuthMode { get; set; }
	public string SFTPPassword { get; set; } = string.Empty;
	public string SFTPPrivateKey { get; set; } = string.Empty;
	public bool SFTPCustomAuth_UseKnownHostsFile { get; set; }
	public string SFTPCustomAuth_KnownHostsFile { get; set; } = string.Empty;

	public SFTPDestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SFTPDestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SFTPDestinationLocation>(jsStr);
	}

}
}
