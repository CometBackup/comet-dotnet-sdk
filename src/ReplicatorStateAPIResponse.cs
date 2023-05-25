// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ReplicatorStateAPIResponse</c>
/// </summary>
public class ReplicatorStateAPIResponse {
	public string Description { get; set; } = string.Empty;
	public string RemoteServerID { get; set; } = string.Empty;
	public long DisplayClass { get; set; }
	public int ActiveWorkers { get; set; }
	public long TotalWorkers { get; set; }
	public long State { get; set; }
	public long ItemsQueued { get; set; }
	public long BytesQueued { get; set; }
	public long LastWorkerSubmitTime { get; set; }
	public long CurrentTime { get; set; }
	public long ItemsReplicated { get; set; }
	public long BytesReplicated { get; set; }

	public ReplicatorStateAPIResponse(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ReplicatorStateAPIResponse FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ReplicatorStateAPIResponse>(jsStr);
	}

}
}