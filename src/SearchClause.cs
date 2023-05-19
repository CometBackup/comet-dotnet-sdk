// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SearchClause</c>
/// </summary>
public class SearchClause {
	public string ClauseType { get; set; } = "";
	public string RuleField { get; set; } = "";
	public string RuleOperator { get; set; } = "";
	public string RuleValue { get; set; } = "";
	public List<SearchClause> ClauseChildren { get; set; } = new List<SearchClause>();

	public SearchClause(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SearchClause FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SearchClause>(jsStr);
	}

}
}
