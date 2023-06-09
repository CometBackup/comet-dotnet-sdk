// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>SpannedDestinationLocation</c>
/// </summary>
public class SpannedDestinationLocation {

	[JsonPropertyName("SpanTargets")]
	//A list of underlying destinations, that will be combined and presented as one.
	public List<DestinationLocation> SpanTargets { get; set; }

	[JsonPropertyName("SpanUseStaticSlots")]
	//If true, this Spanned destination will use a consistent hashing scheme
	//to immediately find specific files on exactly one of the target destinations.
	//In the Static Slots mode, the span targets cannot be moved or merged, and
	//the files must always remain in their original location.
	//
	//If false, the Spanned destination system will search all targets to find
	//the requested file. This is slightly slower, but allows you to freely merge,
	//split, and reorder the underlying destination locations.
	//
	//The default option is false.
	public bool SpanUseStaticSlots { get; set; }

	public SpannedDestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public SpannedDestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<SpannedDestinationLocation>(jsStr);
	}

}
}
