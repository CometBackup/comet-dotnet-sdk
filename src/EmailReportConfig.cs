// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>EmailReportConfig</c>
/// </summary>
public class EmailReportConfig {
	//One of the EMAILREPORTTYPE_ constants
	public long ReportType { get; set; }
	//Used as a list of scheduled times to send
	public List<ScheduleConfig> SummaryFrequency { get; set; }
	//Used to the determine the time bounds of a report
	public TimeSpan TimeSpan { get; set; }
	public SearchClause Filter { get; set; }

	public EmailReportConfig(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public EmailReportConfig FromJson(string jsStr) {
		return JsonSerializer.Deserialize<EmailReportConfig>(jsStr);
	}

}
}
