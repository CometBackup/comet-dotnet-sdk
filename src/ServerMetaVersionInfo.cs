// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ServerMetaVersionInfo</c>
/// </summary>
public class ServerMetaVersionInfo {

	[JsonPropertyName("Version")]
	public string Version { get; set; } = string.Empty;

	[JsonPropertyName("VersionCodename")]
	public string VersionCodename { get; set; } = string.Empty;

	[JsonPropertyName("StorageRole")]
	public bool StorageRole { get; set; }

	[JsonPropertyName("AuthenticationRole")]
	public bool AuthenticationRole { get; set; }

	[JsonPropertyName("SoftwareBuildRole")]
	public bool SoftwareBuildRole { get; set; }

	[Obsolete("Deprecated since Comet version 18.2.0 \"Overseer Role\" was the old name for the Constellation Role. This field is a duplicate of ConstellationRole for backward compatibility with earlier API consumers.")]

	[JsonPropertyName("OverseerRole")]
	public bool ConstellationRole_Legacy { get; set; }

	[JsonPropertyName("ConstellationRole")]
	public bool ConstellationRole { get; set; }

	[JsonPropertyName("ExperimentalOptions")]
	public List<string> ExperimentalOptions { get; set; }

	[JsonPropertyName("ServerStartTime")]
	//Unix timestamp, in seconds.
	public long ServerStartTime { get; set; }

	[JsonPropertyName("ServerStartHash")]
	//A GUID that was randomly generated when this Comet Server started up. You can check this value to see if the Comet
	//Server has restarted.
	public string ServerStartHash { get; set; } = string.Empty;

	[JsonPropertyName("CurrentTime")]
	//The current time on the Comet Server host machine. Unix timestamp, in seconds. You can check this value to see if
	//clock drift is occuring.
	public long CurrentTime { get; set; }

	[JsonPropertyName("ServerLicenseHash")]
	//A hash derived from the Comet Server's serial number. You can check this value to see if two Comet Server endpoints
	//point to an identical server.
	public string ServerLicenseHash { get; set; } = string.Empty;

	[Obsolete("Deprecated since Comet version 24.9.x")]

	[JsonPropertyName("ServerLicenseFeaturesAll")]
	public bool ServerLicenseFeaturesAll { get; set; }

	[JsonPropertyName("ServerLicenseFeatureSet")]
	//A bitset of feature flags representing functionality available in this Comet Server's plan
	public uint ServerLicenseFeatureSet { get; set; }

	[JsonPropertyName("ServerLicenseLimit")]
	//If non-zero, the maximum numbers of devices and Protected Item types that this server is allowed.
	public LicenseLimits ServerLicenseLimit { get; set; }

	[JsonPropertyName("ConfiguredDevices")]
	//A count of the devices registered on the server that have a configured Protected Item.
	public long ConfiguredDevices { get; set; }

	[JsonPropertyName("BoosterLimit")]
	//The current number of Protected Item types configured on the server.
	public Dictionary<string, long> BoosterLimit { get; set; }

	[JsonPropertyName("LicenseValidUntil")]
	//Unix timestamp, in seconds.
	public long LicenseValidUntil { get; set; }

	[JsonPropertyName("EmailsSentSuccessfully")]
	public long EmailsSentSuccessfully { get; set; }

	[JsonPropertyName("EmailsSentErrors")]
	public long EmailsSentErrors { get; set; }

	[JsonPropertyName("EmailsWaitingInQueue")]
	public long EmailsWaitingInQueue { get; set; }

	[JsonPropertyName("ScheduledEmailThreadCurrentState")]
	public long ScheduledEmailThreadCurrentState { get; set; }

	[JsonPropertyName("ScheduledEmailThreadLastCalculateDurationNanos")]
	public long ScheduledEmailThreadLastCalculateDurationNanos { get; set; }

	[JsonPropertyName("ScheduledEmailThreadWaitingUntil")]
	public long ScheduledEmailThreadWaitingUntil { get; set; }

	[JsonPropertyName("ScheduledEmailThreadLastWakeTime")]
	public long ScheduledEmailThreadLastWakeTime { get; set; }

	[JsonPropertyName("ScheduledEmailThreadLastWakeSentEmails")]
	public bool ScheduledEmailThreadLastWakeSentEmails { get; set; }

	[JsonPropertyName("SelfBackup")]
	public List<SelfBackupStatistics> SelfBackup { get; set; }

	public ServerMetaVersionInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ServerMetaVersionInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ServerMetaVersionInfo>(jsStr);
	}

}
}
