// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>ScheduleConfig</c>
/// </summary>
public class ScheduleConfig {
	public ulong FrequencyType { get; set; }
	public ulong SecondsPast { get; set; }
	public long Offset { get; set; }
	public bool RestrictRuntime { get; set; }
	public HourSchedConfig FromTime { get; set; }
	public HourSchedConfig ToTime { get; set; }
	public bool RestrictDays { get; set; }
	public DaysOfWeekConfig DaysSelect { get; set; }
	public ulong RandomDelaySecs { get; set; }

	public ScheduleConfig(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public ScheduleConfig FromJson(string jsStr) {
		return JsonSerializer.Deserialize<ScheduleConfig>(jsStr);
	}

}
}
