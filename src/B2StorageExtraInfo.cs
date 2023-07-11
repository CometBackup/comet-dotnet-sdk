// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>B2StorageExtraInfo</c>
/// </summary>
public class B2StorageExtraInfo {

	[JsonPropertyName("TotalTransactionsInTimeInterval")]
	public Dictionary<long, B2TransactionTotals> TotalTransactionsInTimeInterval { get; set; }

	public B2StorageExtraInfo(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public B2StorageExtraInfo FromJson(string jsStr) {
		return JsonSerializer.Deserialize<B2StorageExtraInfo>(jsStr);
	}

}
}
