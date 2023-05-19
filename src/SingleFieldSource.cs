// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SingleFieldSource</c>
/// </summary>
public class SingleFieldSource {
	public string FieldName { get; set; } = string.Empty;
	public string FieldType { get; set; } = string.Empty;
	public bool BoolVal { get; set; }
	public long IntVal { get; set; }
	public string StrVal { get; set; } = string.Empty;

	public SingleFieldSource(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SingleFieldSource FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SingleFieldSource>(jsStr);
	}

}
}
