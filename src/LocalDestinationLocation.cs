// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>LocalDestinationLocation</c>
/// </summary>
public class LocalDestinationLocation {
	public string LocalcopyPath { get; set; } = string.Empty;
	//If logging in to a Windows network share (SMB/CIFS) is required, enter the username here.
	public string LocalcopyWinSMBUsername { get; set; } = string.Empty;
	//If logging in to a Windows network share (SMB/CIFS) is required, enter the password here. The password may be hashed
	//as per the LocalcopyWinSMBPasswordFormat field.
	public string LocalcopyWinSMBPassword { get; set; } = string.Empty;
	//One of the PASSWORD_FORMAT_ constants. It controls the hash format of the LocalcopyWinSMBPassword field.
	public ulong LocalcopyWinSMBPasswordFormat { get; set; }

	public LocalDestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public LocalDestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<LocalDestinationLocation>(jsStr);
	}

}
}
