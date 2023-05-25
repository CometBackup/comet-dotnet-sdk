// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>RetentionRange</c>
/// </summary>
public class RetentionRange {
	public long Type { get; set; }
	public long Timestamp { get; set; }
	public long Jobs { get; set; }
	public long Days { get; set; }
	public long Weeks { get; set; }
	public long Months { get; set; }
	//0: Sunday, 6: Saturday
	public long WeekOffset { get; set; }
	public long MonthOffset { get; set; }

	public RetentionRange(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public RetentionRange FromJson(string jsStr) {
		return JsonSerializer.Deserialize<RetentionRange>(jsStr);
	}

}
}