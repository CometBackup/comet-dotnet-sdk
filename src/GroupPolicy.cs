// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>GroupPolicy</c>
/// </summary>
public class GroupPolicy {
	public string Description { get; set; } = "";
	public string OrganizationID { get; set; } = "";
	public UserPolicy Policy { get; set; } = new UserPolicy();
	public bool DefaultUserPolicy { get; set; }
	public long CreatedDate { get; set; }
	public long ModifiedDate { get; set; }

	public GroupPolicy(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public GroupPolicy FromJson(string jsStr) {
		return JsonSerializer.Deserialize<GroupPolicy>(jsStr);
	}

}
}
