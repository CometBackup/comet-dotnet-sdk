// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>LiveUserConnection</c>
/// </summary>
public class LiveUserConnection {
	public string Username { get; set; } = string.Empty;
	public string DeviceID { get; set; } = string.Empty;
	//The Comet Backup software version that this live-connected device reports that it is running. It takes the format
	//"MAJOR.MINOR.PATCH", such as "23.2.0". See the APPLICATION_VERSION constant for more information.
	public string ReportedVersion { get; set; } = string.Empty;
	//The operating system of the device. It is one of the PLATFORM_ constants; then a forwardslash (/); then the device's
	//GOARCH.
	public string ReportedPlatform { get; set; } = string.Empty;
	//The operating system of the device, in extended detail.
	public OSInfo ReportedPlatformVersion { get; set; }
	//The reported timezone of the device, in IANA format.
	public string DeviceTimeZone { get; set; } = string.Empty;
	//The live-connected device's remote IP address, as seen from the Comet Server.
	public string IPAddress { get; set; } = string.Empty;
	//Unix timestamp, in seconds.
	public long ConnectionTime { get; set; }
	//The current state of the "Allow administrator to view my files" client-side option. If this option is refused, some
	//live-connected actions will be refused by the device.
	public bool AllowsFilenames { get; set; }

	public LiveUserConnection(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public LiveUserConnection FromJson(string jsStr) {
		return JsonSerializer.Deserialize<LiveUserConnection>(jsStr);
	}

}
}
