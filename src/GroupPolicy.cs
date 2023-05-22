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
	public string Description { get; set; } = string.Empty;
	public string OrganizationID { get; set; } = string.Empty;
	public UserPolicy Policy { get; set; }
	//DefaultUserPolicy marks that this UserPolicy should be applied to all new users. The Comet Server will ensure that
	//only one policy can be set as default.
	public bool DefaultUserPolicy { get; set; }
	//Unix timestamp in seconds. May be zero for Policies created prior to Comet 23.3.3.
	public long CreatedDate { get; set; }
	//Unix timestamp in seconds. May be zero for Policies created prior to Comet 23.3.3.
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
