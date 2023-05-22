// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>FTPDestinationLocation</c>
/// </summary>
public class FTPDestinationLocation {
	public string FTPServer { get; set; } = string.Empty;
	public string FTPUsername { get; set; } = string.Empty;
	public string FTPPassword { get; set; } = string.Empty;
	public bool FTPBaseUseHomeDirectory { get; set; }
	public string FTPCustomBaseDirectory { get; set; } = string.Empty;
	//One of the FTPS_MODE_ constants.
	public long FTPSMode { get; set; }
	public long FTPPort { get; set; }
	public long FTPMaxConnections { get; set; }
	public bool FTPAcceptInvalidSSL { get; set; }

	public FTPDestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public FTPDestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<FTPDestinationLocation>(jsStr);
	}

}
}
