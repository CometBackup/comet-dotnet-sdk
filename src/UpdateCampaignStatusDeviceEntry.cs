// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>UpdateCampaignStatusDeviceEntry</c>
/// </summary>
public class UpdateCampaignStatusDeviceEntry {

	[JsonPropertyName("Username")]
	public string Username { get; set; } = string.Empty;

	[JsonPropertyName("DeviceID")]
	public string DeviceID { get; set; } = string.Empty;

	[JsonPropertyName("Status")]
	//One of the UPDATESTATUS_ constants
	public long Status { get; set; }

	public UpdateCampaignStatusDeviceEntry(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public UpdateCampaignStatusDeviceEntry FromJson(string jsStr) {
		return JsonSerializer.Deserialize<UpdateCampaignStatusDeviceEntry>(jsStr);
	}

	public UpdateCampaignDeviceStatus GetEmbeddedUpdateCampaignDeviceStatus() => new UpdateCampaignDeviceStatus {
		Status = this.Status,
	};

	public void SetEmbeddedUpdateCampaignDeviceStatus(UpdateCampaignDeviceStatus other){
		this.Status = other.Status;
	}

}
}
